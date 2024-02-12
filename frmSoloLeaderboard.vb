Public Class frmSoloLeaderboard
    Public mainMenuScreen As frmMainMenu
    Private selectedEventIndex As Integer 'keep tract with event is selected by a combo box

    Private Structure SoloPlayer 'keep record of each player
        Public id As Integer
        Public score As Integer
    End Structure
    'Making arreys of individual players
    Private soloPlayersEvent1 As New List(Of SoloPlayer)
    Private soloPlayersEvent2 As New List(Of SoloPlayer)
    Private soloPlayersEvent3 As New List(Of SoloPlayer)
    Private soloPlayersEvent4 As New List(Of SoloPlayer)
    Private soloPlayersEvent5 As New List(Of SoloPlayer)
    'Setting all the players to each events
    Private soloEvent1Ranked() As SoloPlayer
    Private soloEvent2Ranked() As SoloPlayer
    Private soloEvent3Ranked() As SoloPlayer
    Private soloEvent4Ranked() As SoloPlayer
    Private soloEvent5Ranked() As SoloPlayer



    'Loading the database
    Private Sub frmSoloLeaderboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Its a button and its redirect the user to main menu
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Hide()
        mainMenuScreen.Show()
    End Sub

    Public Sub PrepareScreen()
        cbxEventSelection.Items.Clear()
        'Dim eventNumber As Integer


        cbxEventSelection.Items.Add("Tennis") ' Event 1
        cbxEventSelection.Items.Add("Badminton") ' Event 2
        cbxEventSelection.Items.Add("Boxing") ' Event 3
        cbxEventSelection.Items.Add("Ping Pong") ' Event 4
        cbxEventSelection.Items.Add("Cycling") ' Event 5

        'Envoking the two method from below
        CreateEventLists()
        RankEventLists()

        cbxEventSelection.SelectedIndex = 0 'trigger a event
    End Sub
    Private Sub CreateEventLists()
        soloPlayersEvent1.Clear()
        soloPlayersEvent2.Clear()
        soloPlayersEvent3.Clear()
        soloPlayersEvent4.Clear()
        soloPlayersEvent5.Clear()

        Dim playerIndex As Integer

        'Creating a loop for each player to set a ID and a score IDS
        For playerIndex = 0 To 19 'looping it 20 times
            If (frmMainMenu.soloEventsEntered(playerIndex, 0)) Then
                Dim currentPlayer As SoloPlayer 'putting the players inside a variable to be able to use it later

                currentPlayer.id = playerIndex 'setting a ID to a player
                currentPlayer.score = frmMainMenu.soloEventScores(playerIndex, 0) 'getting the score information from other form and assignt it to the variable
                soloPlayersEvent1.Add(currentPlayer) 'adding the player to the event


            End If

            If (frmMainMenu.soloEventsEntered(playerIndex, 1)) Then
                Dim currentPlayer As SoloPlayer

                currentPlayer.id = playerIndex
                currentPlayer.score = frmMainMenu.soloEventScores(playerIndex, 1)
                soloPlayersEvent2.Add(currentPlayer)


            End If

            If (frmMainMenu.soloEventsEntered(playerIndex, 2)) Then
                Dim currentPlayer As SoloPlayer

                currentPlayer.id = playerIndex
                currentPlayer.score = frmMainMenu.soloEventScores(playerIndex, 2)
                soloPlayersEvent3.Add(currentPlayer)


            End If

            If (frmMainMenu.soloEventsEntered(playerIndex, 3)) Then
                Dim currentPlayer As SoloPlayer

                currentPlayer.id = playerIndex
                currentPlayer.score = frmMainMenu.soloEventScores(playerIndex, 3)
                soloPlayersEvent4.Add(currentPlayer)


            End If

            If (frmMainMenu.soloEventsEntered(playerIndex, 4)) Then
                Dim currentPlayer As SoloPlayer

                currentPlayer.id = playerIndex
                currentPlayer.score = frmMainMenu.soloEventScores(playerIndex, 4)
                soloPlayersEvent5.Add(currentPlayer)


            End If
        Next



    End Sub

    Private Sub RankEventLists()
        'assigntning the information to a variable
        soloEvent1Ranked = soloPlayersEvent1.ToArray()
        soloEvent2Ranked = soloPlayersEvent2.ToArray()
        soloEvent3Ranked = soloPlayersEvent3.ToArray()
        soloEvent4Ranked = soloPlayersEvent4.ToArray()
        soloEvent5Ranked = soloPlayersEvent5.ToArray()

        'assignt the varible into the method parameter
        ProcessEventRanking(soloEvent1Ranked)
        ProcessEventRanking(soloEvent2Ranked)
        ProcessEventRanking(soloEvent3Ranked)
        ProcessEventRanking(soloEvent4Ranked)
        ProcessEventRanking(soloEvent5Ranked)




    End Sub
    Private Sub ProcessEventRanking(soloEvent() As SoloPlayer)
        Dim playerIndex As Integer
        Dim iterations As Integer

        For iterations = 0 To (soloEvent.Length - 2) 'we looping the whole fucntion 18 times becasue we have to do only 19 loops but the first player ID is 0
            For playerIndex = 0 To ((soloEvent.Length - 2) - iterations) 'each time a loop done we do one less loop
                If (soloEvent(playerIndex).score < soloEvent(playerIndex + 1).score) Then 'We comparing the a player with a the next player
                    'storing a copy of the player in each event
                    Dim playerID As Integer = soloEvent(playerIndex).id
                    Dim playerScore As Integer = soloEvent(playerIndex).score
                    'if the first row is higher then the second row it will switch them around but if not then stay the same way
                    soloEvent(playerIndex).id = soloEvent(playerIndex + 1).id
                    soloEvent(playerIndex).score = soloEvent(playerIndex + 1).score

                    soloEvent(playerIndex + 1).id = playerID
                    soloEvent(playerIndex + 1).score = playerScore
                End If
            Next

        Next

    End Sub

    Private Sub DisplayResults()
        'Making headings to each coloums
        txtSoloLeaderboard.Text = "Rank" & vbTab
        txtSoloLeaderboard.Text += "Score" & vbTab
        txtSoloLeaderboard.Text += "Player ID" & vbTab
        txtSoloLeaderboard.Text += "Player" & vbCrLf
        'currently selected event form drop down box
        Dim selectedEvent() As SoloPlayer

        'creating a select case statement to check with event number the user have put
        Select Case selectedEventIndex
            Case 0
                selectedEvent = soloEvent1Ranked
            Case 1
                selectedEvent = soloEvent2Ranked
            Case 2
                selectedEvent = soloEvent3Ranked
            Case 3
                selectedEvent = soloEvent4Ranked
            Case 4
                selectedEvent = soloEvent5Ranked
        End Select

        Dim rank As Integer = 1

        'displaying the ranks, player ID And scores next to the headings
        For Each player As SoloPlayer In selectedEvent
            txtSoloLeaderboard.Text += rank & vbTab
            txtSoloLeaderboard.Text += player.score & vbTab
            txtSoloLeaderboard.Text += (player.id + 1) & vbTab
            txtSoloLeaderboard.Text += frmMainMenu.soloPlayers(player.id) & vbCrLf

            rank += 1
        Next
    End Sub

    'Its a updater for the combo box names and data inside
    Private Sub cbxEventSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxEventSelection.SelectedIndexChanged
        UpdateSelectedEventScreenData(cbxEventSelection.SelectedIndex)
    End Sub

    'Updating the text boxes
    Private Sub UpdateSelectedEventScreenData(eventID As Integer)
        selectedEventIndex = eventID
        DisplayResults()
    End Sub
End Class