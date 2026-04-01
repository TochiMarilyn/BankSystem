<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lblTitle = New Label()
        btnCustomer = New Button()
        btnAccount = New Button()
        btnTransaction = New Button()
        btnExit = New Button()
        panelSidebar = New Panel()
        Label1 = New Label()
        btnAdmin = New Button()
        panelSidebar.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(223, 27)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(317, 30)
        lblTitle.TabIndex = 0
        lblTitle.Text = "BANK MANAGEMENT SYSTEM"
        ' 
        ' btnCustomer
        ' 
        btnCustomer.BackColor = SystemColors.ControlText
        btnCustomer.FlatAppearance.BorderSize = 0
        btnCustomer.FlatStyle = FlatStyle.Flat
        btnCustomer.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCustomer.ForeColor = SystemColors.Control
        btnCustomer.Location = New Point(12, 53)
        btnCustomer.Name = "btnCustomer"
        btnCustomer.Size = New Size(175, 50)
        btnCustomer.TabIndex = 1
        btnCustomer.Text = "Customer Management"
        btnCustomer.UseVisualStyleBackColor = False
        ' 
        ' btnAccount
        ' 
        btnAccount.BackColor = SystemColors.ControlText
        btnAccount.FlatStyle = FlatStyle.Flat
        btnAccount.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAccount.ForeColor = SystemColors.Control
        btnAccount.Location = New Point(9, 162)
        btnAccount.Name = "btnAccount"
        btnAccount.Size = New Size(178, 50)
        btnAccount.TabIndex = 2
        btnAccount.Text = "Account Management"
        btnAccount.UseVisualStyleBackColor = False
        ' 
        ' btnTransaction
        ' 
        btnTransaction.BackColor = SystemColors.ControlText
        btnTransaction.FlatStyle = FlatStyle.Flat
        btnTransaction.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnTransaction.ForeColor = SystemColors.Control
        btnTransaction.Location = New Point(9, 282)
        btnTransaction.Name = "btnTransaction"
        btnTransaction.Size = New Size(175, 50)
        btnTransaction.TabIndex = 3
        btnTransaction.Text = "Transactions"
        btnTransaction.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = SystemColors.ControlText
        btnExit.ForeColor = SystemColors.Control
        btnExit.Location = New Point(12, 484)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(157, 30)
        btnExit.TabIndex = 4
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' panelSidebar
        ' 
        panelSidebar.Controls.Add(btnAdmin)
        panelSidebar.Controls.Add(Label1)
        panelSidebar.Controls.Add(btnExit)
        panelSidebar.Controls.Add(btnCustomer)
        panelSidebar.Controls.Add(btnTransaction)
        panelSidebar.Controls.Add(btnAccount)
        panelSidebar.Dock = DockStyle.Left
        panelSidebar.Location = New Point(0, 0)
        panelSidebar.Name = "panelSidebar"
        panelSidebar.Size = New Size(194, 557)
        panelSidebar.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(32, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 25)
        Label1.TabIndex = 0
        Label1.Text = "BANK SYSTEM"
        ' 
        ' btnAdmin
        ' 
        btnAdmin.BackColor = SystemColors.ControlText
        btnAdmin.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAdmin.ForeColor = SystemColors.Control
        btnAdmin.Location = New Point(3, 396)
        btnAdmin.Name = "btnAdmin"
        btnAdmin.Size = New Size(181, 44)
        btnAdmin.TabIndex = 6
        btnAdmin.Text = "Admin"
        btnAdmin.UseVisualStyleBackColor = False
        ' 
        ' FormDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(800, 557)
        Controls.Add(panelSidebar)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "FormDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Bank Management System"
        panelSidebar.ResumeLayout(False)
        panelSidebar.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnCustomer As Button
    Friend WithEvents btnAccount As Button
    Friend WithEvents btnTransaction As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents panelSidebar As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdmin As Button

End Class
