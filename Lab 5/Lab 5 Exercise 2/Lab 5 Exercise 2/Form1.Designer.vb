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
        Me.ComboxWeathers = New System.Windows.Forms.ComboBox()
        Me.BtnSee = New System.Windows.Forms.Button()
        Me.lblSelection = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboxWeathers
        '
        Me.ComboxWeathers.FormattingEnabled = True
        Me.ComboxWeathers.Items.AddRange(New Object() {"sunny", "snowy", "rainy", "cloudy"})
        Me.ComboxWeathers.Location = New System.Drawing.Point(151, 100)
        Me.ComboxWeathers.Name = "ComboxWeathers"
        Me.ComboxWeathers.Size = New System.Drawing.Size(121, 24)
        Me.ComboxWeathers.TabIndex = 0
        '
        'BtnSee
        '
        Me.BtnSee.Location = New System.Drawing.Point(80, 178)
        Me.BtnSee.Name = "BtnSee"
        Me.BtnSee.Size = New System.Drawing.Size(156, 23)
        Me.BtnSee.TabIndex = 1
        Me.BtnSee.Text = "See Your Weather!"
        Me.BtnSee.UseVisualStyleBackColor = True
        '
        'lblSelection
        '
        Me.lblSelection.AutoSize = True
        Me.lblSelection.Location = New System.Drawing.Point(12, 46)
        Me.lblSelection.Name = "lblSelection"
        Me.lblSelection.Size = New System.Drawing.Size(210, 17)
        Me.lblSelection.TabIndex = 2
        Me.lblSelection.Text = "Select The Weather You Prefer:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 450)
        Me.Controls.Add(Me.lblSelection)
        Me.Controls.Add(Me.BtnSee)
        Me.Controls.Add(Me.ComboxWeathers)
        Me.Name = "Form1"
        Me.Text = "Lying Weather Forcast"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboxWeathers As ComboBox
    Friend WithEvents BtnSee As Button
    Friend WithEvents lblSelection As Label
End Class
