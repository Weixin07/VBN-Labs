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
        Me.comboxItemsSelection = New System.Windows.Forms.ComboBox()
        Me.BtnDisplay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'comboxItemsSelection
        '
        Me.comboxItemsSelection.FormattingEnabled = True
        Me.comboxItemsSelection.Items.AddRange(New Object() {"Item 1", "Item 2", "Item 3", "Item 4", "Item 5"})
        Me.comboxItemsSelection.Location = New System.Drawing.Point(41, 41)
        Me.comboxItemsSelection.Name = "comboxItemsSelection"
        Me.comboxItemsSelection.Size = New System.Drawing.Size(206, 24)
        Me.comboxItemsSelection.TabIndex = 0
        '
        'BtnDisplay
        '
        Me.BtnDisplay.Location = New System.Drawing.Point(100, 181)
        Me.BtnDisplay.Name = "BtnDisplay"
        Me.BtnDisplay.Size = New System.Drawing.Size(115, 45)
        Me.BtnDisplay.TabIndex = 1
        Me.BtnDisplay.Text = "Display Choice"
        Me.BtnDisplay.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnDisplay)
        Me.Controls.Add(Me.comboxItemsSelection)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents comboxItemsSelection As ComboBox
    Friend WithEvents BtnDisplay As Button
End Class
