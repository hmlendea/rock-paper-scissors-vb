<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button_Rock = New System.Windows.Forms.Button()
        Me.Button_Paper = New System.Windows.Forms.Button()
        Me.Button_Scissors = New System.Windows.Forms.Button()
        Me.GroupBox_Player1Choice = New System.Windows.Forms.GroupBox()
        Me.GroupBox_Score = New System.Windows.Forms.GroupBox()
        Me.Button_Reset = New System.Windows.Forms.Button()
        Me.Label_Loses_Total = New System.Windows.Forms.Label()
        Me.Label_Wins_Total = New System.Windows.Forms.Label()
        Me.Label_Loses = New System.Windows.Forms.Label()
        Me.Label_Wins = New System.Windows.Forms.Label()
        Me.Label_VS = New System.Windows.Forms.Label()
        Me.Label_Credits = New System.Windows.Forms.Label()
        Me.PictureBox_Player2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Player1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox_Player1Choice.SuspendLayout()
        Me.GroupBox_Score.SuspendLayout()
        CType(Me.PictureBox_Player2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Player1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Rock
        '
        Me.Button_Rock.Location = New System.Drawing.Point(7, 19)
        Me.Button_Rock.Name = "Button_Rock"
        Me.Button_Rock.Size = New System.Drawing.Size(54, 23)
        Me.Button_Rock.TabIndex = 1
        Me.Button_Rock.Text = "Rock"
        Me.Button_Rock.UseVisualStyleBackColor = True
        '
        'Button_Paper
        '
        Me.Button_Paper.Location = New System.Drawing.Point(67, 19)
        Me.Button_Paper.Name = "Button_Paper"
        Me.Button_Paper.Size = New System.Drawing.Size(54, 23)
        Me.Button_Paper.TabIndex = 2
        Me.Button_Paper.Text = "Paper"
        Me.Button_Paper.UseVisualStyleBackColor = True
        '
        'Button_Scissors
        '
        Me.Button_Scissors.Location = New System.Drawing.Point(127, 19)
        Me.Button_Scissors.Name = "Button_Scissors"
        Me.Button_Scissors.Size = New System.Drawing.Size(54, 23)
        Me.Button_Scissors.TabIndex = 3
        Me.Button_Scissors.Text = "Scissors"
        Me.Button_Scissors.UseVisualStyleBackColor = True
        '
        'GroupBox_Player1Choice
        '
        Me.GroupBox_Player1Choice.Controls.Add(Me.Button_Rock)
        Me.GroupBox_Player1Choice.Controls.Add(Me.Button_Paper)
        Me.GroupBox_Player1Choice.Controls.Add(Me.Button_Scissors)
        Me.GroupBox_Player1Choice.Location = New System.Drawing.Point(15, 184)
        Me.GroupBox_Player1Choice.Name = "GroupBox_Player1Choice"
        Me.GroupBox_Player1Choice.Size = New System.Drawing.Size(186, 48)
        Me.GroupBox_Player1Choice.TabIndex = 8
        Me.GroupBox_Player1Choice.TabStop = False
        Me.GroupBox_Player1Choice.Text = "Your Choice"
        '
        'GroupBox_Score
        '
        Me.GroupBox_Score.Controls.Add(Me.Button_Reset)
        Me.GroupBox_Score.Controls.Add(Me.Label_Loses_Total)
        Me.GroupBox_Score.Controls.Add(Me.Label_Wins_Total)
        Me.GroupBox_Score.Controls.Add(Me.Label_Loses)
        Me.GroupBox_Score.Controls.Add(Me.Label_Wins)
        Me.GroupBox_Score.Location = New System.Drawing.Point(207, 184)
        Me.GroupBox_Score.Name = "GroupBox_Score"
        Me.GroupBox_Score.Size = New System.Drawing.Size(259, 48)
        Me.GroupBox_Score.TabIndex = 9
        Me.GroupBox_Score.TabStop = False
        Me.GroupBox_Score.Text = "Score"
        '
        'Button_Reset
        '
        Me.Button_Reset.Location = New System.Drawing.Point(178, 19)
        Me.Button_Reset.Name = "Button_Reset"
        Me.Button_Reset.Size = New System.Drawing.Size(75, 23)
        Me.Button_Reset.TabIndex = 4
        Me.Button_Reset.Text = "Reset Score"
        Me.Button_Reset.UseVisualStyleBackColor = True
        '
        'Label_Loses_Total
        '
        Me.Label_Loses_Total.AutoSize = True
        Me.Label_Loses_Total.Location = New System.Drawing.Point(78, 29)
        Me.Label_Loses_Total.Name = "Label_Loses_Total"
        Me.Label_Loses_Total.Size = New System.Drawing.Size(74, 13)
        Me.Label_Loses_Total.TabIndex = 3
        Me.Label_Loses_Total.Text = "Total Loses: 0"
        '
        'Label_Wins_Total
        '
        Me.Label_Wins_Total.AutoSize = True
        Me.Label_Wins_Total.Location = New System.Drawing.Point(78, 16)
        Me.Label_Wins_Total.Name = "Label_Wins_Total"
        Me.Label_Wins_Total.Size = New System.Drawing.Size(70, 13)
        Me.Label_Wins_Total.TabIndex = 2
        Me.Label_Wins_Total.Text = "Total Wins: 0"
        '
        'Label_Loses
        '
        Me.Label_Loses.AutoSize = True
        Me.Label_Loses.Location = New System.Drawing.Point(7, 29)
        Me.Label_Loses.Name = "Label_Loses"
        Me.Label_Loses.Size = New System.Drawing.Size(47, 13)
        Me.Label_Loses.TabIndex = 1
        Me.Label_Loses.Text = "Loses: 0"
        '
        'Label_Wins
        '
        Me.Label_Wins.AutoSize = True
        Me.Label_Wins.Location = New System.Drawing.Point(7, 16)
        Me.Label_Wins.Name = "Label_Wins"
        Me.Label_Wins.Size = New System.Drawing.Size(43, 13)
        Me.Label_Wins.TabIndex = 0
        Me.Label_Wins.Text = "Wins: 0"
        '
        'Label_VS
        '
        Me.Label_VS.AutoSize = True
        Me.Label_VS.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_VS.Location = New System.Drawing.Point(218, 76)
        Me.Label_VS.Name = "Label_VS"
        Me.Label_VS.Size = New System.Drawing.Size(44, 31)
        Me.Label_VS.TabIndex = 10
        Me.Label_VS.Text = "vs"
        '
        'Label_Credits
        '
        Me.Label_Credits.AutoSize = True
        Me.Label_Credits.Location = New System.Drawing.Point(195, 240)
        Me.Label_Credits.Name = "Label_Credits"
        Me.Label_Credits.Size = New System.Drawing.Size(86, 13)
        Me.Label_Credits.TabIndex = 13
        Me.Label_Credits.Text = "Made by hori873"
        '
        'PictureBox_Player2
        '
        Me.PictureBox_Player2.Image = Global.Rock_Paper_Scissors.My.Resources.Resources.Image_Choice_None
        Me.PictureBox_Player2.Location = New System.Drawing.Point(300, 4)
        Me.PictureBox_Player2.Name = "PictureBox_Player2"
        Me.PictureBox_Player2.Size = New System.Drawing.Size(174, 174)
        Me.PictureBox_Player2.TabIndex = 12
        Me.PictureBox_Player2.TabStop = False
        '
        'PictureBox_Player1
        '
        Me.PictureBox_Player1.Image = Global.Rock_Paper_Scissors.My.Resources.Resources.Image_Choice_None
        Me.PictureBox_Player1.Location = New System.Drawing.Point(6, 4)
        Me.PictureBox_Player1.Name = "PictureBox_Player1"
        Me.PictureBox_Player1.Size = New System.Drawing.Size(174, 174)
        Me.PictureBox_Player1.TabIndex = 11
        Me.PictureBox_Player1.TabStop = False
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 256)
        Me.Controls.Add(Me.Label_Credits)
        Me.Controls.Add(Me.PictureBox_Player2)
        Me.Controls.Add(Me.PictureBox_Player1)
        Me.Controls.Add(Me.Label_VS)
        Me.Controls.Add(Me.GroupBox_Score)
        Me.Controls.Add(Me.GroupBox_Player1Choice)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rock-Paper-Scissors"
        Me.GroupBox_Player1Choice.ResumeLayout(False)
        Me.GroupBox_Score.ResumeLayout(False)
        Me.GroupBox_Score.PerformLayout()
        CType(Me.PictureBox_Player2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Player1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_Rock As System.Windows.Forms.Button
    Friend WithEvents Button_Paper As System.Windows.Forms.Button
    Friend WithEvents Button_Scissors As System.Windows.Forms.Button
    Friend WithEvents GroupBox_Player1Choice As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox_Score As System.Windows.Forms.GroupBox
    Friend WithEvents Label_Loses As System.Windows.Forms.Label
    Friend WithEvents Label_Wins As System.Windows.Forms.Label
    Friend WithEvents Label_Loses_Total As System.Windows.Forms.Label
    Friend WithEvents Label_Wins_Total As System.Windows.Forms.Label
    Friend WithEvents Button_Reset As System.Windows.Forms.Button
    Friend WithEvents Label_VS As System.Windows.Forms.Label
    Friend WithEvents PictureBox_Player1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_Player2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label_Credits As System.Windows.Forms.Label

End Class
