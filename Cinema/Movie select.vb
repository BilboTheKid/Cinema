Public Class Movie_select

    Private Sub Movie_select_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub lstSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSelect.SelectedIndexChanged
        Dim strMovieChosen As String
        Dim intChosen As Integer
        intChosen = lstSelect.SelectedIndex
        strMovieChosen = lstSelect.Items(intChosen)
        MsgBox("You Have Selected " & strMovieChosen)
        Me.Hide()
        If strMovieChosen = "Birdemic: Shock and Terror" Then
            Birdemic_Shock_and_Terror.Show()
        ElseIf strMovieChosen = "We Are Number One but Every One is Replaced by Prince Charming Dying, Each Time With More Distortion" Then
            We_are_number_one.Show()
        ElseIf strMovieChosen = "Santa Claus Conquers the Martians" Then
            Santa_Claus.Show()
        ElseIf strMovieChosen = "Pirates of the Carribean: Rottenbeard and the Net" Then
            Rottenbeard.Show()
        ElseIf strMovieChosen = "Heil Honey i'm Home" Then
            Heil_Honey.Show()
        ElseIf strMovieChosen = "Breakin' 2: Electric Boogaloo" Then
            Boogaloo.Show()
        End If
    End Sub
End Class