<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSoloScoreEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSoloScoreEntry))
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxPlayerSelection = New System.Windows.Forms.ComboBox()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.txtPlayerName = New System.Windows.Forms.TextBox()
        Me.txtEvent1Score = New System.Windows.Forms.TextBox()
        Me.txtEvent2Score = New System.Windows.Forms.TextBox()
        Me.txtEvent3Score = New System.Windows.Forms.TextBox()
        Me.txtEvent4Score = New System.Windows.Forms.TextBox()
        Me.txtEvent5Score = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Location = New System.Drawing.Point(295, 384)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(80, 23)
        Me.btnMainMenu.TabIndex = 2
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(446, 387)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(81, 22)
        Me.btnSave.TabIndex = 69
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(78, 126)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Player Select:"
        '
        'cbxPlayerSelection
        '
        Me.cbxPlayerSelection.FormattingEnabled = True
        Me.cbxPlayerSelection.Location = New System.Drawing.Point(78, 152)
        Me.cbxPlayerSelection.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cbxPlayerSelection.Name = "cbxPlayerSelection"
        Me.cbxPlayerSelection.Size = New System.Drawing.Size(132, 23)
        Me.cbxPlayerSelection.TabIndex = 67
        '
        'lblPlayerName
        '
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.ForeColor = System.Drawing.Color.White
        Me.lblPlayerName.Location = New System.Drawing.Point(293, 126)
        Me.lblPlayerName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(82, 15)
        Me.lblPlayerName.TabIndex = 71
        Me.lblPlayerName.Text = "Players Name:"
        '
        'txtPlayerName
        '
        Me.txtPlayerName.Enabled = False
        Me.txtPlayerName.Location = New System.Drawing.Point(293, 152)
        Me.txtPlayerName.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtPlayerName.Name = "txtPlayerName"
        Me.txtPlayerName.Size = New System.Drawing.Size(110, 23)
        Me.txtPlayerName.TabIndex = 70
        '
        'txtEvent1Score
        '
        Me.txtEvent1Score.Location = New System.Drawing.Point(588, 158)
        Me.txtEvent1Score.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtEvent1Score.Name = "txtEvent1Score"
        Me.txtEvent1Score.Size = New System.Drawing.Size(110, 23)
        Me.txtEvent1Score.TabIndex = 72
        '
        'txtEvent2Score
        '
        Me.txtEvent2Score.Location = New System.Drawing.Point(588, 192)
        Me.txtEvent2Score.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtEvent2Score.Name = "txtEvent2Score"
        Me.txtEvent2Score.Size = New System.Drawing.Size(110, 23)
        Me.txtEvent2Score.TabIndex = 73
        '
        'txtEvent3Score
        '
        Me.txtEvent3Score.Location = New System.Drawing.Point(588, 224)
        Me.txtEvent3Score.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtEvent3Score.Name = "txtEvent3Score"
        Me.txtEvent3Score.Size = New System.Drawing.Size(110, 23)
        Me.txtEvent3Score.TabIndex = 74
        '
        'txtEvent4Score
        '
        Me.txtEvent4Score.Location = New System.Drawing.Point(588, 257)
        Me.txtEvent4Score.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtEvent4Score.Name = "txtEvent4Score"
        Me.txtEvent4Score.Size = New System.Drawing.Size(110, 23)
        Me.txtEvent4Score.TabIndex = 75
        '
        'txtEvent5Score
        '
        Me.txtEvent5Score.Location = New System.Drawing.Point(588, 289)
        Me.txtEvent5Score.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtEvent5Score.Name = "txtEvent5Score"
        Me.txtEvent5Score.Size = New System.Drawing.Size(110, 23)
        Me.txtEvent5Score.TabIndex = 76
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(529, 160)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Event 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(529, 194)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Event 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(529, 222)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 15)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Event 3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(529, 256)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 15)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Event 4"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(529, 289)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 15)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Event 5"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(588, 129)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 15)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "Event Scores:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(179, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(453, 86)
        Me.PictureBox1.TabIndex = 83
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(129, 194)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(262, 160)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 84
        Me.PictureBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(378, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 20)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Scores"
        '
        'frmSoloScoreEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(795, 433)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEvent5Score)
        Me.Controls.Add(Me.txtEvent4Score)
        Me.Controls.Add(Me.txtEvent3Score)
        Me.Controls.Add(Me.txtEvent2Score)
        Me.Controls.Add(Me.txtEvent1Score)
        Me.Controls.Add(Me.lblPlayerName)
        Me.Controls.Add(Me.txtPlayerName)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxPlayerSelection)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(811, 472)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(811, 472)
        Me.Name = "frmSoloScoreEntry"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tournament Scoring App - Solo Score Entry"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMainMenu As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxPlayerSelection As ComboBox
    Friend WithEvents lblPlayerName As Label
    Friend WithEvents txtPlayerName As TextBox
    Friend WithEvents txtEvent1Score As TextBox
    Friend WithEvents txtEvent2Score As TextBox
    Friend WithEvents txtEvent3Score As TextBox
    Friend WithEvents txtEvent4Score As TextBox
    Friend WithEvents txtEvent5Score As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label8 As Label
End Class
