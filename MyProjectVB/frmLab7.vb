Public Class frmLab7
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnMoveAll.Click
        Dim a As Integer
        a = ListBox1.Items.Count
        If a < 1 Then
            MessageBox.Show("ไม่มีตัวเลือกแล้ว")
        Else
            For aa = 1 To ListBox1.Items.Count
                cboOutput.Items.Add(ListBox1.SelectedItem)
                ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
                ListBox1.SelectedIndex = ListBox1.Items.Count - 1
                cboOutput.SelectedIndex = cboOutput.Items.Count - 1
            Next
            lblOutput.Text = cboOutput.SelectedItem
        End If
    End Sub

    Private Sub frmLab7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAdd.Enabled = False
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ListBox1.Items.Add(txtAdd.Text)
        ListBox1.SelectedIndex = ListBox1.Items.Count - 1
        txtAdd.Clear()

    End Sub

    Private Sub txtAdd_TextChanged(sender As Object, e As EventArgs) Handles txtAdd.TextChanged
        If txtAdd.Text <> "" Then
            btnAdd.Enabled = True
        Else
            btnAdd.Enabled = False
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim a, b As Integer
        a = cboOutput.Items.Count
        If a < 1 Then
            MessageBox.Show("ไม่มีตัวเลือกแล้ว")
        Else
            cboOutput.Text = ""
            ListBox1.Items.Add(cboOutput.SelectedItem)
            ' b = ListBox1.SelectedIndex
            ' If cboOutput.SelectedIndex = cboOutput.Items.Count - 1 Then
            ' cboOutput.Items.RemoveAt(cboOutput.SelectedIndex)
            'cboOutput.SelectedIndex = cboOutput.Items.Count - 1
            ' Else
            'cboOutput.Items.RemoveAt(cboOutput.SelectedIndex)
            'cboOutput.SelectedIndex = b
            'End If
            cboOutput.Items.Remove(cboOutput.SelectedItem)
            ListBox1.SelectedIndex = ListBox1.Items.Count - 1
            cboOutput.SelectedIndex = cboOutput.Items.Count - 1
        End If
        lblOutput.Text = cboOutput.SelectedItem
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ListBox1.Items.Clear()
        txtAdd.Clear()
        cboOutput.Items.Clear()
        cboOutput.Text = ""
        lblOutput.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        Dim a, b As Integer
        a = ListBox1.Items.Count
        If a = 0 Then
            MessageBox.Show("ไม่มีตัวเลือกแล้ว")
        Else
            cboOutput.Items.Add(ListBox1.SelectedItem)
            b = ListBox1.SelectedIndex
            If ListBox1.SelectedIndex = ListBox1.Items.Count - 1 Then
                ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
                ListBox1.SelectedIndex = ListBox1.Items.Count - 1
            Else
                ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
                ListBox1.SelectedIndex = b
            End If
            cboOutput.SelectedIndex = cboOutput.Items.Count - 1
        End If
    End Sub

    Private Sub btnBackAll_Click(sender As Object, e As EventArgs) Handles btnBackAll.Click
        Dim b As Integer
        b = cboOutput.Items.Count
        If b < 1 Then
            MessageBox.Show("ไม่มีตัวเลือกแล้ว")
        Else
            For bb = 1 To cboOutput.Items.Count
                ListBox1.Items.Add(cboOutput.SelectedItem)
                cboOutput.Items.RemoveAt(cboOutput.SelectedIndex)
                cboOutput.SelectedIndex = cboOutput.Items.Count - 1
                ListBox1.SelectedIndex = ListBox1.Items.Count - 1
            Next
            cboOutput.Text = ""
            lblOutput.Text = cboOutput.SelectedItem
        End If
    End Sub

    Private Sub cboOutput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOutput.SelectedIndexChanged
        lblOutput.Text = cboOutput.SelectedItem
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class