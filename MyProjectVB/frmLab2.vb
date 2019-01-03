Public Class frmLab2
    Private Sub frmLab2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        Dim Viatra, Computer, Total, CommVis, CommCom, Commtotal
        Viatra = txtVistra.Text
        Computer = txtComputer.Text

        Total = Viatra + Computer

        CommVis = Val(Viatra * 5) / 100
        CommCom = Val(Computer * 10) / 100
        Commtotal = CommVis + CommCom

        lblTotal.Text = Total
        lblCommVis.Text = CommVis
        lblCommCom.Text = CommCom
        lblCommtotal.Text = Commtotal


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class