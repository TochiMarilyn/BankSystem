<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCustomer
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
        txtName = New TextBox()
        txtPhone = New TextBox()
        btnAddCustomer = New Button()
        lblFullName = New Label()
        lblPhone = New Label()
        dgvCustomers = New DataGridView()
        btnBack = New Button()
        lblCustomerRegistration = New Label()
        CType(dgvCustomers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(190, 83)
        txtName.Name = "txtName"
        txtName.Size = New Size(245, 23)
        txtName.TabIndex = 0
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(190, 172)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(245, 23)
        txtPhone.TabIndex = 1
        ' 
        ' btnAddCustomer
        ' 
        btnAddCustomer.BackColor = SystemColors.GradientActiveCaption
        btnAddCustomer.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddCustomer.Location = New Point(37, 299)
        btnAddCustomer.Name = "btnAddCustomer"
        btnAddCustomer.Size = New Size(128, 38)
        btnAddCustomer.TabIndex = 2
        btnAddCustomer.Text = "Add Customer"
        btnAddCustomer.UseVisualStyleBackColor = False
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFullName.Location = New Point(37, 82)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(84, 20)
        lblFullName.TabIndex = 3
        lblFullName.Text = "Full Name:"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPhone.Location = New Point(37, 171)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(57, 20)
        lblPhone.TabIndex = 4
        lblPhone.Text = "Phone:"
        ' 
        ' dgvCustomers
        ' 
        dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCustomers.Location = New Point(519, 111)
        dgvCustomers.Name = "dgvCustomers"
        dgvCustomers.Size = New Size(619, 244)
        dgvCustomers.TabIndex = 5
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = SystemColors.GradientActiveCaption
        btnBack.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.Location = New Point(316, 302)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 35)
        btnBack.TabIndex = 6
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' lblCustomerRegistration
        ' 
        lblCustomerRegistration.AutoSize = True
        lblCustomerRegistration.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCustomerRegistration.Location = New Point(210, 9)
        lblCustomerRegistration.Name = "lblCustomerRegistration"
        lblCustomerRegistration.Size = New Size(289, 30)
        lblCustomerRegistration.TabIndex = 7
        lblCustomerRegistration.Tag = ""
        lblCustomerRegistration.Text = "Customer Registration Form"
        ' 
        ' FormCustomer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1150, 450)
        Controls.Add(lblCustomerRegistration)
        Controls.Add(btnBack)
        Controls.Add(dgvCustomers)
        Controls.Add(lblPhone)
        Controls.Add(lblFullName)
        Controls.Add(btnAddCustomer)
        Controls.Add(txtPhone)
        Controls.Add(txtName)
        Name = "FormCustomer"
        Text = "FormCustomer"
        CType(dgvCustomers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents btnAddCustomer As Button
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents lblCustomerRegistration As Label
End Class
