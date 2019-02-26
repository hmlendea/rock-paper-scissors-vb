Imports System.IO

Module Module_Scores

    Public Score_Wins As Integer
    Public Score_Loses As Integer
    Public Score_Wins_Total As Integer
    Public Score_Loses_Total As Integer

    Public File_Stats As String = "score.sav"

    Public Sub SaveScores()
        Dim Phase As String = "deleting the old file!"

        If File.Exists(File_Stats) Then File.Delete(File_Stats)

        Try
            Phase = "creating the file!"

            Dim StreamWriter As New StreamWriter(File_Stats)

            Phase = "writing data to file!"

            StreamWriter.WriteLine(Score_Wins_Total)
            StreamWriter.WriteLine(Score_Loses_Total)

            Phase = "closing the file!"

            StreamWriter.Close()
            StreamWriter.Dispose()

        Catch ErrorSavingFile As Exception
            MsgBox("Error saving '" & File_Stats & "', while " & Phase, MsgBoxStyle.Critical, "Error!")

            If File.Exists(File_Stats) Then File.Delete(File_Stats)
        End Try
    End Sub

    Public Sub LoadScores()
        'Dim Line As String

        Dim Phase As String = "accessing the file!"
        Try
            Dim StreamReader As New StreamReader(File_Stats)

            Phase = "collecting data from file!"

            ' = StreamReader.ReadLine
            Score_Wins_Total = CInt(StreamReader.ReadLine)
            Score_Loses_Total = CInt(StreamReader.ReadLine)

            Phase = "applying data from file!"

            Form_Main.Label_Wins.Text = "Wins: " & Score_Wins
            Form_Main.Label_Wins_Total.Text = "Total Wins: " & Score_Wins_Total
            Form_Main.Label_Loses.Text = "Loses: " & Score_Loses
            Form_Main.Label_Loses_Total.Text = "Total Loses: " & Score_Loses_Total

            StreamReader.Close()
            StreamReader.Dispose()

        Catch ErrorOpeningFile As Exception
            Dim MsgBox_StreamReaderError = MsgBox("Your score file is missing or corrupt! A new one was created." & vbNewLine & vbNewLine & "Error in '" & File_Stats & "' while " & Phase, MsgBoxStyle.Critical, "Error!")

            If File.Exists(File_Stats) Then
                File.Delete(File_Stats)
            End If
            SaveScores()
        End Try
    End Sub
End Module
