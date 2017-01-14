Public Class Birdemic_Shock_and_Terror
    Public TicketsOwned As Integer
    Dim intTicketTotal As Integer
    Private Sub Birdemic_Shock_and_Terror_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnBirdNew_Click(sender As Object, e As EventArgs) Handles btnBirdNew.Click
        Dim strAgeChosen As String
        Dim intChosen As Integer
        Static Dim intChildTotal As Integer
        Static Dim intAdultTotal As Integer
        Static Dim intOAPTotal As Integer
        Static Dim dblPrice As Double
        intChosen = lstBirdAge.SelectedIndex
        strAgeChosen = lstBirdAge.Items(intChosen)
        If strAgeChosen = "Child		£3.50" Then
            intChildTotal = intChildTotal + 1
            intTicketTotal = intTicketTotal + 1
            txtBirdChildTotal.Text = intChildTotal & " Child(ren)"
            dblPrice = dblPrice + 3.5
            txtBirdTotalPrice.Text = "£" & dblPrice
        ElseIf strAgeChosen = "Adult		£5.95" Then
            intAdultTotal = intAdultTotal + 1
            intTicketTotal = intTicketTotal + 1
            txtBirdAdultTotal.Text = intAdultTotal & " Adult(s)"
            dblPrice = dblPrice + 5.95
            txtBirdTotalPrice.Text = "£" & dblPrice
        ElseIf strAgeChosen = "OAP		£4.95" Then
            intOAPTotal = intOAPTotal + 1
            intTicketTotal = intTicketTotal + 1
            txtBirdOAPTotal.Text = intOAPTotal & " OAP(s)"
            dblPrice = dblPrice + 4.95
            txtBirdTotalPrice.Text = "£" & dblPrice
        End If
    End Sub
    Private Sub btnBirdBuy_Click(sender As Object, e As EventArgs) Handles btnBirdBuy.Click
        Me.Hide()
        Screen2.Show()
        TicketsOwned = intTicketTotal
    End Sub
End Class