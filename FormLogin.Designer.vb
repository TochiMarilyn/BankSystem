<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        lblLogin = New Label()
        txtUsername = New TextBox()
        lblUsername = New Label()
        txtPassword = New TextBox()
        lblPassword = New Label()
        btnLogin = New Button()
        SuspendLayout()
        ' 
        ' lblLogin
        ' 
        lblLogin.AutoSize = True
        lblLogin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLogin.Location = New Point(319, 33)
        lblLogin.Name = "lblLogin"
        lblLogin.Size = New Size(119, 21)
        lblLogin.TabIndex = 0
        lblLogin.Text = "ADMIN LOGIN"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(258, 99)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(250, 23)
        txtUsername.TabIndex = 1
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsername.Location = New Point(32, 107)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(72, 17)
        lblUsername.TabIndex = 2
        lblUsername.Text = "Username:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(258, 175)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(250, 23)
        txtPassword.TabIndex = 3
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassword.Location = New Point(32, 183)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(69, 17)
        lblPassword.TabIndex = 4
        lblPassword.Text = "Password:"
        ' 
        ' btnLogin
        ' 
        btnLogin.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.Location = New Point(311, 248)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(140, 41)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnLogin)
        Controls.Add(lblPassword)
        Controls.Add(txtPassword)
        Controls.Add(lblUsername)
        Controls.Add(txtUsername)
        Controls.Add(lblLogin)
        Name = "FormLogin"
        Text = "FormLogin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblLogin As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnLogin As Button
End Class
