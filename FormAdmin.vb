Imports Microsoft.Data.SqlClient

Public Class FormAdmin
    Dim con As New SqlConnection("Server=MARILYN\SQLEXPRESS;Database=BankDB;Trusted_Connection=True;TrustServerCertificate=True;")

    Private Sub btnAccounts_Click(sender As Object, e As EventArgs) Handles btnAccounts.Click

        Dim da As New SqlDataAdapter("
    SELECT a.AccountID, c.FullName, a.Balance
    FROM Accounts a
    JOIN Customers c ON a.CustomerID = c.CustomerID", con)

        Dim dt As New DataTable()
        da.Fill(dt)
        dgvAdmin.DataSource = dt

    End Sub

    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click

        Dim da As New SqlDataAdapter("SELECT * FROM Customers", con)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvAdmin.DataSource = dt

    End Sub

    Private Sub btnTransactions_Click(sender As Object, e As EventArgs) Handles btnTransactions.Click

        Dim da As New SqlDataAdapter("
    SELECT 
        t.TransactionID,
        c.FullName,
        t.Amount,
        t.TransactionType,
        t.Date
    FROM Transactions t
    JOIN Accounts a ON t.AccountID = a.AccountID
    JOIN Customers c ON a.CustomerID = c.CustomerID
    ORDER BY t.Date DESC", con)

        Dim dt As New DataTable()
        da.Fill(dt)
        dgvAdmin.DataSource = dt

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If dgvAdmin.SelectedRows.Count > 0 Then
            Dim id = dgvAdmin.SelectedRows(0).Cells(0).Value

            con.Open()
            Dim cmd As New SqlCommand("DELETE FROM Customers WHERE CustomerID=@id", con)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Deleted")
        End If

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim f As New FormLogin()
        f.Show()
        Me.Close()
    End Sub
End Class