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
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.txtStart = New System.Windows.Forms.TextBox()
        Me.txtEnd = New System.Windows.Forms.TextBox()
        Me.btnForLoop = New System.Windows.Forms.Button()
        Me.btnDoLoop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.Location = New System.Drawing.Point(55, 137)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(190, 32)
        Me.lblStart.TabIndex = 0
        Me.lblStart.Text = "Start Number:"
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnd.Location = New System.Drawing.Point(55, 222)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(181, 32)
        Me.lblEnd.TabIndex = 1
        Me.lblEnd.Text = "End Number:"
        '
        'txtStart
        '
        Me.txtStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStart.Location = New System.Drawing.Point(262, 131)
        Me.txtStart.Name = "txtStart"
        Me.txtStart.Size = New System.Drawing.Size(292, 38)
        Me.txtStart.TabIndex = 2
        '
        'txtEnd
        '
        Me.txtEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnd.Location = New System.Drawing.Point(262, 216)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Size = New System.Drawing.Size(292, 38)
        Me.txtEnd.TabIndex = 3
        '
        'btnForLoop
        '
        Me.btnForLoop.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForLoop.Location = New System.Drawing.Point(241, 325)
        Me.btnForLoop.Name = "btnForLoop"
        Me.btnForLoop.Size = New System.Drawing.Size(180, 40)
        Me.btnForLoop.TabIndex = 4
        Me.btnForLoop.Text = "For Loops"
        Me.btnForLoop.UseVisualStyleBackColor = True
        '
        'btnDoLoop
        '
        Me.btnDoLoop.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDoLoop.Location = New System.Drawing.Point(241, 390)
        Me.btnDoLoop.Name = "btnDoLoop"
        Me.btnDoLoop.Size = New System.Drawing.Size(180, 40)
        Me.btnDoLoop.TabIndex = 5
        Me.btnDoLoop.Text = "Do Loops"
        Me.btnDoLoop.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 641)
        Me.Controls.Add(Me.btnDoLoop)
        Me.Controls.Add(Me.btnForLoop)
        Me.Controls.Add(Me.txtEnd)
        Me.Controls.Add(Me.txtStart)
        Me.Controls.Add(Me.lblEnd)
        Me.Controls.Add(Me.lblStart)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStart As Label
    Friend WithEvents lblEnd As Label
    Friend WithEvents txtStart As TextBox
    Friend WithEvents txtEnd As TextBox
    Friend WithEvents btnForLoop As Button
    Friend WithEvents btnDoLoop As Button
End Class
