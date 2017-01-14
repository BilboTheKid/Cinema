Public Class Screen2
    Public seatArray() As Button
    Private Sub Screen2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim StartRow = Asc("G")
        Dim seatRow, seatCol As Integer
        Dim seatIndex As Integer
        Const lenRow = 18
        Const lenCol = 7
        Const seatW = 40
        Const seatH = 40
        Const seatPadW = 5
        Const seatPadH = 5
        ReDim seatArray((lenRow * lenCol) - 1)

        For seatIndex = 0 To seatArray.Length - 1
            seatArray(seatIndex) = New Button()
            seatRow = Int(seatIndex / lenRow)
            seatCol = seatIndex - (seatRow * lenRow)
            seatArray(seatIndex).Text = Chr(StartRow - seatRow) + Str(seatCol + 1)
            seatArray(seatIndex).Left = seatCol * (seatW + seatPadW)
            seatArray(seatIndex).Top = seatRow * (seatH + seatPadH)
            seatArray(seatIndex).Width = seatW
            seatArray(seatIndex).Height = seatH
            seatArray(seatIndex).BackColor = Color.White
            If seatRow = 0 And seatCol > 15 Then
                seatArray(seatIndex).Visible = False
            End If
            If seatRow > 0 And seatCol > 5 And seatCol < 9 Then
                seatArray(seatIndex).Visible = False
            End If
            If seatRow > 0 And seatRow < 3 And seatCol > 14 Then
                seatArray(seatIndex).Visible = False
            End If
            AddHandler seatArray(seatIndex).Click, AddressOf HandleSeatClick
            Me.Controls.Add(seatArray(seatIndex))
        Next
    End Sub
    Private Sub HandleSeatClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim seat As Button = DirectCast(sender, Button)
        If seat.BackColor = Color.White Then
            If NumClicked() < TicketsOwned Then
                seat.BackColor = Color.Blue
                seat.ForeColor = Color.White
            End If
        Else
            seat.BackColor = Color.White
            seat.ForeColor = Color.Black
        End If
    End Sub
    Private Function NumClicked() As Integer
        Dim intCounter As Integer = 0
        Dim tempSeat As Button
        For Each tempSeat In seatArray
            If tempSeat.BackColor = Color.Blue Then
                intCounter += 1
            End If
        Next
        NumClicked = intCounter
    End Function
End Class