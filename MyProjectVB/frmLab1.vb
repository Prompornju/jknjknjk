Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, lbltax.Click, lblSalaryperyer.Click, lblNetsalary.Click, Label5.Click, Label4.Click, Label3.Click

    End Sub

    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        Dim salary, salaryperyear, tax As Double
        salary = txtSalary.Text
        salaryperyear = Val(salary * 12)

        salaryperyear = Val(salary * 5) / 100

        tax = Val(salary) - (salaryperyear)

        lblSalaryperyer.Text = salary
        lbltax.Text = salaryperyear
        lblNetsalary.Text = tax

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtSalary_TextChanged(sender As Object, e As EventArgs) Handles txtSalary.TextChanged

    End Sub
End Class
