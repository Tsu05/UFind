Imports System.Data.OleDb
Imports System.Text.RegularExpressions


Public Class Form2

    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\OMC_UserDatabase.accdb")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        conn.Open()

        Dim message = ""

        'checks if field is filled up
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Please fill in all fields.")
            conn.Close()
            Exit Sub ' stop the registration process
        End If

        Dim timenow As Date = Date.Now
        If DateTimePicker1.Value >= timenow Then
            MsgBox("Please select your date of birth.")
            conn.Close()
            Exit Sub
        End If

        'mnakes sure email is in the correct format
        Dim emailPattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        If Not Regex.IsMatch(TextBox2.Text, emailPattern) Then
            MsgBox("Please enter a valid email address.")
            conn.Close()
            Exit Sub
        End If



        'checks if username already exist
        Dim namechk As New OleDbCommand("SELECT UserName FROM Users WHERE UserName = ?", conn)
        namechk.Parameters.AddWithValue("?", TextBox1.Text)
        Dim reader1 = namechk.ExecuteReader
        If reader1.HasRows Then
            message = "This username is already taken"
        End If
        reader1.Close()

        'checls if email already exist
        Dim emailchk As New OleDbCommand("SELECT Email FROM Users WHERE Email = ?", conn)
        emailchk.Parameters.AddWithValue("?", TextBox2.Text)
        Dim reader2 = emailchk.ExecuteReader
        If reader2.HasRows Then
            message = "This Email already exist"
        End If
        reader2.Close()

        'checks if password already exist
        Dim passchk As New OleDbCommand("SELECT [Password] FROM Users WHERE [Password] = ?", conn)
        passchk.Parameters.AddWithValue("?", TextBox3.Text)
        Dim reader3 = passchk.ExecuteReader
        If reader3.HasRows Then
            message = "This Password is already taken"
        End If
        reader3.Close()

        If message <> "" Then
            MsgBox(message)
        Else
            'register user
            Dim registercmd As New OleDbCommand("INSERT INTO Users (UserName, Email, [Password], DateOfBirth) VALUES (?,?,?,?)", conn)
            registercmd.Parameters.Add("UserName", OleDbType.VarChar).Value = TextBox1.Text
            registercmd.Parameters.Add("Email", OleDbType.VarChar).Value = TextBox2.Text
            registercmd.Parameters.Add("Password", OleDbType.VarChar).Value = TextBox3.Text
            registercmd.Parameters.Add("DateOfBirth", OleDbType.Date).Value = DateTimePicker1.Value.Date
            registercmd.ExecuteNonQuery()

            MsgBox("Registration Successful!")

            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            DateTimePicker1.Value = Date.Now

            Hide()
            Form1.Show()
        End If

        conn.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox3.PasswordChar = ControlChars.NullChar
        Else
            TextBox3.PasswordChar = "*"c
        End If
    End Sub
End Class