'Imports the system.IO to allow '
Imports System.IO
Public Class Login
    Dim myfilewriter As StreamWriter
    Dim myfilereader As StreamReader
    Dim strFileName As String
    Dim intNumRecs As Integer
    Structure CustomRecType
        Dim intUserID As Integer
        Dim strUsername As String
        Dim strPassword As String
        Dim strEmail As String
    End Structure
    Dim MyUserRecArray() As CustomRecType
    Friend Shared Function readInFilm(ByVal nameOfFilm) As String

        Login.strFileName = "Revenue_" + nameOfFilm + ".txt"
        Login.myfilereader = New StreamReader(Login.strFileName)
        readInFilm = Login.myfilereader.ReadLine()
        Login.myfilereader.Close()
    End Function
    Friend Shared Sub writeOutFilm(ByVal nameOfFilm As String, ByVal revenue As String)
        Login.strFileName = "Revenue_" + nameOfFilm + ".txt"
        Login.myfilewriter = New StreamWriter(Login.strFileName)
        Login.myfilewriter.WriteLine(revenue)
        Login.myfilewriter.Close()
    End Sub
    Private Sub readindata()
        'Reads data from the program'
        Dim intCounter As Integer
        strFileName = "User_Details.txt"
        myfilereader = New StreamReader(strFileName)
        intNumRecs = myfilereader.ReadLine
        ReDim Preserve MyUserRecArray(intNumRecs)
        intCounter = 0
        Do Until myfilereader.EndOfStream = True
            intCounter = intCounter + 1
            MyUserRecArray(intCounter).intUserID = myfilereader.ReadLine()
            MyUserRecArray(intCounter).strUsername = myfilereader.ReadLine()
            MyUserRecArray(intCounter).strPassword = myfilereader.ReadLine()
            MyUserRecArray(intCounter).strEmail = myfilereader.ReadLine()
        Loop
        myfilereader.Close()
    End Sub
    Private Sub SaveToTextFile()
        'Writes the data from the program into a text file'
        Dim intCounter As Integer
        readindata()
        intNumRecs = intNumRecs + 1
        ReDim Preserve MyUserRecArray(intNumRecs)
        MyUserRecArray(intNumRecs).intUserID = intNumRecs
        MyUserRecArray(intNumRecs).strUsername = txtUsername.Text
        strFileName = "User_Details.txt"
        myfilewriter = New StreamWriter(strFileName)
        For intCounter = 1 To intNumRecs
            myfilewriter.WriteLine(MyUserRecArray(intCounter).intUserID)
            myfilewriter.WriteLine(MyUserRecArray(intCounter).strUsername)
            myfilewriter.WriteLine(MyUserRecArray(intCounter).strPassword)
            myfilewriter.WriteLine(MyUserRecArray(intCounter).strEmail)
        Next
        myfilewriter.Close()
    End Sub
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        'Saving user details to a text file'
        Dim intCounter As Integer
        strUsername = Me.txtUsername.Text
        strPassword = Me.txtPassword.Text
        strEmail = Me.txtEmail.Text
        readindata()
        intNumRecs = intNumRecs + 1

        ReDim Preserve MyUserRecArray(intNumRecs)
        'Saves the user details into an array'
        MyUserRecArray(intNumRecs).intUserID = intNumRecs
        MyUserRecArray(intNumRecs).strUsername = txtUsername.Text
        MyUserRecArray(intNumRecs).strPassword = txtPassword.Text
        MyUserRecArray(intNumRecs).strEmail = txtEmail.Text
        strFileName = "User_Details.txt"
        myfilewriter = New StreamWriter(strFileName)
        myfilewriter.WriteLine(intNumRecs)
        'From the array it moves the details to the text file'
        For intCounter = 1 To intNumRecs
            myfilewriter.WriteLine(MyUserRecArray(intCounter).intUserID)
            myfilewriter.WriteLine(MyUserRecArray(intCounter).strUsername)
            myfilewriter.WriteLine(MyUserRecArray(intCounter).strPassword)
            myfilewriter.WriteLine(MyUserRecArray(intCounter).strEmail)
        Next
        myfilewriter.Close()
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim intCounter As Integer
        Dim BooPasswordCorrect As Boolean = False
        Dim BooUsernameCorrect As Boolean = False
        Dim BooEmailCorrect As Boolean = False
        strUsername = Me.txtUsername.Text
        strPassword = Me.txtPassword.Text
        strEmail = Me.txtEmail.Text
        strCurUser = Me.txtUsername.Text
        For intCounter = 1 To intNumRecs
            If strUsername = MyUserRecArray(intCounter).strUsername Then
                BooUsernameCorrect = True
                If strPassword = MyUserRecArray(intCounter).strPassword Then
                    BooPasswordCorrect = True
                    If strEmail = MyUserRecArray(intCounter).strEmail Then
                        BooEmailCorrect = True
                    End If
                End If
            End If
        Next
        If (BooUsernameCorrect = True) And (BooPasswordCorrect = True) And (BooEmailCorrect = True) Then
            MsgBox("You have successfully logged in as " & strUsername)
            Me.Hide()
            Movie_select.Show()
        Else
            MsgBox("Your login details were incorrect")
        End If
    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call readindata()
    End Sub
End Class
