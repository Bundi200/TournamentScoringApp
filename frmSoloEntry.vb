Imports System.Runtime

Public Class frmSoloEntry
    Public mainMenuScreen As frmMainMenu
    Private selectedPlayerIndex As Integer
    Private selectedPlayerName As String

    'Loading the database
    Private Sub frmSoloEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Its a button and its redirect the user to main menu
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Hide()
        mainMenuScreen.Show()
    End Sub

    'Saving the check boxs in each player
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        frmMainMenu.soloPlayers(selectedPlayerIndex) = txtPlayerName.Text
        frmMainMenu.soloEventsEntered(selectedPlayerIndex, 0) = chkEvent1.Checked
        frmMainMenu.soloEventsEntered(selectedPlayerIndex, 1) = chkEvent2.Checked
        frmMainMenu.soloEventsEntered(selectedPlayerIndex, 2) = chkEvent3.Checked
        frmMainMenu.soloEventsEntered(selectedPlayerIndex, 3) = chkEvent4.Checked
        frmMainMenu.soloEventsEntered(selectedPlayerIndex, 4) = chkEvent5.Checked
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
    'Updating the text boxes
    Private Sub UpdateSelectedPlayerScreenData(playerID As Integer)

        'Selecting the player
        selectedPlayerIndex = playerID
        selectedPlayerName = frmMainMenu.soloPlayers(selectedPlayerIndex)
        txtPlayerName.Text = selectedPlayerName

        'Checking if the box is ticked and updating to the database
        chkEvent1.Checked = frmMainMenu.soloEventsEntered(selectedPlayerIndex, 0)
        chkEvent2.Checked = frmMainMenu.soloEventsEntered(selectedPlayerIndex, 1)
        chkEvent3.Checked = frmMainMenu.soloEventsEntered(selectedPlayerIndex, 2)
        chkEvent4.Checked = frmMainMenu.soloEventsEntered(selectedPlayerIndex, 3)
        chkEvent5.Checked = frmMainMenu.soloEventsEntered(selectedPlayerIndex, 4)
    End Sub
End Class