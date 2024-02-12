<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSoloEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSoloEntry))
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.cbxPlayerSelection = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkEvent1 = New System.Windows.Forms.CheckBox()
        Me.chkEvent2 = New System.Windows.Forms.CheckBox()
        Me.chkEvent3 = New System.Windows.Forms.CheckBox()
        Me.chkEvent4 = New System.Windows.Forms.CheckBox()
        Me.chkEvent5 = New System.Windows.Forms.CheckBox()
        Me.gbxSoloEventSelection = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtPlayerName = New System.Windows.Forms.TextBox()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbxSoloEventSelection.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnMainMenu.ForeColor = System.Drawing.Color.White
        Me.btnMainMenu.Location = New System.Drawing.Point(286, 398)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(80, 23)
        Me.btnMainMenu.TabIndex = 2
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'cbxPlayerSelection
        '
        Me.cbxPlayerSelection.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.cbxPlayerSelection.ForeColor = System.Drawing.Color.White
        Me.cbxPlayerSelection.FormattingEnabled = True
        Me.cbxPlayerSelection.Location = New System.Drawing.Point(1, 245)
        Me.cbxPlayerSelection.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cbxPlayerSelection.Name = "cbxPlayerSelection"
        Me.cbxPlayerSelection.Size = New System.Drawing.Size(132, 23)
        Me.cbxPlayerSelection.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1, 219)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Player Select:"
        '
        'chkEvent1
        '
        Me.chkEvent1.AutoSize = True
        Me.chkEvent1.Location = New System.Drawing.Point(30, 50)
        Me.chkEvent1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.chkEvent1.Name = "chkEvent1"
        Me.chkEvent1.Size = New System.Drawing.Size(64, 19)
        Me.chkEvent1.TabIndex = 6
        Me.chkEvent1.Text = "Event 1"
        Me.chkEvent1.UseVisualStyleBackColor = True
        '
        'chkEvent2
        '
        Me.chkEvent2.AutoSize = True
        Me.chkEvent2.Location = New System.Drawing.Point(148, 50)
        Me.chkEvent2.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.chkEvent2.Name = "chkEvent2"
        Me.chkEvent2.Size = New System.Drawing.Size(64, 19)
        Me.chkEvent2.TabIndex = 7
        Me.chkEvent2.Text = "Event 2"
        Me.chkEvent2.UseVisualStyleBackColor = True
        '
        'chkEvent3
        '
        Me.chkEvent3.AutoSize = True
        Me.chkEvent3.Location = New System.Drawing.Point(260, 50)
        Me.chkEvent3.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.chkEvent3.Name = "chkEvent3"
        Me.chkEvent3.Size = New System.Drawing.Size(64, 19)
        Me.chkEvent3.TabIndex = 8
        Me.chkEvent3.Text = "Event 3"
        Me.chkEvent3.UseVisualStyleBackColor = True
        '
        'chkEvent4
        '
        Me.chkEvent4.AutoSize = True
        Me.chkEvent4.Location = New System.Drawing.Point(383, 50)
        Me.chkEvent4.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.chkEvent4.Name = "chkEvent4"
        Me.chkEvent4.Size = New System.Drawing.Size(64, 19)
        Me.chkEvent4.TabIndex = 9
        Me.chkEvent4.Text = "Event 4"
        Me.chkEvent4.UseVisualStyleBackColor = True
        '
        'chkEvent5
        '
        Me.chkEvent5.AutoSize = True
        Me.chkEvent5.Location = New System.Drawing.Point(513, 50)
        Me.chkEvent5.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.chkEvent5.Name = "chkEvent5"
        Me.chkEvent5.Size = New System.Drawing.Size(64, 19)
        Me.chkEvent5.TabIndex = 10
        Me.chkEvent5.Text = "Event 5"
        Me.chkEvent5.UseVisualStyleBackColor = True
        '
        'gbxSoloEventSelection
        '
        Me.gbxSoloEventSelection.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.gbxSoloEventSelection.Controls.Add(Me.chkEvent1)
        Me.gbxSoloEventSelection.Controls.Add(Me.chkEvent5)
        Me.gbxSoloEventSelection.Controls.Add(Me.chkEvent2)
        Me.gbxSoloEventSelection.Controls.Add(Me.chkEvent4)
        Me.gbxSoloEventSelection.Controls.Add(Me.chkEvent3)
        Me.gbxSoloEventSelection.ForeColor = System.Drawing.Color.White
        Me.gbxSoloEventSelection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.gbxSoloEventSelection.Location = New System.Drawing.Point(203, 216)
        Me.gbxSoloEventSelection.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.gbxSoloEventSelection.Name = "gbxSoloEventSelection"
        Me.gbxSoloEventSelection.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.gbxSoloEventSelection.Size = New System.Drawing.Size(595, 109)
        Me.gbxSoloEventSelection.TabIndex = 11
        Me.gbxSoloEventSelection.TabStop = False
        Me.gbxSoloEventSelection.Text = "Register events"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(433, 401)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(81, 22)
        Me.btnSave.TabIndex = 64
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtPlayerName
        '
        Me.txtPlayerName.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.txtPlayerName.ForeColor = System.Drawing.Color.White
        Me.txtPlayerName.Location = New System.Drawing.Point(89, 216)
        Me.txtPlayerName.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtPlayerName.Name = "txtPlayerName"
        Me.txtPlayerName.Size = New System.Drawing.Size(110, 23)
        Me.txtPlayerName.TabIndex = 65
        '
        'lblPlayerName
        '
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.lblPlayerName.ForeColor = System.Drawing.Color.White
        Me.lblPlayerName.Location = New System.Drawing.Point(107, 185)
        Me.lblPlayerName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(82, 15)
        Me.lblPlayerName.TabIndex = 66
        Me.lblPlayerName.Text = "Players Name:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(203, -8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(388, 139)
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-563, -128)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1361, 566)
        Me.PictureBox2.TabIndex = 68
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(378, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 17)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Entry"
        '
        'frmSoloEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 433)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblPlayerName)
        Me.Controls.Add(Me.txtPlayerName)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.gbxSoloEventSelection)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxPlayerSelection)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(811, 472)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(811, 472)
        Me.Name = "frmSoloEntry"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tournament Scoring App - Solo Entry"
        Me.gbxSoloEventSelection.ResumeLayout(False)
        Me.gbxSoloEventSelection.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMainMenu As Button
    Friend WithEvents cbxPlayerSelection As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkEvent1 As CheckBox
    Friend WithEvents chkEvent2 As CheckBox
    Friend WithEvents chkEvent3 As CheckBox
    Friend WithEvents chkEvent4 As CheckBox
    Friend WithEvents chkEvent5 As CheckBox
    Friend WithEvents gbxSoloEventSelection As GroupBox
    Friend WithEvents btnSave As Button
    Friend WithEvents txtPlayerName As TextBox
    Friend WithEvents lblPlayerName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
End Class
