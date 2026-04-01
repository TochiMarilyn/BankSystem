<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAccount
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
        lblCustomerID = New Label()
        txtCustomerID = New TextBox()
        btnCreateAccount = New Button()
        btnBack = New Button()
        dgvAccounts = New DataGridView()
        lblcreateaccount = New Label()
        cmbCustomer = New ComboBox()
        lblSelectcustomer = New Label()
        CType(dgvAccounts, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblCustomerID
        ' 
        lblCustomerID.AutoSize = True
        lblCustomerID.BackColor = SystemColors.Menu
        lblCustomerID.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCustomerID.Location = New Point(42, 87)
        lblCustomerID.Name = "lblCustomerID"
        lblCustomerID.Size = New Size(108, 21)
        lblCustomerID.TabIndex = 0
        lblCustomerID.Text = "Customer ID:"
        ' 
        ' txtCustomerID
        ' 
        txtCustomerID.Location = New Point(264, 87)
        txtCustomerID.Name = "txtCustomerID"
        txtCustomerID.Size = New Size(190, 23)
        txtCustomerID.TabIndex = 1
        ' 
        ' btnCreateAccount
        ' 
        btnCreateAccount.BackColor = SystemColors.GradientActiveCaption
        btnCreateAccount.Location = New Point(24, 282)
        btnCreateAccount.Name = "btnCreateAccount"
        btnCreateAccount.Size = New Size(159, 45)
        btnCreateAccount.TabIndex = 2
        btnCreateAccount.Text = "Create Account"
        btnCreateAccount.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = SystemColors.GradientActiveCaption
        btnBack.Location = New Point(296, 282)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(126, 45)
        btnBack.TabIndex = 3
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' dgvAccounts
        ' 
        dgvAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAccounts.Location = New Point(546, 158)
        dgvAccounts.Name = "dgvAccounts"
        dgvAccounts.Size = New Size(545, 204)
        dgvAccounts.TabIndex = 4
        ' 
        ' lblcreateaccount
        ' 
        lblcreateaccount.AutoSize = True
        lblcreateaccount.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblcreateaccount.Location = New Point(296, 14)
        lblcreateaccount.Name = "lblcreateaccount"
        lblcreateaccount.Size = New Size(194, 30)
        lblcreateaccount.TabIndex = 5
        lblcreateaccount.Text = "CREATE ACCOUNT"
        ' 
        ' cmbCustomer
        ' 
        cmbCustomer.FormattingEnabled = True
        cmbCustomer.Location = New Point(264, 184)
        cmbCustomer.Name = "cmbCustomer"
        cmbCustomer.Size = New Size(190, 23)
        cmbCustomer.TabIndex = 6
        ' 
        ' lblSelectcustomer
        ' 
        lblSelectcustomer.AutoSize = True
        lblSelectcustomer.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSelectcustomer.Location = New Point(42, 186)
        lblSelectcustomer.Name = "lblSelectcustomer"
        lblSelectcustomer.Size = New Size(138, 21)
        lblSelectcustomer.TabIndex = 7
        lblSelectcustomer.Text = "Select Customer:"
        ' 
        ' FormAccount
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1103, 450)
        Controls.Add(lblSelectcustomer)
        Controls.Add(cmbCustomer)
        Controls.Add(lblcreateaccount)
        Controls.Add(dgvAccounts)
        Controls.Add(btnBack)
        Controls.Add(btnCreateAccount)
        Controls.Add(txtCustomerID)
        Controls.Add(lblCustomerID)
        Name = "FormAccount"
        Text = "FormAccount"
        CType(dgvAccounts, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCustomerID As Label
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents dgvAccounts As DataGridView
    Friend WithEvents lblcreateaccount As Label
    Friend WithEvents cmbCustomer As ComboBox
    Friend WithEvents lblSelectcustomer As Label
End Class
