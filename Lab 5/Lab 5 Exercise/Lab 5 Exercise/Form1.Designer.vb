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
        Me.btnReveal = New System.Windows.Forms.Button()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.lblInserNumber = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnReveal
        '
        Me.btnReveal.Location = New System.Drawing.Point(149, 264)
        Me.btnReveal.Name = "btnReveal"
        Me.btnReveal.Size = New System.Drawing.Size(117, 33)
        Me.btnReveal.TabIndex = 0
        Me.btnReveal.Text = "Reveal Answer"
        Me.btnReveal.UseVisualStyleBackColor = True
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(244, 130)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(100, 22)
        Me.txtNumber.TabIndex = 1
        '
        'lblInserNumber
        '
        Me.lblInserNumber.AutoSize = True
        Me.lblInserNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInserNumber.Location = New System.Drawing.Point(12, 76)
        Me.lblInserNumber.Name = "lblInserNumber"
        Me.lblInserNumber.Size = New System.Drawing.Size(271, 25)
        Me.lblInserNumber.TabIndex = 2
        Me.lblInserNumber.Text = "Insert a number from 10 to 20:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 450)
        Me.Controls.Add(Me.lblInserNumber)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.btnReveal)
        Me.Name = "Form1"
        Me.Text = "Number Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReveal As Button
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents lblInserNumber As Label
End Class
