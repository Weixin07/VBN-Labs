Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboxItemsSelection.SelectedIndexChanged
        'Dim Product As String
        'Product = comboxItemsSelection.Text
        'MessageBox.Show(Product)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnDisplay.Click
        'Dim Product As String
        'Product = comboxItemsSelection.Text
        'MessageBox.Show(Product)
    End Sub
End Class

'Putting the codes
Dim Product As String
Product = comboxItemsSelection.Text
MessageBox.Show(Product)
'At Combo Box Or Button have different effects, Try it out by removing "'" In front Of the codes.
