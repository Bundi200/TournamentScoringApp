Public Class frmTeamScoreEntry
    Public mainMenuScreen As frmMainMenu

    'Loading the database
    Private Sub frmTeamScoreEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Its a button and its redirect the user to main menu
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Hide()
        mainMenuScreen.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Save Team 1 event scores to main menu database
        frmMainMenu.teamEventScores(0, 0) = txtTeam1Event1Score.Text
        frmMainMenu.teamEventScores(0, 1) = txtTeam1Event2Score.Text
        frmMainMenu.teamEventScores(0, 2) = txtTeam1Event3Score.Text
        frmMainMenu.teamEventScores(0, 3) = txtTeam1Event4Score.Text
        frmMainMenu.teamEventScores(0, 4) = txtTeam1Event5Score.Text

        ' Save Team 2 event scores to main menu database
        frmMainMenu.teamEventScores(1, 0) = txtTeam2Event1Score.Text
        frmMainMenu.teamEventScores(1, 1) = txtTeam2Event2Score.Text
        frmMainMenu.teamEventScores(1, 2) = txtTeam2Event3Score.Text
        frmMainMenu.teamEventScores(1, 3) = txtTeam2Event4Score.Text
        frmMainMenu.teamEventScores(1, 4) = txtTeam2Event5Score.Text

        ' Save Team 3 event scores to main menu database
        frmMainMenu.teamEventScores(2, 0) = txtTeam3Event1Score.Text
        frmMainMenu.teamEventScores(2, 1) = txtTeam3Event2Score.Text
        frmMainMenu.teamEventScores(2, 2) = txtTeam3Event3Score.Text
        frmMainMenu.teamEventScores(2, 3) = txtTeam3Event4Score.Text
        frmMainMenu.teamEventScores(2, 4) = txtTeam3Event5Score.Text

        ' Save Team 4 event scores to main menu database
        frmMainMenu.teamEventScores(3, 0) = txtTeam4Event1Score.Text
        frmMainMenu.teamEventScores(3, 1) = txtTeam4Event2Score.Text
        frmMainMenu.teamEventScores(3, 2) = txtTeam4Event3Score.Text
        frmMainMenu.teamEventScores(3, 3) = txtTeam4Event4Score.Text
        frmMainMenu.teamEventScores(3, 4) = txtTeam4Event5Score.Text
    End Sub

    Public Sub PrepareScreen()
        'Prepareing the screen to load the data that has been saved before, after revisiting the screen
        txtTeam1.Text = frmMainMenu.teams(0)
        txtTeam1Event1Score.Text = frmMainMenu.teamEventScores(0, 0)
        txtTeam1Event2Score.Text = frmMainMenu.teamEventScores(0, 1)
        txtTeam1Event3Score.Text = frmMainMenu.teamEventScores(0, 2)
        txtTeam1Event4Score.Text = frmMainMenu.teamEventScores(0, 3)
        txtTeam1Event5Score.Text = frmMainMenu.teamEventScores(0, 4)

        txtTeam2.Text = frmMainMenu.teams(1)
        txtTeam2Event1Score.Text = frmMainMenu.teamEventScores(1, 0)
        txtTeam2Event2Score.Text = frmMainMenu.teamEventScores(1, 1)
        txtTeam2Event3Score.Text = frmMainMenu.teamEventScores(1, 2)
        txtTeam2Event4Score.Text = frmMainMenu.teamEventScores(1, 3)
        txtTeam2Event5Score.Text = frmMainMenu.teamEventScores(1, 4)

        txtTeam3.Text = frmMainMenu.teams(2)
        txtTeam3Event1Score.Text = frmMainMenu.teamEventScores(2, 0)
        txtTeam3Event2Score.Text = frmMainMenu.teamEventScores(2, 1)
        txtTeam3Event3Score.Text = frmMainMenu.teamEventScores(2, 2)
        txtTeam3Event4Score.Text = frmMainMenu.teamEventScores(2, 3)
        txtTeam3Event5Score.Text = frmMainMenu.teamEventScores(2, 4)

        txtTeam4.Text = frmMainMenu.teams(3)
        txtTeam4Event1Score.Text = frmMainMenu.teamEventScores(3, 0)
        txtTeam4Event2Score.Text = frmMainMenu.teamEventScores(3, 1)
        txtTeam4Event3Score.Text = frmMainMenu.teamEventScores(3, 2)
        txtTeam4Event4Score.Text = frmMainMenu.teamEventScores(3, 3)
        txtTeam4Event5Score.Text = frmMainMenu.teamEventScores(3, 4)
    End Sub
End Class