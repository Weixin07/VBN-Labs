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
        Me.lblFahrenheit = New System.Windows.Forms.Label()
        Me.lblCentigrade = New System.Windows.Forms.Label()
        Me.txtF = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFahrenheit
        '
        Me.lblFahrenheit.AutoSize = True
        Me.lblFahrenheit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFahrenheit.Location = New System.Drawing.Point(48, 108)
        Me.lblFahrenheit.Name = "lblFahrenheit"
        Me.lblFahrenheit.Size = New System.Drawing.Size(304, 32)
        Me.lblFahrenheit.TabIndex = 0
        Me.lblFahrenheit.Text = "Fahrenheit (degrees F)"
        '
        'lblCentigrade
        '
        Me.lblCentigrade.AutoSize = True
        Me.lblCentigrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCentigrade.Location = New System.Drawing.Point(48, 200)
        Me.lblCentigrade.Name = "lblCentigrade"
        Me.lblCentigrade.Size = New System.Drawing.Size(310, 32)
        Me.lblCentigrade.TabIndex = 1
        Me.lblCentigrade.Text = "Centigrade (degrees C)"
        '
        'txtF
        '
        Me.txtF.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtF.Location = New System.Drawing.Point(399, 108)
        Me.txtF.Name = "txtF"
        Me.txtF.Size = New System.Drawing.Size(350, 38)
        Me.txtF.TabIndex = 2
        '
        'txtC
        '
        Me.txtC.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtC.Location = New System.Drawing.Point(399, 200)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(350, 38)
        Me.txtC.TabIndex = 3
        '
        'btnGo
        '
        Me.btnGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.Location = New System.Drawing.Point(54, 315)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(152, 46)
        Me.btnGo.TabIndex = 4
        Me.btnGo.Text = "Go!"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(597, 315)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(152, 46)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClearAll
        '
        Me.btnClearAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAll.Location = New System.Drawing.Point(325, 315)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(152, 46)
        Me.btnClearAll.TabIndex = 6
        Me.btnClearAll.Text = "Clear All"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClearAll)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.txtF)
        Me.Controls.Add(Me.lblCentigrade)
        Me.Controls.Add(Me.lblFahrenheit)
        Me.Name = "Form1"
        Me.Text = "My Converter Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFahrenheit As Label
    Friend WithEvents lblCentigrade As Label
    Friend WithEvents txtF As TextBox
    Friend WithEvents txtC As TextBox
    Friend WithEvents btnGo As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClearAll As Button
End Class
