Public Class frmLab6
    Dim car As Double
    Dim net, f1, f2, f3, s1, s2, s3 As Double
    Dim Mes As DialogResult

    Private Sub chkItemsAdd1_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAdd1.CheckedChanged
        If chkItemsAdd1.Checked = True Then
            net = net + Val(lblItemsPricel1.Text)
        Else
            net = net - Val(lblItemsPricel1.Text)
        End If
        lblPaidPrice.Text = net
    End Sub

    Private Sub chkItemsAdd2_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAdd2.CheckedChanged
        If chkItemsAdd2.Checked = True Then
            net = net + Val(lblItemsPricel2.Text)
        Else
            net = net - Val(lblItemsPricel2.Text)
        End If
        lblPaidPrice.Text = net
    End Sub

    Private Sub chkItemsAdd3_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAdd3.CheckedChanged
        If chkItemsAdd3.Checked = True Then
            net = net + Val(lblItemsPricel3.Text)
        Else
            net = net - Val(lblItemsPricel3.Text)
        End If
        lblPaidPrice.Text = net
    End Sub

    Private Sub chkItemsAdd4_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAdd4.CheckedChanged
        If chkItemsAdd4.Checked = True Then
            net = net + Val(lblItemsPricel4.Text)
        Else
            net = net - Val(lblItemsPricel4.Text)
        End If
        lblPaidPrice.Text = net
    End Sub

    Private Sub chkCarForMe_Click(sender As Object, e As EventArgs) Handles chkCarForMe.Click
        If chkCarForMe.Checked = True Then
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            f1 = Val(lblFreel1.Text)
            f2 = Val(lblFreel2.Text)
            f3 = Val(lblFreel3.Text)
            car = Val(lblSartPrice.Text)
            net = (car + f1) + f2 + f3

            lblPaidPrice.Text = net

        Else
            If MessageBox.Show("ต้องการยกเลิกซื้อรถใช่หรือไม่", "เเจ้งเตือน !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                chkCarForMe.Checked = False
                GroupBox1.Enabled = False
                GroupBox2.Enabled = False
                chkItemsAdd1.Checked = False
                chkItemsAdd2.Checked = False
                chkItemsAdd3.Checked = False
                chkItemsAdd4.Checked = False
                chkFreel1.Checked = False
                chkFreel2.Checked = False
                chkFreel3.Checked = False
                lblPaidPrice.Text = 0

            Else
                chkCarForMe.Checked = True

            End If
        End If
    End Sub

    Private Sub chkFreel3_CheckedChanged(sender As Object, e As EventArgs) Handles chkFreel3.CheckedChanged
        If chkFreel3.Checked = True Then
            net = net - Val(lblFreel3.Text)

        Else
            net = net + Val(lblFreel3.Text)

        End If
        lblPaidPrice.Text = net
    End Sub

    Private Sub chkFreel2_CheckedChanged(sender As Object, e As EventArgs) Handles chkFreel2.CheckedChanged
        If chkFreel2.Checked = True Then
            net = net - Val(lblFreel2.Text)

        Else
            net = net + Val(lblFreel2.Text)

        End If
        lblPaidPrice.Text = net
    End Sub

    Private Sub chkFreel1_CheckedChanged(sender As Object, e As EventArgs) Handles chkFreel1.CheckedChanged
        If chkFreel1.Checked = True Then
            net = net - Val(lblFreel1.Text)

        Else
            net = net + Val(lblFreel1.Text)

        End If
        lblPaidPrice.Text = net
    End Sub

    Private Sub frmLab6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles lblFreel3.Click, lblPaidPrice.Click

    End Sub

    Private Sub chkCarForMe_CheckedChanged(sender As Object, e As EventArgs) Handles chkCarForMe.CheckedChanged

    End Sub
End Class