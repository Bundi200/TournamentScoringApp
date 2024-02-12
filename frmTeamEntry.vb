Public Class frmTeamEntry
    Public mainMenuScreen As frmMainMenu

    'Loading the database
    Private Sub frmTeamEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Its a button and its redirect the user to main menu
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Hide()
        mainMenuScreen.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Save Team 1 form data to main menu database
        frmMainMenu.teams(0) = txtTeam1.Text
        frmMainMenu.teamMembers(0, 0) = txtTeam1Member1.Text
        frmMainMenu.teamMembers(0, 1) = txtTeam1Member2.Text
        frmMainMenu.teamMembers(0, 2) = txtTeam1Member3.Text
        frmMainMenu.teamMembers(0, 3) = txtTeam1Member4.Text
        frmMainMenu.teamMembers(0, 4) = txtTeam1Member5.Text

        ' Save Team 2 form data to main menu database
        frmMainMenu.teams(1) = txtTeam2.Text
        frmMainMenu.teamMembers(1, 0) = txtTeam2Member1.Text
        frmMainMenu.teamMembers(1, 1) = txtTeam2Member2.Text
        frmMainMenu.teamMembers(1, 2) = txtTeam2Member3.Text
        frmMainMenu.teamMembers(1, 3) = txtTeam2Member4.Text
        frmMainMenu.teamMembers(1, 4) = txtTeam2Member5.Text

        ' Save Team 3 form data to main menu database
        frmMainMenu.teams(2) = txtTeam3.Text
        frmMainMenu.teamMembers(2, 0) = txtTeam3Member1.Text
        frmMainMenu.teamMembers(2, 1) = txtTeam3Member2.Text
        frmMainMenu.teamMembers(2, 2) = txtTeam3Member3.Text
        frmMainMenu.teamMembers(2, 3) = txtTeam3Member4.Text
        frmMainMenu.teamMembers(2, 4) = txtTeam3Member5.Text

        ' Save Team 4 form data to main menu database
        frmMainMenu.teams(3) = txtTeam4.Text
        frmMainMenu.teamMembers(3, 0) = txtTeam4Member1.Text
        frmMainMenu.teamMembers(3, 1) = txtTeam4Member2.Text
        frmMainMenu.teamMembers(3, 2) = txtTeam4Member3.Text
        frmMainMenu.teamMembers(3, 3) = txtTeam4Member4.Text
        frmMainMenu.teamMembers(3, 4) = txtTeam4Member5.Text
    End Sub

    Public Sub PrepareScreen()
        'Prepareing the screen to load the data that has been saved before, after revisiting the screen
        txtTeam1.Text = frmMainMenu.teams(0)
        txtTeam1Member1.Text = frmMainMenu.teamMembers(0, 0)
        txtTeam1Member2.Text = frmMainMenu.teamMembers(0, 1)
        txtTeam1Member3.Text = frmMainMenu.teamMembers(0, 2)
        txtTeam1Member4.Text = frmMainMenu.teamMembers(0, 3)
        txtTeam1Member5.Text = frmMainMenu.teamMembers(0, 4)

        txtTeam2.Text = frmMainMenu.teams(1)
        txtTeam2Member1.Text = frmMainMenu.teamMembers(1, 0)
        txtTeam2Member2.Text = frmMainMenu.teamMembers(1, 1)
        txtTeam2Member3.Text = frmMainMenu.teamMembers(1, 2)
        txtTeam2Member4.Text = frmMainMenu.teamMembers(1, 3)
        txtTeam2Member5.Text = frmMainMenu.teamMembers(1, 4)

        txtTeam3.Text = frmMainMenu.teams(2)
        txtTeam3Member1.Text = frmMainMenu.teamMembers(2, 0)
        txtTeam3Member2.Text = frmMainMenu.teamMembers(2, 1)
        txtTeam3Member3.Text = frmMainMenu.teamMembers(2, 2)
        txtTeam3Member4.Text = frmMainMenu.teamMembers(2, 3)
        txtTeam3Member5.Text = frmMainMenu.teamMembers(2, 4)

        txtTeam4.Text = frmMainMenu.teams(3)
        txtTeam4Member1.Text = frmMainMenu.teamMembers(3, 0)
        txtTeam4Member2.Text = frmMainMenu.teamMembers(3, 1)
        txtTeam4Member3.Text = frmMainMenu.teamMembers(3, 2)
        txtTeam4Member4.Text = frmMainMenu.teamMembers(3, 3)
        txtTeam4Member5.Text = frmMainMenu.teamMembers(3, 4)
    End Sub
End Class