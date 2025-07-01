<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewPassword
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
        Me.lblCreateNewPass = New System.Windows.Forms.Label()
        Me.lblForgotCaption = New System.Windows.Forms.Label()
        Me.lblNewPass = New System.Windows.Forms.Label()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.lblConfirmNewPass = New System.Windows.Forms.Label()
        Me.txtEmailForgot = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnResetPass = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCreateNewPass
        '
        Me.lblCreateNewPass.AutoSize = True
        Me.lblCreateNewPass.BackColor = System.Drawing.Color.Transparent
        Me.lblCreateNewPass.Font = New System.Drawing.Font("Poppins", 14.8!, System.Drawing.FontStyle.Bold)
        Me.lblCreateNewPass.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblCreateNewPass.Location = New System.Drawing.Point(54, 131)
        Me.lblCreateNewPass.Name = "lblCreateNewPass"
        Me.lblCreateNewPass.Size = New System.Drawing.Size(299, 44)
        Me.lblCreateNewPass.TabIndex = 3
        Me.lblCreateNewPass.Text = "Create New Password"
        '
        'lblForgotCaption
        '
        Me.lblForgotCaption.AutoSize = True
        Me.lblForgotCaption.BackColor = System.Drawing.Color.Transparent
        Me.lblForgotCaption.Font = New System.Drawing.Font("Poppins", 7.0!)
        Me.lblForgotCaption.ForeColor = System.Drawing.Color.DimGray
        Me.lblForgotCaption.Location = New System.Drawing.Point(45, 175)
        Me.lblForgotCaption.Name = "lblForgotCaption"
        Me.lblForgotCaption.Size = New System.Drawing.Size(316, 44)
        Me.lblForgotCaption.TabIndex = 4
        Me.lblForgotCaption.Text = "The password should be different from the previous " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "password"
        '
        'lblNewPass
        '
        Me.lblNewPass.AutoSize = True
        Me.lblNewPass.BackColor = System.Drawing.Color.Transparent
        Me.lblNewPass.Font = New System.Drawing.Font("Poppins", 7.0!)
        Me.lblNewPass.ForeColor = System.Drawing.Color.Gray
        Me.lblNewPass.Location = New System.Drawing.Point(45, 244)
        Me.lblNewPass.Name = "lblNewPass"
        Me.lblNewPass.Size = New System.Drawing.Size(95, 22)
        Me.lblNewPass.TabIndex = 8
        Me.lblNewPass.Text = "New Password"
        '
        'txtNewPass
        '
        Me.txtNewPass.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNewPass.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPass.Location = New System.Drawing.Point(49, 269)
        Me.txtNewPass.Multiline = True
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.Size = New System.Drawing.Size(299, 34)
        Me.txtNewPass.TabIndex = 9
        '
        'lblConfirmNewPass
        '
        Me.lblConfirmNewPass.AutoSize = True
        Me.lblConfirmNewPass.BackColor = System.Drawing.Color.Transparent
        Me.lblConfirmNewPass.Font = New System.Drawing.Font("Poppins", 7.0!)
        Me.lblConfirmNewPass.ForeColor = System.Drawing.Color.Gray
        Me.lblConfirmNewPass.Location = New System.Drawing.Point(45, 323)
        Me.lblConfirmNewPass.Name = "lblConfirmNewPass"
        Me.lblConfirmNewPass.Size = New System.Drawing.Size(146, 22)
        Me.lblConfirmNewPass.TabIndex = 10
        Me.lblConfirmNewPass.Text = "Confirm New Password"
        '
        'txtEmailForgot
        '
        Me.txtEmailForgot.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtEmailForgot.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmailForgot.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailForgot.Location = New System.Drawing.Point(49, 348)
        Me.txtEmailForgot.Multiline = True
        Me.txtEmailForgot.Name = "txtEmailForgot"
        Me.txtEmailForgot.Size = New System.Drawing.Size(299, 34)
        Me.txtEmailForgot.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins", 7.0!)
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(45, 399)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 22)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "☑ At least 8 characters"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Poppins", 7.0!)
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(45, 421)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 22)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "☑ At least 1 number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Poppins", 7.0!)
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(45, 443)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(227, 22)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "☑ Both upper and lower case letters"
        '
        'btnResetPass
        '
        Me.btnResetPass.BackColor = System.Drawing.Color.Transparent
        Me.btnResetPass.BackgroundImage = Global.OMC_UFind.My.Resources.Resources.Blue_Yellow_Minimalist_Happy_Graduation_Canvas_Button__1_
        Me.btnResetPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnResetPass.FlatAppearance.BorderSize = 0
        Me.btnResetPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetPass.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetPass.ForeColor = System.Drawing.Color.White
        Me.btnResetPass.Location = New System.Drawing.Point(87, 468)
        Me.btnResetPass.Name = "btnResetPass"
        Me.btnResetPass.Size = New System.Drawing.Size(233, 36)
        Me.btnResetPass.TabIndex = 15
        Me.btnResetPass.Text = "Reset Password"
        Me.btnResetPass.UseVisualStyleBackColor = False
        '
        'NewPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OMC_UFind.My.Resources.Resources.forgotPassBg2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(407, 651)
        Me.Controls.Add(Me.btnResetPass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblConfirmNewPass)
        Me.Controls.Add(Me.txtEmailForgot)
        Me.Controls.Add(Me.lblNewPass)
        Me.Controls.Add(Me.txtNewPass)
        Me.Controls.Add(Me.lblForgotCaption)
        Me.Controls.Add(Me.lblCreateNewPass)
        Me.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "NewPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewPassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCreateNewPass As Label
    Friend WithEvents lblForgotCaption As Label
    Friend WithEvents lblNewPass As Label
    Friend WithEvents txtNewPass As TextBox
    Friend WithEvents lblConfirmNewPass As Label
    Friend WithEvents txtEmailForgot As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnResetPass As Button
End Class
