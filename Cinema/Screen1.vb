﻿Public Class Screen1
    Public btnArray(100) As Button
    Private Sub AddButtons()
        Dim xPos As Integer = 0
        Dim yPos As Integer = 0
        Dim n As Integer = 0
        'Dim intCounter As Integer
        For i As Integer = 0 To 230
            ' Initialize one variable
            btnArray(i) = New System.Windows.Forms.Button
        Next i
        While (n < 231)
            With (btnArray(n))
                .Tag = n + 1 ' Tag of button
                .Width = 33 ' Width of button
                .Height = 20 ' Height of button
                If (n = 21) Then ' Location of first line of seats:
                    xPos = 0
                    yPos = 20
                End If
                If (n = 42) Then ' Location of second line of seats:
                    xPos = 0
                    yPos = 40
                End If
                If (n = 63) Then ' Location of third line of seats:
                    xPos = 0
                    yPos = 60
                End If
                If (n = 84) Then ' Location of forth line of seats:
                    xPos = 0
                    yPos = 80
                End If
                If (n = 105) Then ' Location of fifth line of seats:
                    xPos = 0
                    yPos = 100
                End If
                If (n = 126) Then ' Location of sixth line of seats:
                    xPos = 0
                    yPos = 120
                End If
                If (n = 147) Then ' Location of seventh line of seats:
                    xPos = 0
                    yPos = 140
                End If
                If (n = 168) Then ' Location of eighth line of seats:
                    xPos = 0
                    yPos = 160
                End If
                If (n = 189) Then ' Location of ninth line of seats:
                    xPos = 0
                    yPos = 180
                End If
                If (n = 210) Then ' Location of tenth line of buttons:
                    xPos = 0
                    yPos = 200
                End If
                ' Location of button:
                .Left = xPos
                .Top = yPos
                ' Add buttons to a Panel:
                pnlButtons.Controls.Add(btnArray(n)) ' Let panel hold the Buttons
                xPos = xPos + .Width ' Left of next button
                ' Write English Character:
                Dim Alphabet() As String = {" ", " ", " ", _
                "G1", "G2", "G3", "G4", "G5", "G6", "G7", "G8", "G9", "G10", "G11", "G12", "G13", "G14", "G15", "G16", _
                "F1", "F2", "F3", "F4", "F5", "F6", "  ", "  ", "  ", "F10", "F11", "F12", "F13", "F14", "F15", _
                "E1", "E2", "E3", "E4", "E5", "E6", "  ", "  ", "  ", "E10", "E11", "E12", "E13", "E14", "E15", _
                "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "D10", "D11", "D12", "D13", "D14", "D15", _
                "C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "C10", "C11", "C12", "C13", "C14", "C15", _
                "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10", "B11", "B12", "B13", "B14", "B15", _
                "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "A10", "A11", "A12", "A13", "A14", "A15"}
                .Text = Alphabet(n)
                ' ****************************************************************
                ' for Event of click Button
                AddHandler .Click, AddressOf Me.ClickButton
                n += 1
            End With
        End While
    End Sub
    ' Result of (Click Button) event, get the text of button
    Public Sub ClickButton(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Dim btn As Button = sender
        If CType(sender, Button).Text = "" Then
            MsgBox("This seat is not available")
        Else
            pnlButtons.Visible = True
            ' MessageBox.Show("You clicked character [" + btn.Text + "]")
            CType(sender, Button).BackColor = Color.Yellow
            CType(sender, Button).Enabled = False
            'Collected data from into Customer Array
        End If
    End Sub
    Private Sub Screen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call AddButtons()
    End Sub
End Class