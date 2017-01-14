Public Class Rottenbeard
    Dim intTicketTotal As Integer
    Private Sub Rottenbeard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnMvSel_Click(sender As Object, e As EventArgs) Handles btnMvSel.Click
        Me.Hide()
        Movie_select.Show()
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim strAgeChosen As String
        Dim intChosen As Integer
        Static Dim intChildTotal As Integer
        Static Dim intAdultTotal As Integer
        Static Dim intOAPTotal As Integer
        Static Dim dblPrice As Double
        intChosen = lstAge.SelectedIndex
        strAgeChosen = lstAge.Items(intChosen)
        If strAgeChosen = "Child		£3.50" Then
            intChildTotal = intChildTotal + 1
            intTicketTotal = intTicketTotal + 1
            txtChildTotal.Text = intChildTotal & " Child(ren)"
            dblPrice = dblPrice + 3.5
            txtTotalPrice.Text = "£" & dblPrice
        ElseIf strAgeChosen = "Adult		£5.95" Then
            intAdultTotal = intAdultTotal + 1
            intTicketTotal = intTicketTotal + 1
            txtAdultTotal.Text = intAdultTotal & " Adult(s)"
            dblPrice = dblPrice + 5.95
            txtTotalPrice.Text = "£" & dblPrice
        ElseIf strAgeChosen = "OAP		£4.95" Then
            intOAPTotal = intOAPTotal + 1
            intTicketTotal = intTicketTotal + 1
            txtOAPTotal.Text = intOAPTotal & " OAP(s)"
            dblPrice = dblPrice + 4.95
            txtTotalPrice.Text = "£" & dblPrice
        End If
    End Sub
    Private Sub btnBuy_Click(sender As Object, e As EventArgs) Handles btnBuy.Click
        Me.Hide()
        Screen1.Show()
        TicketsOwned = intTicketTotal
    End Sub
End Class