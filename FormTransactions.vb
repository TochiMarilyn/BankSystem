Imports Microsoft.Data.SqlClient


Public Class FormTransactions
    ' Add WithEvents to the button declarations if not already present



    Dim con As New SqlConnection("Server=MARILYN\SQLEXPRESS;Database=BankDB;Trusted_Connection=True;TrustServerCertificate=True;")

    Private Sub LoadTransactions()

        Dim da As New SqlDataAdapter("
    SELECT 
        t.TransactionID,
        t.AccountID,
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

        dgvTransactions.DataSource = dt

    End Sub

    Private Sub LoadAccounts()
        Dim cmd As New SqlCommand("SELECT AccountID FROM Accounts", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        cmbAccount.DataSource = dt
        cmbAccount.DisplayMember = "AccountID"
        cmbAccount.ValueMember = "AccountID"
    End Sub
    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click

        con.Open()

        ' Update balance
        Dim cmd As New SqlCommand("UPDATE Accounts SET Balance = Balance + @amt WHERE AccountID=@id", con)
        cmd.Parameters.AddWithValue("@amt", txtAmount.Text)
        cmd.Parameters.AddWithValue("@id", txtAccountID.Text)
        cmd.ExecuteNonQuery()

        ' Record transaction
        Dim cmd2 As New SqlCommand("INSERT INTO Transactions (AccountID, Amount, TransactionType) VALUES (@id, @amt, 'Deposit')", con)
        cmd2.Parameters.AddWithValue("@amt", txtAmount.Text)
        cmd2.Parameters.AddWithValue("@id", txtAccountID.Text)
        cmd2.ExecuteNonQuery()

        con.Close()
        MessageBox.Show("Deposit Successful")
    End Sub


    Private Sub btnCheckBalance_Click(sender As Object, e As EventArgs) Handles btnCheckBalance.Click
        con.Open()
        Dim cmd As New SqlCommand("SELECT Balance FROM Accounts WHERE AccountID=@id", con)
        cmd.Parameters.AddWithValue("@id", txtAccountID.Text)
        Dim result = cmd.ExecuteScalar()
        con.Close()

        MessageBox.Show("Balance: " & result.ToString())

        LoadTransactions()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()

    End Sub

    Private Sub FormTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAccounts()
        LoadTransactions()
    End Sub

    Private Sub btnWithdraw_Click_1(sender As Object, e As EventArgs) Handles btnWithdraw.Click

        Try
            con.Open()

            ' Validate input
            If txtAccountID.Text = "" Or txtAmount.Text = "" Then
                MessageBox.Show("Enter Account ID and Amount")
                con.Close()
                Exit Sub
            End If

            Dim amount As Decimal = Convert.ToDecimal(txtAmount.Text)

            ' Check balance
            Dim cmdCheck As New SqlCommand("SELECT Balance FROM Accounts WHERE AccountID=@id", con)
            cmdCheck.Parameters.AddWithValue("@id", txtAccountID.Text)

            Dim result = cmdCheck.ExecuteScalar()

            If result Is Nothing Then
                MessageBox.Show("Account not found")
                con.Close()
                Exit Sub
            End If

            Dim balance As Decimal = Convert.ToDecimal(result)

            ' Prevent overdraft
            If amount > balance Then
                MessageBox.Show("Insufficient Balance")
                con.Close()
                Exit Sub
            End If

            ' Deduct balance
            Dim cmdUpdate As New SqlCommand("UPDATE Accounts SET Balance = Balance - @amt WHERE AccountID=@id", con)
            cmdUpdate.Parameters.AddWithValue("@amt", amount)
            cmdUpdate.Parameters.AddWithValue("@id", txtAccountID.Text)
            cmdUpdate.ExecuteNonQuery()

            ' Record transaction
            Dim cmdInsert As New SqlCommand("INSERT INTO Transactions (AccountID, Amount, TransactionType) VALUES (@id, @amt, 'Withdraw')", con)
            cmdInsert.Parameters.AddWithValue("@amt", amount)
            cmdInsert.Parameters.AddWithValue("@id", txtAccountID.Text)
            cmdInsert.ExecuteNonQuery()

            con.Close()

            MessageBox.Show("Withdrawal Successful")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
        LoadTransactions()
    End Sub

End Class