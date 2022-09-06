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
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblBMI = New System.Windows.Forms.Label()
        Me.lblShowBMI = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(80, 119)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(112, 17)
        Me.lblHeight.TabIndex = 0
        Me.lblHeight.Text = "Your Height (m):"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(80, 189)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(119, 17)
        Me.lblWeight.TabIndex = 1
        Me.lblWeight.Text = "Your Weight (kg):"
        '
        'lblBMI
        '
        Me.lblBMI.AutoSize = True
        Me.lblBMI.Location = New System.Drawing.Point(80, 251)
        Me.lblBMI.Name = "lblBMI"
        Me.lblBMI.Size = New System.Drawing.Size(69, 17)
        Me.lblBMI.TabIndex = 2
        Me.lblBMI.Text = "Your BMI:"
        '
        'lblShowBMI
        '
        Me.lblShowBMI.AutoSize = True
        Me.lblShowBMI.Location = New System.Drawing.Point(240, 251)
        Me.lblShowBMI.Name = "lblShowBMI"
        Me.lblShowBMI.Size = New System.Drawing.Size(0, 17)
        Me.lblShowBMI.TabIndex = 3
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(243, 114)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(100, 22)
        Me.txtHeight.TabIndex = 4
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(243, 186)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(100, 22)
        Me.txtWeight.TabIndex = 5
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(243, 346)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 6
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.lblShowBMI)
        Me.Controls.Add(Me.lblBMI)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.lblHeight)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeight As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblBMI As Label
    Friend WithEvents lblShowBMI As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents btnConvert As Button
End Class
