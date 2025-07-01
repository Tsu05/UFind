Imports System.Data.OleDb

Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dbPath As String = Application.StartupPath & "\OMC_UserDatabase.accdb"
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbPath)



        conn.Open()

        'checks if the email is filled up
        If TextBox1.Text = "" Then
            MsgBox("Please fill in your username.")
            conn.Close()
            Exit Sub
        End If

        'search the email in the database
        Dim srch As New OleDbCommand("SELECT [Password] FROM Users WHERE UserName = ?", conn)
        srch.Parameters.AddWithValue("?", TextBox1.Text)
        Dim reader = srch.ExecuteReader


        If reader.HasRows Then
            reader.Read() ' goes to the first row and reads them
            Dim password = reader("Password").ToString 'reads the first row in the password column
            MsgBox("Your password is: " & password)
        Else
            MsgBox("Email not found.")
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class