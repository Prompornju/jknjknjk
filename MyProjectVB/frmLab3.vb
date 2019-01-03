Public Class frmLab3
    Private Sub frmLab3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboSelect.Items.Add(10)
        cboSelect.Items.Add(14)
        cboSelect.Items.Add(18)
        cboSelect.Items.Add(22)
        cboSelect.Items.Add(26)
        cboSelect.Items.Add(30)
        cboSelect.Items.Add(34)
        cboSelect.Items.Add(38)
        cboSelect.Items.Add(42)
        cboSelect.Items.Add(46)
        cboSelect.Items.Add(50)
        cboSelect.Items.Add(54)
        cboSelect.Items.Add(58)
        cboSelect.Items.Add(62)
        cboSelect.Items.Add(66)
        cboSelect.Items.Add(70)
        cboSelect.Items.Add(72)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHigh.Click
        txtDigis.Text = Val(txtDigis.Text) + 2
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblFRed.Click
        txtDigis.ForeColor = Color.Red
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblFBlue.Click
        txtDigis.ForeColor = Color.Blue
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblFGreen.Click
        txtDigis.ForeColor = Color.Green
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lblFViolet.Click
        txtDigis.ForeColor = Color.Violet
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles lblFBlack.Click
        txtDigis.ForeColor = Color.Black
    End Sub

    Private Sub cboSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelect.SelectedIndexChanged
        Dim size As Integer
        Integer.TryParse(cboSelect.Text, size)
        txtDigis.Font = New Font(txtDigis.Font.Name, size, txtDigis.Font.Style)
    End Sub

    Private Sub lblFOrange_Click(sender As Object, e As EventArgs) Handles lblFOrange.Click
        txtDigis.ForeColor = Color.Orange
    End Sub

    Private Sub lblFYellow_Click(sender As Object, e As EventArgs) Handles lblFYellow.Click
        txtDigis.ForeColor = Color.Yellow
    End Sub

    Private Sub lblFBrown_Click(sender As Object, e As EventArgs) Handles lblFBrown.Click
        txtDigis.ForeColor = Color.Brown
    End Sub

    Private Sub lblFWhite_Click(sender As Object, e As EventArgs) Handles lblFWhite.Click
        txtDigis.ForeColor = Color.White
    End Sub

    Private Sub lblFSkyBlue_Click(sender As Object, e As EventArgs) Handles lblFSkyBlue.Click
        txtDigis.ForeColor = Color.SkyBlue
    End Sub

    Private Sub lblBRed_Click(sender As Object, e As EventArgs) Handles lblBRed.Click
        txtDigis.BackColor = Color.Red
    End Sub

    Private Sub lblBBlue_Click(sender As Object, e As EventArgs) Handles lblBBlue.Click
        txtDigis.BackColor = Color.Blue
    End Sub

    Private Sub lblBGreen_Click(sender As Object, e As EventArgs) Handles lblBGreen.Click
        txtDigis.BackColor = Color.Green
    End Sub

    Private Sub lblBViolet_Click(sender As Object, e As EventArgs) Handles lblBViolet.Click
        txtDigis.BackColor = Color.Violet
    End Sub

    Private Sub lblBBlack_Click(sender As Object, e As EventArgs) Handles lblBBlack.Click
        txtDigis.BackColor = Color.Black
    End Sub

    Private Sub lblBOrange_Click(sender As Object, e As EventArgs) Handles lblBOrange.Click
        txtDigis.BackColor = Color.Orange
    End Sub

    Private Sub lblBYellow_Click(sender As Object, e As EventArgs) Handles lblBYellow.Click
        txtDigis.BackColor = Color.Yellow
    End Sub

    Private Sub lblBBrown_Click(sender As Object, e As EventArgs) Handles lblBBrown.Click
        txtDigis.BackColor = Color.Brown
    End Sub

    Private Sub lblBWhite_Click(sender As Object, e As EventArgs) Handles lblBWhite.Click
        txtDigis.BackColor = Color.White
    End Sub

    Private Sub lblBSkyBlue_Click(sender As Object, e As EventArgs) Handles lblBSkyBlue.Click
        txtDigis.BackColor = Color.SkyBlue
    End Sub

    Private Sub btnLow_Click(sender As Object, e As EventArgs) Handles btnLow.Click
        txtDigis.Text = Val(txtDigis.Text) - 2
    End Sub
End Class