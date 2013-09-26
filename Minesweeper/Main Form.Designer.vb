<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container
        Me.Button1 = New System.Windows.Forms.Button
        Me.minesLabel = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.timeLabel = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.newButton = New System.Windows.Forms.Button
        Me.gameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Board = New System.Windows.Forms.PictureBox
        Me.GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BeginnerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IntermediateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExpertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SuicideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.MarksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BestTimesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.HowToPlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.Panel1.SuspendLayout()
        CType(Me.Board, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(175, 3)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 18)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Insta-Win"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'minesLabel
        '
        Me.minesLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.minesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.minesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minesLabel.ForeColor = System.Drawing.Color.White
        Me.minesLabel.Location = New System.Drawing.Point(21, 25)
        Me.minesLabel.Name = "minesLabel"
        Me.minesLabel.Size = New System.Drawing.Size(50, 26)
        Me.minesLabel.TabIndex = 4
        Me.minesLabel.Text = "0"
        Me.minesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(24, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mines"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(155, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Time"
        '
        'timeLabel
        '
        Me.timeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.timeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeLabel.ForeColor = System.Drawing.Color.White
        Me.timeLabel.Location = New System.Drawing.Point(149, 25)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(50, 26)
        Me.timeLabel.TabIndex = 13
        Me.timeLabel.Text = "0"
        Me.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.minesLabel)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.newButton)
        Me.Panel1.Controls.Add(Me.timeLabel)
        Me.Panel1.Location = New System.Drawing.Point(10, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(225, 61)
        Me.Panel1.TabIndex = 17
        '
        'newButton
        '
        Me.newButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.newButton.BackColor = System.Drawing.Color.Blue
        Me.newButton.FlatAppearance.BorderSize = 2
        Me.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newButton.ForeColor = System.Drawing.Color.White
        Me.newButton.Location = New System.Drawing.Point(85, 3)
        Me.newButton.Name = "newButton"
        Me.newButton.Size = New System.Drawing.Size(50, 50)
        Me.newButton.TabIndex = 1
        Me.newButton.UseVisualStyleBackColor = False
        '
        'gameTimer
        '
        Me.gameTimer.Interval = 1000
        '
        'Board
        '
        Me.Board.BackColor = System.Drawing.Color.Gold
        Me.Board.Location = New System.Drawing.Point(10, 96)
        Me.Board.Name = "Board"
        Me.Board.Size = New System.Drawing.Size(225, 225)
        Me.Board.TabIndex = 15
        Me.Board.TabStop = False
        '
        'GameToolStripMenuItem
        '
        Me.GameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.ToolStripSeparator1, Me.BeginnerToolStripMenuItem, Me.IntermediateToolStripMenuItem, Me.ExpertToolStripMenuItem, Me.SuicideToolStripMenuItem, Me.CustomToolStripMenuItem, Me.ToolStripSeparator2, Me.MarksToolStripMenuItem, Me.ToolStripSeparator3, Me.BestTimesToolStripMenuItem, Me.ToolStripSeparator4, Me.ExitToolStripMenuItem})
        Me.GameToolStripMenuItem.Name = "GameToolStripMenuItem"
        Me.GameToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.GameToolStripMenuItem.Text = "Game"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.NewGameToolStripMenuItem.Text = "New Game"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(152, 6)
        '
        'BeginnerToolStripMenuItem
        '
        Me.BeginnerToolStripMenuItem.CheckOnClick = True
        Me.BeginnerToolStripMenuItem.Name = "BeginnerToolStripMenuItem"
        Me.BeginnerToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.BeginnerToolStripMenuItem.Tag = "9,9,10"
        Me.BeginnerToolStripMenuItem.Text = "Beginner"
        '
        'IntermediateToolStripMenuItem
        '
        Me.IntermediateToolStripMenuItem.CheckOnClick = True
        Me.IntermediateToolStripMenuItem.Name = "IntermediateToolStripMenuItem"
        Me.IntermediateToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.IntermediateToolStripMenuItem.Tag = "16,16,40"
        Me.IntermediateToolStripMenuItem.Text = "Intermediate"
        '
        'ExpertToolStripMenuItem
        '
        Me.ExpertToolStripMenuItem.CheckOnClick = True
        Me.ExpertToolStripMenuItem.Name = "ExpertToolStripMenuItem"
        Me.ExpertToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ExpertToolStripMenuItem.Tag = "30,19,99"
        Me.ExpertToolStripMenuItem.Text = "Expert"
        '
        'SuicideToolStripMenuItem
        '
        Me.SuicideToolStripMenuItem.Name = "SuicideToolStripMenuItem"
        Me.SuicideToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SuicideToolStripMenuItem.Text = "Suicide"
        '
        'CustomToolStripMenuItem
        '
        Me.CustomToolStripMenuItem.CheckOnClick = True
        Me.CustomToolStripMenuItem.Name = "CustomToolStripMenuItem"
        Me.CustomToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.CustomToolStripMenuItem.Text = "Custom..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(152, 6)
        '
        'MarksToolStripMenuItem
        '
        Me.MarksToolStripMenuItem.Checked = True
        Me.MarksToolStripMenuItem.CheckOnClick = True
        Me.MarksToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MarksToolStripMenuItem.Name = "MarksToolStripMenuItem"
        Me.MarksToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.MarksToolStripMenuItem.Text = "Marks (?)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(152, 6)
        '
        'BestTimesToolStripMenuItem
        '
        Me.BestTimesToolStripMenuItem.Name = "BestTimesToolStripMenuItem"
        Me.BestTimesToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.BestTimesToolStripMenuItem.Text = "Best Times..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(152, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ToolStripSeparator5, Me.HowToPlayToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(139, 6)
        '
        'HowToPlayToolStripMenuItem
        '
        Me.HowToPlayToolStripMenuItem.Name = "HowToPlayToolStripMenuItem"
        Me.HowToPlayToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.HowToPlayToolStripMenuItem.Text = "How to Play"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Gold
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(244, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(244, 328)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Board)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Minesweeper"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Board, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Board As System.Windows.Forms.PictureBox
    Friend WithEvents minesLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents timeLabel As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents newButton As System.Windows.Forms.Button
    Friend WithEvents gameTimer As System.Windows.Forms.Timer
    Friend WithEvents GameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BeginnerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IntermediateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExpertToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuicideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MarksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BestTimesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HowToPlayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
End Class
