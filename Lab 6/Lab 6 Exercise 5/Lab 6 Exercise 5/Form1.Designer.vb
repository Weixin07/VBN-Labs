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
        Me.lblN = New System.Windows.Forms.Label()
        Me.lblHarmonic = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.txtN = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblN
        '
        Me.lblN.AutoSize = True
        Me.lblN.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblN.Location = New System.Drawing.Point(192, 108)
        Me.lblN.Name = "lblN"
        Me.lblN.Size = New System.Drawing.Size(39, 32)
        Me.lblN.TabIndex = 0
        Me.lblN.Text = "n:"
        '
        'lblHarmonic
        '
        Me.lblHarmonic.AutoSize = True
        Me.lblHarmonic.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHarmonic.Location = New System.Drawing.Point(87, 301)
        Me.lblHarmonic.Name = "lblHarmonic"
        Me.lblHarmonic.Size = New System.Drawing.Size(144, 32)
        Me.lblHarmonic.TabIndex = 1
        Me.lblHarmonic.Text = "Harmonic:"
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(237, 301)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(2, 34)
        Me.lblAnswer.TabIndex = 2
        '
        'txtN
        '
        Me.txtN.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtN.Location = New System.Drawing.Point(246, 105)
        Me.txtN.Name = "txtN"
        Me.txtN.Size = New System.Drawing.Size(178, 38)
        Me.txtN.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(198, 203)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(226, 44)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 593)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtN)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblHarmonic)
        Me.Controls.Add(Me.lblN)
        Me.Name = "Form1"
        Me.Text = "Harmonic Sum"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblN As Label
    Friend WithEvents lblHarmonic As Label
    Friend WithEvents lblAnswer As Label
    Friend WithEvents txtN As TextBox
    Friend WithEvents btnCalculate As Button
End Class
