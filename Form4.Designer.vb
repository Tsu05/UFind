<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Panel1 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Screenshot_2025_06_29_001442
        PictureBox1.Location = New Point(321, 58)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(148, 120)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(347, 191)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 25)
        Label1.TabIndex = 1
        Label1.Text = "UserName"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(275, 251)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 25)
        Label2.TabIndex = 2
        Label2.Text = "Personal Info"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(275, 293)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 25)
        Label3.TabIndex = 3
        Label3.Text = "My Order"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(275, 335)
        Label4.Name = "Label4"
        Label4.Size = New Size(152, 25)
        Label4.TabIndex = 4
        Label4.Text = "Change Password"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(465, 248)
        Button1.Name = "Button1"
        Button1.Size = New Size(67, 30)
        Button1.TabIndex = 5
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(465, 288)
        Button2.Name = "Button2"
        Button2.Size = New Size(67, 30)
        Button2.TabIndex = 6
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(465, 330)
        Button3.Name = "Button3"
        Button3.Size = New Size(67, 30)
        Button3.TabIndex = 7
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Location = New Point(204, 386)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(379, 51)
        Panel1.TabIndex = 8
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form4"
        Text = "Form4"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
End Class
