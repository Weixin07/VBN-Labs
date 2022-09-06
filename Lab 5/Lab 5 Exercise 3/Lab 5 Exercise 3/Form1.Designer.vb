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
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblSecond = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtFirst = New System.Windows.Forms.TextBox()
        Me.TxtSecond = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Location = New System.Drawing.Point(48, 63)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(93, 17)
        Me.lblFirst.TabIndex = 0
        Me.lblFirst.Text = "First Number:"
        '
        'lblSecond
        '
        Me.lblSecond.AutoSize = True
        Me.lblSecond.Location = New System.Drawing.Point(48, 124)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(114, 17)
        Me.lblSecond.TabIndex = 1
        Me.lblSecond.Text = "Second Number:"
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(93, 284)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 17)
        Me.lblAnswer.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(110, 199)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 34)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Find Larger Number"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtFirst
        '
        Me.TxtFirst.Location = New System.Drawing.Point(168, 63)
        Me.TxtFirst.Name = "TxtFirst"
        Me.TxtFirst.Size = New System.Drawing.Size(100, 22)
        Me.TxtFirst.TabIndex = 4
        '
        'TxtSecond
        '
        Me.TxtSecond.Location = New System.Drawing.Point(168, 124)
        Me.TxtSecond.Name = "TxtSecond"
        Me.TxtSecond.Size = New System.Drawing.Size(100, 22)
        Me.TxtSecond.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 467)
        Me.Controls.Add(Me.TxtSecond)
        Me.Controls.Add(Me.TxtFirst)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblSecond)
        Me.Controls.Add(Me.lblFirst)
        Me.Name = "Form1"
        Me.Text = "Hello World by VB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFirst As Label
    Friend WithEvents lblSecond As Label
    Friend WithEvents lblAnswer As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtFirst As TextBox
    Friend WithEvents TxtSecond As TextBox
End Class
