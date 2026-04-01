Imports Microsoft.Data.SqlClient

Public Class FormCustomer
    Dim con As New SqlConnection("Server=MARILYN\SQLEXPRESS;Database=BankDB;Trusted_Connection=True;TrustServerCertificate=True;")

    Private Sub LoadCustomers()
        Dim da As New SqlDataAdapter("SELECT * FROM Customers", con)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvCustomers.DataSource = dt
    End Sub
    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        con.Open()
        Dim cmd As New SqlCommand("INSERT INTO Customers (FullName, Phone) VALUES (@name, @phone)", con)
        cmd.Parameters.AddWithValue("@name", txtName.Text)
        cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Customer Added Successfully")
        LoadCustomers()
    End Sub

    Private Sub FormCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomers()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class