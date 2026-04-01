<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmin
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
        btnCustomers = New Button()
        btnAccounts = New Button()
        btnTransactions = New Button()
        dgvAdmin = New DataGridView()
        btnDelete = New Button()
        lblAdminForm = New Label()
        btnLogout = New Button()
        CType(dgvAdmin, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnCustomers
        ' 
        btnCustomers.BackColor = SystemColors.ActiveCaption
        btnCustomers.Location = New Point(12, 63)
        btnCustomers.Name = "btnCustomers"
        btnCustomers.Size = New Size(138, 34)
        btnCustomers.TabIndex = 0
        btnCustomers.Text = "View Customers"
        btnCustomers.UseVisualStyleBackColor = False
        ' 
        ' btnAccounts
        ' 
        btnAccounts.BackColor = SystemColors.ActiveCaption
        btnAccounts.Location = New Point(12, 158)
        btnAccounts.Name = "btnAccounts"
        btnAccounts.Size = New Size(138, 35)
        btnAccounts.TabIndex = 1
        btnAccounts.Text = "View Accounts"
        btnAccounts.UseVisualStyleBackColor = False
        ' 
        ' btnTransactions
        ' 
        btnTransactions.BackColor = SystemColors.ActiveCaption
        btnTransactions.Location = New Point(12, 250)
        btnTransactions.Name = "btnTransactions"
        btnTransactions.Size = New Size(138, 37)
        btnTransactions.TabIndex = 2
        btnTransactions.Text = "View Transactions"
        btnTransactions.UseVisualStyleBackColor = False
        ' 
        ' dgvAdmin
        ' 
        dgvAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAdmin.Location = New Point(434, 114)
        dgvAdmin.Name = "dgvAdmin"
        dgvAdmin.Size = New Size(606, 243)
        dgvAdmin.TabIndex = 3
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = SystemColors.ActiveCaption
        btnDelete.Location = New Point(12, 336)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(138, 35)
        btnDelete.TabIndex = 4
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' lblAdminForm
        ' 
        lblAdminForm.AutoSize = True
        lblAdminForm.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAdminForm.Location = New Point(297, 21)
        lblAdminForm.Name = "lblAdminForm"
        lblAdminForm.Size = New Size(137, 25)
        lblAdminForm.TabIndex = 5
        lblAdminForm.Text = "ADMIN FORM"
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = SystemColors.ActiveCaption
        btnLogout.Location = New Point(23, 410)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(107, 37)
        btnLogout.TabIndex = 6
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' FormAdmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1147, 450)
        Controls.Add(btnLogout)
        Controls.Add(lblAdminForm)
        Controls.Add(btnDelete)
        Controls.Add(dgvAdmin)
        Controls.Add(btnTransactions)
        Controls.Add(btnAccounts)
        Controls.Add(btnCustomers)
        Name = "FormAdmin"
        Text = "FormAdmin"
        CType(dgvAdmin, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCustomers As Button
    Friend WithEvents btnAccounts As Button
    Friend WithEvents btnTransactions As Button
    Friend WithEvents dgvAdmin As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblAdminForm As Label
    Friend WithEvents btnLogout As Button
End Class
