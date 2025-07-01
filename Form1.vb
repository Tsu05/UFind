Public Class Form1
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub picSignUpButton_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Sign_In.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Sign_In.Show()
    End Sub

    Private Sub lblUfind_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        Me.Hide()
        Sign_In.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        SignUp.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
