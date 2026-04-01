<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransactions
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
        txtAccountID = New TextBox()
        txtAmount = New TextBox()
        btnDeposit = New Button()
        btnWithdraw = New Button()
        btnCheckBalance = New Button()
        lblAccountID = New Label()
        lblAmount = New Label()
        btnBack = New Button()
        cmbAccount = New ComboBox()
        dgvTransactions = New DataGridView()
        CType(dgvTransactions, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtAccountID
        ' 
        txtAccountID.Location = New Point(214, 61)
        txtAccountID.Name = "txtAccountID"
        txtAccountID.Size = New Size(134, 23)
        txtAccountID.TabIndex = 0
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(587, 61)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(130, 23)
        txtAmount.TabIndex = 1
        ' 
        ' btnDeposit
        ' 
        btnDeposit.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDeposit.Location = New Point(12, 293)
        btnDeposit.Name = "btnDeposit"
        btnDeposit.Size = New Size(128, 29)
        btnDeposit.TabIndex = 2
        btnDeposit.Text = "Deposit"
        btnDeposit.UseVisualStyleBackColor = True
        ' 
        ' btnWithdraw
        ' 
        btnWithdraw.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnWithdraw.Location = New Point(12, 375)
        btnWithdraw.Name = "btnWithdraw"
        btnWithdraw.Size = New Size(125, 36)
        btnWithdraw.TabIndex = 3
        btnWithdraw.Text = "Withdraw"
        btnWithdraw.UseVisualStyleBackColor = True
        ' 
        ' btnCheckBalance
        ' 
        btnCheckBalance.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCheckBalance.Location = New Point(12, 470)
        btnCheckBalance.Name = "btnCheckBalance"
        btnCheckBalance.Size = New Size(128, 36)
        btnCheckBalance.TabIndex = 4
        btnCheckBalance.Text = "Check Balance"
        btnCheckBalance.UseVisualStyleBackColor = True
        ' 
        ' lblAccountID
        ' 
        lblAccountID.AutoSize = True
        lblAccountID.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAccountID.Location = New Point(63, 64)
        lblAccountID.Name = "lblAccountID"
        lblAccountID.Size = New Size(76, 17)
        lblAccountID.TabIndex = 5
        lblAccountID.Text = "AccountID:"
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAmount.Location = New Point(484, 64)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(62, 17)
        lblAmount.TabIndex = 6
        lblAmount.Text = "Amount:"
        ' 
        ' btnBack
        ' 
        btnBack.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.Location = New Point(283, 470)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(96, 31)
        btnBack.TabIndex = 8
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' cmbAccount
        ' 
        cmbAccount.FormattingEnabled = True
        cmbAccount.Location = New Point(214, 129)
        cmbAccount.Name = "cmbAccount"
        cmbAccount.Size = New Size(134, 23)
        cmbAccount.TabIndex = 9
        ' 
        ' dgvTransactions
        ' 
        dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTransactions.Location = New Point(365, 174)
        dgvTransactions.Name = "dgvTransactions"
        dgvTransactions.Size = New Size(694, 210)
        dgvTransactions.TabIndex = 10
        ' 
        ' FormTransactions
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GrayText
        ClientSize = New Size(1134, 533)
        Controls.Add(dgvTransactions)
        Controls.Add(cmbAccount)
        Controls.Add(btnBack)
        Controls.Add(lblAmount)
        Controls.Add(lblAccountID)
        Controls.Add(btnCheckBalance)
        Controls.Add(btnWithdraw)
        Controls.Add(btnDeposit)
        Controls.Add(txtAmount)
        Controls.Add(txtAccountID)
        Name = "FormTransactions"
        Text = "FormDeposit"
        CType(dgvTransactions, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtAccountID As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnDeposit As Button
    Friend WithEvents btnWithdraw As Button
    Friend WithEvents btnCheckBalance As Button
    Friend WithEvents lblAccountID As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents cmbAccount As ComboBox
    Friend WithEvents dgvTransactions As DataGridView
End Class
