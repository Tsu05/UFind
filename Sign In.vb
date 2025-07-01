Public Class Sign_In

    Dim imageList As New List(Of Image)
    Dim currentIndex As Integer = 0
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblforgotpass.Click
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblSIgnUp.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSign1.Click
        Me.Hide()
    End Sub

    Private Sub Sign_In_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load images into list
        imageList.Add(Image.FromFile("clothes.png"))
        imageList.Add(Image.FromFile("electronics.png"))

        ' start with first image
        picSlider.Image = imageList(currentIndex)

        'Start timer
        sliderTimer.Start()
    End Sub

    Private Sub sliderTimer_Tick(sender As Object, e As EventArgs) Handles sliderTimer.Tick
        currentIndex += 1
        If currentIndex >= imageList.Count Then currentIndex = 0
        picSlider.Image = imageList(currentIndex)
    End Sub

    Private Sub picSlider_Click(sender As Object, e As EventArgs) Handles picSlider.Click

    End Sub
End Class