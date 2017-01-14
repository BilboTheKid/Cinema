Public Class Screen1
    Private Sub Screen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim StartRow = Asc("G")
        Dim seatRow, seatCol As Integer
        Dim seatIndex As Integer
        Const lenRow = 16
        Const lenCol = 7
        Const seatW = 40
        Const seatH = 40
        Const seatPadW = 5
        Const seatPadH = 5
        Dim seatArray() As Button
        ReDim seatArray(lenRow * lenCol)

        For seatIndex = 0 To seatArray.Length - 2
            seatArray(seatIndex) = New Button()
            seatRow = Int(seatIndex / lenRow)
            seatCol = seatIndex - (seatRow * lenRow)
            seatArray(seatIndex).Text = Chr(StartRow - seatRow) + Str(seatCol)
            seatArray(seatIndex).Left = seatCol * (seatW + seatPadW)
            seatArray(seatIndex).Top = seatRow * (seatH + seatPadH)
            seatArray(seatIndex).Width = seatW
            seatArray(seatIndex).Height = seatH
            If seatRow > 0 And seatRow < 3 And seatCol > 5 And seatCol < 9 Then
                seatArray(seatIndex).Visible = False
            End If
            If seatRow > 0 And seatCol > 14 Then
                seatArray(seatIndex).Visible = False
            End If
            Me.Controls.Add(seatArray(seatIndex))
        Next

    End Sub
End Class