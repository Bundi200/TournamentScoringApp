Public Class frmSoloScoreEntry
    Public mainMenuScreen As frmMainMenu
    Private selectedPlayerIndex As Integer
    Private selectedPlayerName As String

    'Loading the database
    Private Sub frmSoloScoreEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Its a button and its redirect the user to main menu
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Hide()
        mainMenuScreen.Show()
    End Sub

    'Saving the enabled text boxes
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        frmMainMenu.soloEventScores(selectedPlayerIndex, 0) = txtEvent1Score.Text
        frmMainMenu.soloEventScores(selectedPlayerIndex, 1) = txtEvent2Score.Text
        frmMainMenu.soloEventScores(selectedPlayerIndex, 2) = txtEvent3Score.Text
        frmMainMenu.soloEventScores(selectedPlayerIndex, 3) = txtEvent4Score.Text
        frmMainMenu.soloEventScores(selectedPlayerIndex, 4) = txtEvent5Score.Text
    End Sub

    'Adding values to combo box
    Public Sub PrepareScreen()
        cbxPlayerSelection.Items.Clear() 'When the player selected the check boxs are clear

        For playerIndex As Integer = 0 To 19 'Creating values ranging between 1 and 20
            cbxPlayerSelection.Items.Add("Player " & (playerIndex + 1)) 'Adding text/information to each value
        Next

        cbxPlayerSelection.SelectedIndex = 0
    End Sub

    'Its a updater for the combo box names and data inside
    Private Sub cbxPlayerSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPlayerSelection.SelectedIndexChanged
        UpdateSelectedPlayerScreenData(cbxPlayerSelection.SelectedIndex)
    End Sub


    Private Sub UpdateSelectedPlayerScreenData(playerID As Integer)
        'Selecting the player
        selectedPlayerIndex = playerID
        selectedPlayerName = frmMainMenu.soloPlayers(selectedPlayerIndex)
        txtPlayerName.Text = selectedPlayerName

        'Checking if the box is ticked and updating to the database
        txtEvent1Score.Text = frmMainMenu.soloEventScores(selectedPlayerIndex, 0)
        txtEvent2Score.Text = frmMainMenu.soloEventScores(selectedPlayerIndex, 1)
        txtEvent3Score.Text = frmMainMenu.soloEventScores(selectedPlayerIndex, 2)
        txtEvent4Score.Text = frmMainMenu.soloEventScores(selectedPlayerIndex, 3)
        txtEvent5Score.Text = frmMainMenu.soloEventScores(selectedPlayerIndex, 4)

        'If the check box was checked before then enable to edit the text box, if not disable the text box
        If (frmMainMenu.soloEventsEntered(selectedPlayerIndex, 0) = True) Then
            txtEvent1Score.Enabled = True 'If the check box was ticked make it editable
        Else
            txtEvent1Score.Enabled = False 'If not disable it
        End If

        If (frmMainMenu.soloEventsEntered(selectedPlayerIndex, 1) = True) Then
            txtEvent2Score.Enabled = True 'If the check box was ticked make it editable
        Else
            txtEvent2Score.Enabled = False 'If not disable it
        End If

        If (frmMainMenu.soloEventsEntered(selectedPlayerIndex, 2) = True) Then
            txtEvent3Score.Enabled = True 'If the check box was ticked make it editable
        Else
            txtEvent3Score.Enabled = False 'If not disable it
        End If

        If (frmMainMenu.soloEventsEntered(selectedPlayerIndex, 3) = True) Then
            txtEvent4Score.Enabled = True 'If the check box was ticked make it editable
        Else
            txtEvent4Score.Enabled = False 'If not disable it
        End If

        If (frmMainMenu.soloEventsEntered(selectedPlayerIndex, 4) = True) Then
            txtEvent5Score.Enabled = True 'If the check box was ticked make it editable
        Else
            txtEvent5Score.Enabled = False 'If not disable it
        End If
    End Sub
End Class