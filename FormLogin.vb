Imports Microsoft.Data.SqlClient

Public Class FormLogin
    Dim con As New SqlConnection("Server=MARILYN\SQLEXPRESS;Database=BankDB;Trusted_Connection=True;TrustServerCertificate=True;")


    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click


        con.Open()

        Dim cmd As New SqlCommand("SELECT COUNT(*) FROM Admins WHERE Username=@u AND Password=@p", con)
        cmd.Parameters.AddWithValue("@u", txtUsername.Text)
        cmd.Parameters.AddWithValue("@p", txtPassword.Text)

        Dim count As Integer = cmd.ExecuteScalar()
        con.Close()

        If count = 1 Then
            MessageBox.Show("Login Successful")

            Dim f As New FormDashboard()
            f.Show()

            Me.Hide()
        Else
            MessageBox.Show("Invalid Username or Password")
        End If
    End Sub

End Class