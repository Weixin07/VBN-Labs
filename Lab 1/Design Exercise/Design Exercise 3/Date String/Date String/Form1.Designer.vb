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
        Me.lblDayofWeek = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblDayofMonth = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDateString = New System.Windows.Forms.Label()
        Me.txtDayofWeek = New System.Windows.Forms.TextBox()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.txtDayofMonth = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.btnDate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDayofWeek
        '
        Me.lblDayofWeek.AutoSize = True
        Me.lblDayofWeek.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDayofWeek.Location = New System.Drawing.Point(69, 44)
        Me.lblDayofWeek.Name = "lblDayofWeek"
        Me.lblDayofWeek.Size = New System.Drawing.Size(352, 32)
        Me.lblDayofWeek.TabIndex = 0
        Me.lblDayofWeek.Text = "Enter the Day of the Week:"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.Location = New System.Drawing.Point(69, 99)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(224, 32)
        Me.lblMonth.TabIndex = 1
        Me.lblMonth.Text = "Enter the Month:"
        '
        'lblDayofMonth
        '
        Me.lblDayofMonth.AutoSize = True
        Me.lblDayofMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDayofMonth.Location = New System.Drawing.Point(69, 154)
        Me.lblDayofMonth.Name = "lblDayofMonth"
        Me.lblDayofMonth.Size = New System.Drawing.Size(359, 32)
        Me.lblDayofMonth.TabIndex = 2
        Me.lblDayofMonth.Text = "Enter the Day of the Month:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(69, 209)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(205, 32)
        Me.lblYear.TabIndex = 3
        Me.lblYear.Text = "Enter the Year:"
        '
        'lblDateString
        '
        Me.lblDateString.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDateString.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateString.Location = New System.Drawing.Point(75, 279)
        Me.lblDateString.Name = "lblDateString"
        Me.lblDateString.Size = New System.Drawing.Size(643, 57)
        Me.lblDateString.TabIndex = 4
        '
        'txtDayofWeek
        '
        Me.txtDayofWeek.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDayofWeek.Location = New System.Drawing.Point(459, 44)
        Me.txtDayofWeek.Name = "txtDayofWeek"
        Me.txtDayofWeek.Size = New System.Drawing.Size(259, 38)
        Me.txtDayofWeek.TabIndex = 5
        '
        'txtMonth
        '
        Me.txtMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonth.Location = New System.Drawing.Point(459, 99)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(259, 38)
        Me.txtMonth.TabIndex = 6
        '
        'txtDayofMonth
        '
        Me.txtDayofMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDayofMonth.Location = New System.Drawing.Point(459, 154)
        Me.txtDayofMonth.Name = "txtDayofMonth"
        Me.txtDayofMonth.Size = New System.Drawing.Size(259, 38)
        Me.txtDayofMonth.TabIndex = 7
        '
        'txtYear
        '
        Me.txtYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.Location = New System.Drawing.Point(459, 209)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(259, 38)
        Me.txtYear.TabIndex = 8
        '
        'btnDate
        '
        Me.btnDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDate.Location = New System.Drawing.Point(66, 359)
        Me.btnDate.Name = "btnDate"
        Me.btnDate.Size = New System.Drawing.Size(163, 38)
        Me.btnDate.TabIndex = 9
        Me.btnDate.Text = "Show Date"
        Me.btnDate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(295, 359)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(163, 38)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(555, 359)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(163, 38)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDate)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtDayofMonth)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.txtDayofWeek)
        Me.Controls.Add(Me.lblDateString)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDayofMonth)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblDayofWeek)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDayofWeek As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblDayofMonth As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblDateString As Label
    Friend WithEvents txtDayofWeek As TextBox
    Friend WithEvents txtMonth As TextBox
    Friend WithEvents txtDayofMonth As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents btnDate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
