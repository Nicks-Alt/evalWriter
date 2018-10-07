Option Strict On
Public Class frmEvalWriter
    Private FileName As String
    '
    'Create Evals subdirectory if it doesn't exist
    '
    Private Sub frmEvalWriter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(5000)
        If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.CurrentDirectory.ToString() & "\Evals") = False Then
            My.Computer.FileSystem.CreateDirectory("Evals")
        End If
    End Sub
    '
    'Clock Handler
    '
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblProgramLocation.Text = My.Computer.FileSystem.CurrentDirectory.ToString()
        lblTime.Text = TimeOfDay.ToString("hh:mm:ss tt")
    End Sub
    '
    'Starts eval creating on button click
    '
    Private Sub btnBegin_Click(sender As Object, e As EventArgs) Handles btnBegin.Click
        'Init Variables
        Dim FileNum As Integer = FreeFile()
        Dim strPersonName As String
        Dim strPersonSteamID As String
        Dim strInput(5) As String
        Dim strTitle As String
        Dim strYourName As String
        'If T-Admin ask for their name
        If radTAdmin.Checked Then
            strYourName = InputBox("Enter your name:", "", " ")
        End If
        'Ask for name and steamID
        strPersonName = InputBox("Enter person's name:", "", " ")
        strPersonSteamID = InputBox("Enter Person's SteamID:", "", " ")
        Dim pos As Integer
        'Start Conversion to Steam64
        If strPersonSteamID.Contains(":") Then
            pos = InStrRev(strPersonSteamID, ":")
        End If
        Dim trimmedFileName As String
        trimmedFileName = strPersonSteamID.Substring(pos, strPersonSteamID.Length - pos)
        Dim steamid64 As String
        If strPersonSteamID.Substring(9, 1) = "0" Then
            steamid64 = ((CInt(trimmedFileName) * 2) + 76561197960265728).ToString
        Else
            steamid64 = ((CInt(trimmedFileName) * 2) + 76561197960265729).ToString
        End If
        'Create Textfile for eval
        FileName = strPersonName & " - " & steamid64
        FileOpen(FileNum, My.Computer.FileSystem.CurrentDirectory.ToString() & "\Evals\" & FileName & ".txt", OpenMode.Append)
        'Gather eval information
        For i = 0 To 5
            If i = 0 Then
                strTitle = "How is " & strPersonName & "'s attitude in RP/sits?"
                strInput(0) = InputBox(strTitle, " ", " ")
                If strInput(0).Contains(".") = False Then
                    strInput(0) += "."
                End If
            ElseIf i = 1 Then
                strTitle = "How does " & strPersonName & " handle/conduct sits?"
                strInput(1) = InputBox(strTitle, " ", " ")
                If strInput(1).Contains(".") = False Then
                    strInput(1) += "."
                End If
            ElseIf i = 2 Then
                strTitle = "Does " & strPersonName & " understand the rules and the punishments for them?"
                strInput(2) = InputBox(strTitle, " ", " ")
                If strInput(2).Contains(".") = False Then
                    strInput(2) += "."
                End If
            ElseIf i = 3 Then
                strTitle = "How is " & strPersonName & "'s activity?"
                strInput(3) = InputBox(strTitle, " ", " ")
                If strInput(3).Contains(".") = False Then
                    strInput(3) += "."
                End If
            ElseIf i = 4 Then
                strTitle = "What other useful information can be provided about " & strPersonName & "?"
                strInput(4) = InputBox(strTitle, " ", " ")
                If strInput(4).Contains(".") = False Then
                    strInput(4) += "."
                End If
            ElseIf i = 5 Then
                strTitle = "Overall, how do you rate " & strPersonName & " out of 10?"
                strInput(5) = InputBox(strTitle, " ", " ")
                If strInput(5).Contains(".") = False Then
                    strInput(5) += "."
                End If
            End If
        'Suggest copying to clipboard
        Next
        PrintLine(FileNum, strInput(0) & " " & strInput(1) & " " & strInput(2) & " " & strInput(3) & " " & strInput(4) & " " & strInput(5))
        Select Case MsgBox("Would you like to copy that eval?", vbYesNo, "Copy?")
            Case MsgBoxResult.Yes
                'If P-admin+
                If radPAdmin.Checked Then
                    'Copy to clipboard
                    Clipboard.SetText(strPersonName & " - " & strPersonSteamID & Environment.NewLine & strInput(0) & " " & strInput(1) & " " & strInput(2) & " " & strInput(3) & " " & strInput(4) & " " & strInput(5))
                    'Suggest opening P-Admin+ chat
                    Select Case MsgBox("Would you like to open the P-Admin chat?", vbYesNo, "Open chat?")
                        Case MsgBoxResult.Yes
                            Process.Start("https://forum.superiorservers.co/messenger/71/?page=9999")
                    End Select
                'If T-admin
                ElseIf radTAdmin.Checked Then
                    'Copy to clipboard
                    Clipboard.SetText(strYourName & "'s Eval - " & strPersonName & " - " & strPersonSteamID & Environment.NewLine & strInput(0) & " " & strInput(1) & " " & strInput(2) & " " & strInput(3) & " " & strInput(4) & " " & strInput(5))
                    'Open Nick's steam profile to PM
                    Process.Start("steam://url/SteamIDPage/76561198124391666")
                End If
        End Select
        FileClose(FileNum)
    End Sub
    '
    'Read written Evals
    '
    Private Sub ReadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReadToolStripMenuItem.Click
        Dim myStream As IO.Stream = Nothing
        Dim strText As String
        Dim strPath As String = lblProgramLocation.Text
        Dim FileDialog As New OpenFileDialog()
        If FileDialog.ShowDialog = DialogResult.OK Then
            myStream = FileDialog.OpenFile
            If myStream IsNot Nothing Then
                strText = My.Computer.FileSystem.ReadAllText(FileDialog.FileName)
                FileName = IO.Path.GetFileName(FileDialog.FileName).Substring(0, IO.Path.GetFileName(FileDialog.FileName).Length - 4)
                MsgBox(strText, vbInformation, FileName)
                myStream.Close()
            Else
                MsgBox("File is empty", vbCritical, "Yikes!")
            End If
        End If
    End Sub
End Class
