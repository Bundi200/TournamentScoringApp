Public Class frmTeamLeaderboard


    Public mainMenuScreen As frmMainMenu

    Private teamTotalScore(3, 1) As Integer

    'Loading the database
    Private Sub frmTeamLeaderboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Its a button and its redirect the user to main menu
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Hide()
        mainMenuScreen.Show()
    End Sub
    'Prepare the screens before loaded
    Public Sub PrepareScreen()
        'Functions
        TotalTeamScores()
        RankTeams()
        DisplayResults()
    End Sub

    'Adding the team scores in each events
    Private Sub TotalTeamScores()
        Dim teamIndex As Integer

        'Its a loop that individualy adding the value for each team
        For teamIndex = 0 To 3 '
            teamTotalScore(teamIndex, 0) = teamIndex 'Describing with team is it
            teamTotalScore(teamIndex, 1) = frmMainMenu.teamEventScores(teamIndex, 0) 'Adding the first event to the default value that is 0
            teamTotalScore(teamIndex, 1) += frmMainMenu.teamEventScores(teamIndex, 1) 'Adding the first and second event
            teamTotalScore(teamIndex, 1) += frmMainMenu.teamEventScores(teamIndex, 2) 'Adding the second to third
            teamTotalScore(teamIndex, 1) += frmMainMenu.teamEventScores(teamIndex, 3) 'adding third to fourth
            teamTotalScore(teamIndex, 1) += frmMainMenu.teamEventScores(teamIndex, 4) 'adding fourth to fifth
        Next
    End Sub

    Private Sub RankTeams()
        'variables
        Dim teamIndex As Integer
        Dim iterations As Integer

        'Re-orgenasing the table to be in order
        For iterations = 0 To 2 'Looping 3 times
            For teamIndex = 0 To (2 - iterations) '
                If (teamTotalScore(teamIndex, 1) < teamTotalScore(teamIndex + 1, 1)) Then 'Comparing the 2 rows
                    'storing a copy of the score for the teams
                    Dim teamID As Integer = teamTotalScore(teamIndex, 0)
                    Dim teamScore As Integer = teamTotalScore(teamIndex, 1)

                    'if the first row is higher then the second row it will switch around but if not then stay the same way
                    teamTotalScore(teamIndex, 0) = teamTotalScore(teamIndex + 1, 0)
                    teamTotalScore(teamIndex, 1) = teamTotalScore(teamIndex + 1, 1)

                    teamTotalScore(teamIndex + 1, 0) = teamID
                    teamTotalScore(teamIndex + 1, 1) = teamScore
                End If
            Next
        Next
    End Sub

    'Displaying the value to the table
    Private Sub DisplayResults()
        Dim teamIndex As Integer 'represent each team with a index no.

        'nameing each text and adding spaces between each other with "tabs"
        txtTeamLeaderboard.Text = "Rank" & vbTab
        txtTeamLeaderboard.Text += "Score" & vbTab
        txtTeamLeaderboard.Text += "Team ID" & vbTab
        txtTeamLeaderboard.Text += "Team" & vbCrLf

        Dim rank As Integer = 1 '

        'displaying the score in order and ranks to each team in a loop
        For teamIndex = 0 To 3
            txtTeamLeaderboard.Text += rank & vbTab
            txtTeamLeaderboard.Text += teamTotalScore(teamIndex, 1) & vbTab
            txtTeamLeaderboard.Text += (teamTotalScore(teamIndex, 0) + 1) & vbTab
            txtTeamLeaderboard.Text += frmMainMenu.teams(teamTotalScore(teamIndex, 0)) & vbCrLf

            rank += 1 'adding the second rank
        Next
    End Sub
End Class