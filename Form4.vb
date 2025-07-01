Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Make the profile picture round
        Dim gp As New Drawing2D.GraphicsPath()
        gp.AddEllipse(0, 0, PictureBox1.Width, PictureBox1.Height)
        PictureBox1.Region = New Region(gp)

        Label1.Text = loggedInName
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class