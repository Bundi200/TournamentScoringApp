<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSoloLeaderboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSoloLeaderboard))
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.cbxEventSelection = New System.Windows.Forms.ComboBox()
        Me.txtSoloLeaderboard = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnMainMenu.ForeColor = System.Drawing.Color.White
        Me.btnMainMenu.Location = New System.Drawing.Point(348, 415)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(80, 23)
        Me.btnMainMenu.TabIndex = 2
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'cbxEventSelection
        '
        Me.cbxEventSelection.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.cbxEventSelection.ForeColor = System.Drawing.Color.White
        Me.cbxEventSelection.FormattingEnabled = True
        Me.cbxEventSelection.Location = New System.Drawing.Point(10, 90)
        Me.cbxEventSelection.Name = "cbxEventSelection"
        Me.cbxEventSelection.Size = New System.Drawing.Size(121, 23)
        Me.cbxEventSelection.TabIndex = 5
        '
        'txtSoloLeaderboard
        '
        Me.txtSoloLeaderboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtSoloLeaderboard.Enabled = False
        Me.txtSoloLeaderboard.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSoloLeaderboard.ForeColor = System.Drawing.Color.White
        Me.txtSoloLeaderboard.Location = New System.Drawing.Point(137, 90)
        Me.txtSoloLeaderboard.Multiline = True
        Me.txtSoloLeaderboard.Name = "txtSoloLeaderboard"
        Me.txtSoloLeaderboard.Size = New System.Drawing.Size(661, 319)
        Me.txtSoloLeaderboard.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(231, -27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(342, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'frmSoloLeaderboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtSoloLeaderboard)
        Me.Controls.Add(Me.cbxEventSelection)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(816, 489)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(816, 489)
        Me.Name = "frmSoloLeaderboard"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tournament Scoring App - Solo Leaderboards"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMainMenu As Button
    Friend WithEvents cbxEventSelection As ComboBox
    Friend WithEvents txtSoloLeaderboard As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
