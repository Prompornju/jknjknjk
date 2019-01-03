<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.lblSalaryperyer = New System.Windows.Forms.Label()
        Me.lbltax = New System.Windows.Forms.Label()
        Me.lblNetsalary = New System.Windows.Forms.Label()
        Me.btnSum = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(264, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณรายได้ทั้งปี"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SeaGreen
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(77, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "เงินเดือนพนักงาน"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SeaGreen
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(77, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 29)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "เงินเดือนพนักงานต่อปี"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SeaGreen
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(77, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 29)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "ภาษีที่ต้องชำระ"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SeaGreen
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(77, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 29)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "รายได้สุทธิ"
        '
        'txtSalary
        '
        Me.txtSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSalary.Location = New System.Drawing.Point(268, 113)
        Me.txtSalary.Multiline = True
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(174, 29)
        Me.txtSalary.TabIndex = 2
        '
        'lblSalaryperyer
        '
        Me.lblSalaryperyer.BackColor = System.Drawing.Color.Khaki
        Me.lblSalaryperyer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSalaryperyer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSalaryperyer.Location = New System.Drawing.Point(268, 162)
        Me.lblSalaryperyer.Name = "lblSalaryperyer"
        Me.lblSalaryperyer.Size = New System.Drawing.Size(174, 29)
        Me.lblSalaryperyer.TabIndex = 1
        '
        'lbltax
        '
        Me.lbltax.BackColor = System.Drawing.Color.Khaki
        Me.lbltax.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbltax.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbltax.Location = New System.Drawing.Point(268, 213)
        Me.lbltax.Name = "lbltax"
        Me.lbltax.Size = New System.Drawing.Size(174, 29)
        Me.lbltax.TabIndex = 1
        '
        'lblNetsalary
        '
        Me.lblNetsalary.BackColor = System.Drawing.Color.Khaki
        Me.lblNetsalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblNetsalary.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNetsalary.Location = New System.Drawing.Point(268, 263)
        Me.lblNetsalary.Name = "lblNetsalary"
        Me.lblNetsalary.Size = New System.Drawing.Size(174, 29)
        Me.lblNetsalary.TabIndex = 1
        '
        'btnSum
        '
        Me.btnSum.AutoSize = True
        Me.btnSum.BackColor = System.Drawing.Color.RosyBrown
        Me.btnSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSum.Location = New System.Drawing.Point(268, 333)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(84, 44)
        Me.btnSum.TabIndex = 3
        Me.btnSum.Text = "คำนวณ"
        Me.btnSum.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.BackColor = System.Drawing.Color.RosyBrown
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClose.Location = New System.Drawing.Point(418, 333)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(84, 44)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "ปิด"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSalmon
        Me.ClientSize = New System.Drawing.Size(619, 408)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSum)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.lblNetsalary)
        Me.Controls.Add(Me.lbltax)
        Me.Controls.Add(Me.lblSalaryperyer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents lblSalaryperyer As Label
    Friend WithEvents lbltax As Label
    Friend WithEvents lblNetsalary As Label
    Friend WithEvents btnSum As Button
    Friend WithEvents btnClose As Button
End Class
