
Imports Microsoft.Data.SqlClient
Public Class FormDashboard
    Dim con As New SqlConnection("Server=MARILYN\SQLEXPRESS;Database=BankDB;Trusted_Connection=True;TrustServerCertificate=True;")



    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        FormAccount.Show()
        Dim f As New FormAccount()
        f.Show()
    End Sub

    Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        FormTransactions.Show()
        Dim f As New FormTransactions()
        f.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnCustomer_MouseEnter(sender As Object, e As EventArgs) Handles btnCustomer.MouseEnter
        btnCustomer.BackColor = Color.LightBlue
    End Sub

    Private Sub btnCustomer_MouseLeave(sender As Object, e As EventArgs) Handles btnCustomer.MouseLeave
        btnCustomer.BackColor = Color.FromArgb(30, 30, 60)
    End Sub

    Private Sub btnAccount_MouseEnter(sender As Object, e As EventArgs) Handles btnAccount.MouseEnter
        btnAccount.BackColor = Color.LightBlue
    End Sub

    Private Sub btnAccount_MouseLeave(sender As Object, e As EventArgs) Handles btnAccount.MouseLeave
        btnAccount.BackColor = Color.FromArgb(30, 30, 60)
    End Sub

    Private Sub btnTransaction_MouseEnter(sender As Object, e As EventArgs) Handles btnTransaction.MouseEnter
        btnTransaction.BackColor = Color.LightBlue
    End Sub

    Private Sub btnTransaction_MouseLeave(sender As Object, e As EventArgs) Handles btnTransaction.MouseLeave
        btnTransaction.BackColor = Color.FromArgb(30, 30, 60)
    End Sub

    Private Sub btnCustomer_Click_1(sender As Object, e As EventArgs) Handles btnCustomer.Click
        FormCustomer.Show()
        Dim f As New FormCustomer
        f.Show()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Dim f As New FormAdmin()
        f.Show()
    End Sub
End Class
