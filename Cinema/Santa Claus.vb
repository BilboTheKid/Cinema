Public Class Santa_Claus
    Private Sub btnSantaNew_Click(sender As Object, e As EventArgs) Handles btnSantaNew.Click
        Dim strAgeChosen As String
        Dim intChosen As Integer
        Static Dim intChildTotal As Integer
        Static Dim intAdultTotal As Integer
        Static Dim intOAPTotal As Integer
        Static Dim dblPrice As Double
        intChosen = lstSantaAge.SelectedIndex
        strAgeChosen = lstSantaAge.Items(intChosen)
        If strAgeChosen = "Child		£3.50" Then
            intChildTotal = intChildTotal + 1
            txtSantaChildTotal.Text = intChildTotal & " Child(ren)"
            dblPrice = dblPrice + 3.5
            txtSantaTotalPrice.Text = "£" & dblPrice
        ElseIf strAgeChosen = "Adult		£5.95" Then
            intAdultTotal = intAdultTotal + 1
            txtSantaAdultTotal.Text = intAdultTotal & " Adult(s)"
            dblPrice = dblPrice + 5.95
            txtSantaTotalPrice.Text = "£" & dblPrice
        ElseIf strAgeChosen = "OAP		£4.95" Then
            intOAPTotal = intOAPTotal + 1
            txtSantaOAPTotal.Text = intOAPTotal & " OAP(s)"
            dblPrice = dblPrice + 4.95
            txtSantaTotalPrice.Text = "£" & dblPrice
        End If
    End Sub
End Class