<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.btnTeamEntry = New System.Windows.Forms.Button()
        Me.btnSoloEntry = New System.Windows.Forms.Button()
        Me.btnTeamScoreEntry = New System.Windows.Forms.Button()
        Me.btnSoloScoreEntry = New System.Windows.Forms.Button()
        Me.btnTeamLeaderboard = New System.Windows.Forms.Button()
        Me.btnSoloLeaderboard = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTeamEntry
        '
        Me.btnTeamEntry.BackgroundImage = CType(resources.GetObject("btnTeamEntry.BackgroundImage"), System.Drawing.Image)
        Me.btnTeamEntry.Location = New System.Drawing.Point(75, 141)
        Me.btnTeamEntry.Name = "btnTeamEntry"
        Me.btnTeamEntry.Size = New System.Drawing.Size(136, 54)
        Me.btnTeamEntry.TabIndex = 1
        Me.btnTeamEntry.Text = "Team Entry"
        Me.btnTeamEntry.UseVisualStyleBackColor = True
        '
        'btnSoloEntry
        '
        Me.btnSoloEntry.BackgroundImage = CType(resources.GetObject("btnSoloEntry.BackgroundImage"), System.Drawing.Image)
        Me.btnSoloEntry.Location = New System.Drawing.Point(583, 141)
        Me.btnSoloEntry.Name = "btnSoloEntry"
        Me.btnSoloEntry.Size = New System.Drawing.Size(136, 54)
        Me.btnSoloEntry.TabIndex = 2
        Me.btnSoloEntry.Text = "Solo Entry"
        Me.btnSoloEntry.UseVisualStyleBackColor = True
        '
        'btnTeamScoreEntry
        '
        Me.btnTeamScoreEntry.BackgroundImage = CType(resources.GetObject("btnTeamScoreEntry.BackgroundImage"), System.Drawing.Image)
        Me.btnTeamScoreEntry.Location = New System.Drawing.Point(11, 229)
        Me.btnTeamScoreEntry.Name = "btnTeamScoreEntry"
        Me.btnTeamScoreEntry.Size = New System.Drawing.Size(136, 54)
        Me.btnTeamScoreEntry.TabIndex = 3
        Me.btnTeamScoreEntry.Text = "Team Score Entry"
        Me.btnTeamScoreEntry.UseVisualStyleBackColor = True
        '
        'btnSoloScoreEntry
        '
        Me.btnSoloScoreEntry.BackgroundImage = CType(resources.GetObject("btnSoloScoreEntry.BackgroundImage"), System.Drawing.Image)
        Me.btnSoloScoreEntry.Location = New System.Drawing.Point(651, 229)
        Me.btnSoloScoreEntry.Name = "btnSoloScoreEntry"
        Me.btnSoloScoreEntry.Size = New System.Drawing.Size(136, 54)
        Me.btnSoloScoreEntry.TabIndex = 4
        Me.btnSoloScoreEntry.Text = "Solo Score Entry"
        Me.btnSoloScoreEntry.UseVisualStyleBackColor = True
        '
        'btnTeamLeaderboard
        '
        Me.btnTeamLeaderboard.BackgroundImage = CType(resources.GetObject("btnTeamLeaderboard.BackgroundImage"), System.Drawing.Image)
        Me.btnTeamLeaderboard.Location = New System.Drawing.Point(75, 325)
        Me.btnTeamLeaderboard.Name = "btnTeamLeaderboard"
        Me.btnTeamLeaderboard.Size = New System.Drawing.Size(136, 54)
        Me.btnTeamLeaderboard.TabIndex = 5
        Me.btnTeamLeaderboard.Text = "Team Leaderboard"
        Me.btnTeamLeaderboard.UseVisualStyleBackColor = True
        '
        'btnSoloLeaderboard
        '
        Me.btnSoloLeaderboard.BackgroundImage = CType(resources.GetObject("btnSoloLeaderboard.BackgroundImage"), System.Drawing.Image)
        Me.btnSoloLeaderboard.Location = New System.Drawing.Point(583, 325)
        Me.btnSoloLeaderboard.Name = "btnSoloLeaderboard"
        Me.btnSoloLeaderboard.Size = New System.Drawing.Size(136, 54)
        Me.btnSoloLeaderboard.TabIndex = 6
        Me.btnSoloLeaderboard.Text = "Solo Leaderboard"
        Me.btnSoloLeaderboard.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(98, -59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(602, 159)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(805, 451)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSoloLeaderboard)
        Me.Controls.Add(Me.btnTeamLeaderboard)
        Me.Controls.Add(Me.btnSoloScoreEntry)
        Me.Controls.Add(Me.btnTeamScoreEntry)
        Me.Controls.Add(Me.btnSoloEntry)
        Me.Controls.Add(Me.btnTeamEntry)
        Me.Controls.Add(Me.PictureBox2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(816, 489)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(816, 489)
        Me.Name = "frmMainMenu"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tournament Scoring App - Main Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnTeamEntry As Button
    Friend WithEvents btnSoloEntry As Button
    Friend WithEvents btnTeamScoreEntry As Button
    Friend WithEvents btnSoloScoreEntry As Button
    Friend WithEvents btnTeamLeaderboard As Button
    Friend WithEvents btnSoloLeaderboard As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
