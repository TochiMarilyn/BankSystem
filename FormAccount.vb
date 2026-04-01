Imports Microsoft.Data.SqlClient


Public Class FormAccount
    Dim con As New SqlConnection("Server=MARILYN\SQLEXPRESS;Database=BankDB;Trusted_Connection=True;TrustServerCertificate=True;")

    Private Sub LoadAccounts()
        Dim da As New SqlDataAdapter("SELECT * FROM Customers", con)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvAccounts.DataSource = dt
    End Sub

    Private Sub LoadCustomers()
        Dim cmd As New SqlCommand("SELECT CustomerID, FullName FROM Customers", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        cmbCustomer.DataSource = dt
        cmbCustomer.DisplayMember = "FullName"
        cmbCustomer.ValueMember = "CustomerID"

    End Sub
    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click

        If cmbCustomer.SelectedIndex = -1 Then
            MessageBox.Show("Please select a customer")
        End If

        Dim CustomerID As Integer = cmbCustomer.SelectedValue
        con.Open()
        Dim cmd As New SqlCommand("INSERT INTO Accounts (CustomerID, Balance) VALUES (@cid, 0)", con)
        cmd.Parameters.AddWithValue("@cid", txtCustomerID.Text)
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Account Created Successfully!")
        LoadAccounts()
    End Sub

    Private Sub FormAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAccounts()
        LoadCustomers()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class