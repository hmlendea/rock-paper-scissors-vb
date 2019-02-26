Module Module_Engine

    Public Function Random(ByVal Min As Integer, ByVal Max As Integer)
        Dim Number As Integer = Int((Max - Min + 1) * Rnd()) + Min
        Return Number
    End Function

    Public Choice_Image As Image() = {My.Resources.Image_Choice_Rock, My.Resources.Image_Choice_Paper, My.Resources.Image_Choice_Scissors, My.Resources.Image_Choice_Trollface}

    Public Choice_Player1 As Integer
    Public Choice_Player2 As Integer

    Public Sub Win()
        MsgBox("YOU WON!", MsgBoxStyle.Exclamation, "You won")
        Score_Wins += 1
        Score_Wins_Total += 1
        Form_Main.Label_Wins.Text = "Wins: " & Score_Wins
        Form_Main.Label_Wins_Total.Text = "Total Wins: " & Score_Wins_Total
    End Sub

    Public Sub Lose()
        MsgBox("YOU LOST!", MsgBoxStyle.Critical, "You lost")
        Score_Loses += 1
        Score_Loses_Total += 1
        Form_Main.Label_Loses.Text = "Loses: " & Score_Loses
        Form_Main.Label_Loses_Total.Text = "Total Loses: " & Score_Loses_Total
    End Sub

    Public Sub Draw()
        MsgBox("ROUND DRAW!", MsgBoxStyle.OkOnly, "Draw")
    End Sub

    Public Sub Troll()
        MsgBox("You sir..." & vbNewLine & "just got TROLLED !!! xD", MsgBoxStyle.OkOnly, "U mad bro? xD")
    End Sub

    Public Sub GO()
        Choice_Player2 = Random(0, 2)
        If Random(1, 100) <= 5 Then Choice_Player2 = 3
        Form_Main.PictureBox_Player2.Image = Choice_Image(Choice_Player2)

        If Choice_Player1 = 0 Then
            '===' If Rock vs *
            If Choice_Player2 = 0 Then Draw()
            If Choice_Player2 = 1 Then Lose()
            If Choice_Player2 = 2 Then Win()
            If Choice_Player2 = 3 Then Troll()

        ElseIf Choice_Player1 = 1 Then
            '===' If Paper vs *
            If Choice_Player2 = 0 Then Win()
            If Choice_Player2 = 1 Then Draw()
            If Choice_Player2 = 2 Then Lose()
            If Choice_Player2 = 3 Then Troll()

        ElseIf Choice_Player1 = 2 Then
            '===' If Scissors vs *
            If Choice_Player2 = 0 Then Lose()
            If Choice_Player2 = 1 Then Win()
            If Choice_Player2 = 2 Then Draw()
            If Choice_Player2 = 3 Then Troll()

        End If
    End Sub
End Module
