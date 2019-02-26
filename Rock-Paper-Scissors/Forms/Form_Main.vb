Public Class Form_Main

    Private Sub Button_Rock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Rock.Click
        Choice_Player1 = 0

        PictureBox_Player1.Image = Choice_Image(Choice_Player1)
        GO()
        PictureBox_Player1.Image = My.Resources.Image_Choice_None
        PictureBox_Player2.Image = My.Resources.Image_Choice_None
    End Sub

    Private Sub Button_Paper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Paper.Click
        Choice_Player1 = 1

        PictureBox_Player1.Image = Choice_Image(Choice_Player1)
        GO()
        PictureBox_Player1.Image = My.Resources.Image_Choice_None
        PictureBox_Player2.Image = My.Resources.Image_Choice_None
    End Sub

    Private Sub Button_Scissors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Scissors.Click
        Choice_Player1 = 2

        PictureBox_Player1.Image = Choice_Image(Choice_Player1)
        GO()
        PictureBox_Player1.Image = My.Resources.Image_Choice_None
        PictureBox_Player2.Image = My.Resources.Image_Choice_None
    End Sub

    Private Sub Form_Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadScores()
    End Sub

    Private Sub Form_Main_Unload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        SaveScores()
    End Sub

    Private Sub Button_Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Reset.Click
        Dim Approval = MsgBox("Are you sure you want to reset your Score? This cannot be undone.", vbYesNo, "Are you sure?")
        If Approval = vbYes Then
            Score_Wins = 0
            Score_Wins_Total = 0
            Score_Loses = 0
            Score_Loses_Total = 0
            SaveScores()
            LoadScores()
        End If
    End Sub
End Class
