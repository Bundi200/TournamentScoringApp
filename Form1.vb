Public Class frmMainMenu
    'This is the veriables for loading the screens (Declaring screen veriables)
    Dim teamEntryScreen As New frmTeamEntry
    Dim teamScoreEntryScreen As New frmTeamScoreEntry
    Dim teamLeaderboardScreen As New frmTeamLeaderboard
    Dim soloEntryScreen As New frmSoloEntry
    Dim soloScoreEntryScreen As New frmSoloScoreEntry
    Dim soloLeaderboardScreen As New frmSoloLeaderboard

    'This is the prelocated number of teams and solo players (Declaring as arrays in 1 dimensional and 2 dimensional array)
    Public teams(3) As String '1 dimensional array for teams name
    Public teamMembers(3, 4) As String '2 dimensional array for team members in each team
    Public teamEventScores(3, 4) As Integer

    Public soloPlayers(19) As String
    Public soloEventsEntered(19, 4) As Boolean
    Public soloEventScores(19, 4) As Integer

    'this methad start the program inside the new screen
    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Information for the new screen on how to access the main menu
        teamEntryScreen.mainMenuScreen = Me
        teamScoreEntryScreen.mainMenuScreen = Me
        teamLeaderboardScreen.mainMenuScreen = Me
        soloEntryScreen.mainMenuScreen = Me
        soloScoreEntryScreen.mainMenuScreen = Me
        soloLeaderboardScreen.mainMenuScreen = Me

        'Giving a default value to each team when the screen will load
        teams(0) = "Team 1"
        teams(1) = "Team 2"
        teams(2) = "Team 3"
        teams(3) = "Team 4"

        'Giving value/options in the combo box for example "Player 1" to "Player 20"
        Dim playerIndex As Integer 'Local veriable

        For playerIndex = 0 To 19 'Giving a range value
            soloPlayers(playerIndex) = "Player " & (playerIndex + 1) 'setting each value with "Player" and a number next to it
        Next
    End Sub

    'When the button have been pressed the main menu will hide and the new screen will appear depands on with button have been selected
    Private Sub btnTeamEntry_Click(sender As Object, e As EventArgs) Handles btnTeamEntry.Click
        Me.Hide()
        teamEntryScreen.PrepareScreen()
        teamEntryScreen.Show()
    End Sub

    Private Sub btnTeamScoreEntry_Click(sender As Object, e As EventArgs) Handles btnTeamScoreEntry.Click
        Me.Hide()
        teamScoreEntryScreen.PrepareScreen()
        teamScoreEntryScreen.Show()
    End Sub

    Private Sub btnTeamLeaderboard_Click(sender As Object, e As EventArgs) Handles btnTeamLeaderboard.Click
        Me.Hide()
        teamLeaderboardScreen.PrepareScreen()
        teamLeaderboardScreen.Show()
    End Sub

    Private Sub btnSoloEntry_Click(sender As Object, e As EventArgs) Handles btnSoloEntry.Click
        Me.Hide()
        soloEntryScreen.PrepareScreen()
        soloEntryScreen.Show()
    End Sub

    Private Sub btnSoloScoreEntry_Click(sender As Object, e As EventArgs) Handles btnSoloScoreEntry.Click
        Me.Hide()
        soloScoreEntryScreen.PrepareScreen()
        soloScoreEntryScreen.Show()
    End Sub

    Private Sub btnSoloLeaderboard_Click(sender As Object, e As EventArgs) Handles btnSoloLeaderboard.Click
        Me.Hide()
        soloLeaderboardScreen.PrepareScreen()
        soloLeaderboardScreen.Show()
    End Sub
End Class
