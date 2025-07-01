<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewPass
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblForgot = New System.Windows.Forms.Label()
        Me.lblForgotCaption = New System.Windows.Forms.Label()
        Me.txtEmailForgot = New System.Windows.Forms.TextBox()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.btnSendCOde = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblForgot
        '
        Me.lblForgot.AutoSize = True
        Me.lblForgot.BackColor = System.Drawing.Color.Transparent
        Me.lblForgot.Font = New System.Drawing.Font("Poppins", 14.8!, System.Drawing.FontStyle.Bold)
        Me.lblForgot.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblForgot.Location = New System.Drawing.Point(67, 201)
        Me.lblForgot.Name = "lblForgot"
        Me.lblForgot.Size = New System.Drawing.Size(253, 44)
        Me.lblForgot.TabIndex = 2
        Me.lblForgot.Text = "Forgot Password ?"
        '
        'lblForgotCaption
        '
        Me.lblForgotCaption.AutoSize = True
        Me.lblForgotCaption.BackColor = System.Drawing.Color.Transparent
        Me.lblForgotCaption.Font = New System.Drawing.Font("Poppins", 7.0!)
        Me.lblForgotCaption.ForeColor = System.Drawing.Color.DimGray
        Me.lblForgotCaption.Location = New System.Drawing.Point(71, 234)
        Me.lblForgotCaption.Name = "lblForgotCaption"
        Me.lblForgotCaption.Size = New System.Drawing.Size(259, 22)
        Me.lblForgotCaption.TabIndex = 3
        Me.lblForgotCaption.Text = "No worries, we'll send you reset instruction."
        '
        'txtEmailForgot
        '
        Me.txtEmailForgot.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtEmailForgot.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmailForgot.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailForgot.Location = New System.Drawing.Point(47, 298)
        Me.txtEmailForgot.Multiline = True
        Me.txtEmailForgot.Name = "txtEmailForgot"
        Me.txtEmailForgot.Size = New System.Drawing.Size(299, 34)
        Me.txtEmailForgot.TabIndex = 7
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.BackColor = System.Drawing.Color.Transparent
        Me.lblemail.Font = New System.Drawing.Font("Poppins", 7.0!)
        Me.lblemail.ForeColor = System.Drawing.Color.Gray
        Me.lblemail.Location = New System.Drawing.Point(43, 273)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(49, 22)
        Me.lblemail.TabIndex = 6
        Me.lblemail.Text = "email :"
        '
        'btnSendCOde
        '
        Me.btnSendCOde.BackColor = System.Drawing.Color.Transparent
        Me.btnSendCOde.BackgroundImage = Global.OMC_UFind.My.Resources.Resources.Blue_Yellow_Minimalist_Happy_Graduation_Canvas_Button__1_
        Me.btnSendCOde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSendCOde.FlatAppearance.BorderSize = 0
        Me.btnSendCOde.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSendCOde.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendCOde.ForeColor = System.Drawing.Color.White
        Me.btnSendCOde.Location = New System.Drawing.Point(75, 368)
        Me.btnSendCOde.Name = "btnSendCOde"
        Me.btnSendCOde.Size = New System.Drawing.Size(233, 36)
        Me.btnSendCOde.TabIndex = 8
        Me.btnSendCOde.Text = "Send Code"
        Me.btnSendCOde.UseVisualStyleBackColor = False
        '
        'NewPass
        '
        Me.BackgroundImage = Global.OMC_UFind.My.Resources.Resources.forgotPassBg3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(407, 651)
        Me.Controls.Add(Me.btnSendCOde)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.txtEmailForgot)
        Me.Controls.Add(Me.lblForgotCaption)
        Me.Controls.Add(Me.lblForgot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NewPass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtEmailForgotPass As TextBox
    Friend WithEvents btnSignIn As Button
    Friend WithEvents lblCode As Label
    Friend WithEvents lblGetUrCode As Label
    Friend WithEvents lblForgot As Label
    Friend WithEvents lblForgotCaption As Label
    Friend WithEvents txtEmailForgot As TextBox
    Friend WithEvents lblemail As Label
    Friend WithEvents btnSendCOde As Button
End Class
