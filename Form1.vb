Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim dbPath As String = Application.StartupPath & "\OMC_UserDatabase.accdb"
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbPath)


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        conn.Open()

        'checks if the email is filled up
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Please fill in your username.")
            conn.Close()
            Exit Sub
        End If

        'search and check if the email and database is in the database
        Dim srch As New OleDbCommand("SELECT * FROM Users WHERE [UserName] = ? AND [Password] = ?", conn)
        srch.Parameters.AddWithValue("?", TextBox1.Text)
        srch.Parameters.AddWithValue("?", TextBox2.Text)
        Dim reader As OleDbDataReader = srch.ExecuteReader()

        If reader.HasRows Then

            loggedInName = TextBox1.Text
            Form4.Show()
            Me.Hide()
        Else
            MsgBox("Incorrect username or Password")
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.PasswordChar = ControlChars.NullChar
        Else
            TextBox2.PasswordChar = "*"c
        End If
    End Sub
End Class
