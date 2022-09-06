Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblInput.Visible = False
        lblRadiusOrLength.Visible = False
        txtRadiusOrLength.Visible = False
        lblRadLengthM.Visible = False
        lblHeightOrWidth.Visible = False
        TxtHeightOrWidth.Visible = False
        lblHeightWidthM.Visible = False
    End Sub

    Private Sub ComboxShape_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboxShape.SelectedIndexChanged
        Dim Shape As String

        Shape = ComboxShape.Text

        Select Case Shape
            Case "Circle"
                lblInput.Visible = True
                lblRadiusOrLength.Visible = True
                txtRadiusOrLength.Visible = True
                lblRadLengthM.Visible = True
                lblHeightOrWidth.Visible = False
                TxtHeightOrWidth.Visible = False
                lblHeightWidthM.Visible = False
                lblRadiusOrLength.Text = "Radius:"

            Case "Parallelogram"
                lblInput.Visible = True
                lblRadiusOrLength.Visible = True
                txtRadiusOrLength.Visible = True
                lblRadLengthM.Visible = True
                lblHeightOrWidth.Visible = True
                TxtHeightOrWidth.Visible = True
                lblHeightWidthM.Visible = True
                lblRadiusOrLength.Text = "Length:"
                lblHeightOrWidth.Text = "Height:"

            Case "Kite"
                lblInput.Visible = True
                lblRadiusOrLength.Visible = True
                txtRadiusOrLength.Visible = True
                lblRadLengthM.Visible = True
                lblHeightOrWidth.Visible = True
                TxtHeightOrWidth.Visible = True
                lblHeightWidthM.Visible = True
                lblRadiusOrLength.Text = "Length:"
                lblHeightOrWidth.Text = "Width:"
        End Select
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Dim Radius As Double
        'Dim Length As Double
        'Dim Height As Double
        'Dim Width As Double
        Dim Area As Double
        Dim Shape As String

        'Radius = txtRadiusOrLength.Text
        'Length = txtRadiusOrLength.Text
        'Height = TxtHeightOrWidth.Text
        'Width = TxtHeightOrWidth.Text
        Shape = ComboxShape.Text

        Select Case Shape
            Case "Circle"
                Area = 3.141593 * (txtRadiusOrLength.Text) ^ 2
            Case "Parallelogram"
                Area = txtRadiusOrLength.Text * TxtHeightOrWidth.Text
            Case "Kite"
                Area = (txtRadiusOrLength.Text * TxtHeightOrWidth.Text) / 2
        End Select


        lblAnswer.Text = Area & "m^2"
    End Sub
End Class
