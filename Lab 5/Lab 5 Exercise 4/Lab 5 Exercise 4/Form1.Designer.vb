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
        Me.ComboxShape = New System.Windows.Forms.ComboBox()
        Me.lblShape = New System.Windows.Forms.Label()
        Me.txtRadiusOrLength = New System.Windows.Forms.TextBox()
        Me.lblRadiusOrLength = New System.Windows.Forms.Label()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.lblHeightOrWidth = New System.Windows.Forms.Label()
        Me.TxtHeightOrWidth = New System.Windows.Forms.TextBox()
        Me.lblRadLengthM = New System.Windows.Forms.Label()
        Me.lblHeightWidthM = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboxShape
        '
        Me.ComboxShape.FormattingEnabled = True
        Me.ComboxShape.Items.AddRange(New Object() {"Circle", "Parallelogram", "Kite"})
        Me.ComboxShape.Location = New System.Drawing.Point(196, 97)
        Me.ComboxShape.Name = "ComboxShape"
        Me.ComboxShape.Size = New System.Drawing.Size(121, 24)
        Me.ComboxShape.TabIndex = 0
        '
        'lblShape
        '
        Me.lblShape.AutoSize = True
        Me.lblShape.Location = New System.Drawing.Point(96, 67)
        Me.lblShape.Name = "lblShape"
        Me.lblShape.Size = New System.Drawing.Size(53, 17)
        Me.lblShape.TabIndex = 1
        Me.lblShape.Text = "Shape:"
        '
        'txtRadiusOrLength
        '
        Me.txtRadiusOrLength.Location = New System.Drawing.Point(196, 186)
        Me.txtRadiusOrLength.Name = "txtRadiusOrLength"
        Me.txtRadiusOrLength.Size = New System.Drawing.Size(100, 22)
        Me.txtRadiusOrLength.TabIndex = 2
        '
        'lblRadiusOrLength
        '
        Me.lblRadiusOrLength.AutoSize = True
        Me.lblRadiusOrLength.Location = New System.Drawing.Point(102, 191)
        Me.lblRadiusOrLength.Name = "lblRadiusOrLength"
        Me.lblRadiusOrLength.Size = New System.Drawing.Size(0, 17)
        Me.lblRadiusOrLength.TabIndex = 5
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Location = New System.Drawing.Point(49, 159)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(90, 17)
        Me.lblInput.TabIndex = 8
        Me.lblInput.Text = "Please Input:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(147, 303)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(91, 33)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "Calculate!"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnswer.Location = New System.Drawing.Point(171, 376)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(2, 19)
        Me.lblAnswer.TabIndex = 10
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(123, 376)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(42, 17)
        Me.lblArea.TabIndex = 11
        Me.lblArea.Text = "Area:"
        '
        'lblHeightOrWidth
        '
        Me.lblHeightOrWidth.AutoSize = True
        Me.lblHeightOrWidth.Location = New System.Drawing.Point(107, 234)
        Me.lblHeightOrWidth.Name = "lblHeightOrWidth"
        Me.lblHeightOrWidth.Size = New System.Drawing.Size(0, 17)
        Me.lblHeightOrWidth.TabIndex = 12
        '
        'TxtHeightOrWidth
        '
        Me.TxtHeightOrWidth.Location = New System.Drawing.Point(196, 229)
        Me.TxtHeightOrWidth.Name = "TxtHeightOrWidth"
        Me.TxtHeightOrWidth.Size = New System.Drawing.Size(100, 22)
        Me.TxtHeightOrWidth.TabIndex = 13
        '
        'lblRadLengthM
        '
        Me.lblRadLengthM.AutoSize = True
        Me.lblRadLengthM.Location = New System.Drawing.Point(302, 189)
        Me.lblRadLengthM.Name = "lblRadLengthM"
        Me.lblRadLengthM.Size = New System.Drawing.Size(19, 17)
        Me.lblRadLengthM.TabIndex = 15
        Me.lblRadLengthM.Text = "m"
        '
        'lblHeightWidthM
        '
        Me.lblHeightWidthM.AutoSize = True
        Me.lblHeightWidthM.Location = New System.Drawing.Point(302, 229)
        Me.lblHeightWidthM.Name = "lblHeightWidthM"
        Me.lblHeightWidthM.Size = New System.Drawing.Size(19, 17)
        Me.lblHeightWidthM.TabIndex = 16
        Me.lblHeightWidthM.Text = "m"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 462)
        Me.Controls.Add(Me.lblHeightWidthM)
        Me.Controls.Add(Me.lblRadLengthM)
        Me.Controls.Add(Me.TxtHeightOrWidth)
        Me.Controls.Add(Me.lblHeightOrWidth)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblInput)
        Me.Controls.Add(Me.lblRadiusOrLength)
        Me.Controls.Add(Me.txtRadiusOrLength)
        Me.Controls.Add(Me.lblShape)
        Me.Controls.Add(Me.ComboxShape)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboxShape As ComboBox
    Friend WithEvents lblShape As Label
    Friend WithEvents txtRadiusOrLength As TextBox
    Friend WithEvents lblRadiusOrLength As Label
    Friend WithEvents lblInput As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblAnswer As Label
    Friend WithEvents lblArea As Label
    Friend WithEvents lblHeightOrWidth As Label
    Friend WithEvents TxtHeightOrWidth As TextBox
    Friend WithEvents lblRadLengthM As Label
    Friend WithEvents lblHeightWidthM As Label
End Class
