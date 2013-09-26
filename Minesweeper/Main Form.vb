'Minesweeper - Eastside Edition
'Programmed by Daniel Dara

Public Class MainForm
    Dim ClickCount As Integer
    Dim MineColors() As Color = {Color.White, Color.Lime, Color.Red, Color.Cyan, Color.Gold, Color.Fuchsia, Color.Black, Color.DarkGray}
    Dim FlagImg As Image = My.Resources.Flag
    Dim Eagle As Image = My.Resources.Eagle
    Dim EagleWin As Image = My.Resources.EagleWin
    Dim EagleLose As Image = My.Resources.EagleLose
    Dim isGameOver As Boolean
    Dim GameTypes() As ToolStripMenuItem
    Dim BoardWidth As Integer
    Dim BoardHeight As Integer
    Dim BoardMines As Integer
    Dim GameBoard(,) As MineTile
    Dim Rand As New Random

    Private Function DrawTile(ByVal Tile As MineTile) As Bitmap
        Dim Brush1 As New System.Drawing.Drawing2D.LinearGradientBrush(New Point(0, 0), New Point(25, 25), Color.Blue, Color.DarkBlue)
        Dim Brush2 As New System.Drawing.Drawing2D.LinearGradientBrush(New Point(5, 5), New Point(19, 19), Color.Red, Color.DarkRed)
        Dim Brush3 As New System.Drawing.Drawing2D.LinearGradientBrush(New Point(4, 4), New Point(20, 20), Color.Yellow, Color.DarkGoldenrod)
        Dim Pen1 As New Pen(Color.Gold)
        Pen1.Brush = Brush3
        Dim b As New Bitmap(25, 25)
        Dim g As Graphics = Graphics.FromImage(b)

        If Tile.Clicked Then
            g.FillRectangle(Brushes.DarkBlue, New Rectangle(1, 1, 23, 23))
            If Tile.Mine Then
                If Tile.SurroundingMines = -1 Then g.FillRectangle(Brushes.Red, New Rectangle(1, 1, 23, 23))
                g.FillEllipse(Brush2, 5, 5, 14, 14)
                g.DrawEllipse(Pen1, 5, 5, 14, 14)
                g.DrawEllipse(Pen1, 4, 4, 16, 16)
            Else
                If Tile.Mark = 1 Then
                    g.FillEllipse(Brush2, 5, 5, 14, 14)
                    g.DrawEllipse(Pen1, 5, 5, 14, 14)
                    g.DrawEllipse(Pen1, 4, 4, 16, 16)
                    g.DrawLine(New Pen(Color.White, 2), 2, 2, 21, 21)
                    g.DrawLine(New Pen(Color.White, 2), 21, 2, 2, 21)
                Else
                    If Tile.SurroundingMines <> 0 Then
                        g.DrawString(Tile.SurroundingMines.ToString, New Font("Tahoma", 14, FontStyle.Bold), New SolidBrush(MineColors(Tile.SurroundingMines - 1)), 3, 1)
                    End If
                End If
            End If
        Else
            g.FillRectangle(Brush1, New Rectangle(1, 1, 23, 23))
            Select Case Tile.Mark
                Case 1
                    g.DrawImage(FlagImg, New Point(6, 3))
                Case 2
                    g.DrawString("?", New Font("Tahoma", 14, FontStyle.Bold), Brushes.White, 4, 1)
            End Select
        End If
        g.Dispose()

        Return b
    End Function

    Private Sub OpenTile(ByVal X As Integer, ByVal Y As Integer)
        Dim b As Bitmap = New Bitmap(Board.Image)
        Dim g As Graphics = Graphics.FromImage(b)

        g.DrawImage(DrawTile(GameBoard(X, Y)), New Point(X * 25, Y * 25))

        Board.Image = b
        g.Dispose()
    End Sub

    Private Sub OpenEmpties(ByVal X As Integer, ByVal Y As Integer)
        If SafelyOpenEmpty(X - 1, Y) Then OpenEmpties(X - 1, Y)
        If SafelyOpenEmpty(X + 1, Y) Then OpenEmpties(X + 1, Y)
        If SafelyOpenEmpty(X, Y - 1) Then OpenEmpties(X, Y - 1)
        If SafelyOpenEmpty(X, Y + 1) Then OpenEmpties(X, Y + 1)
        If SafelyOpenEmpty(X - 1, Y - 1) Then OpenEmpties(X - 1, Y - 1)
        If SafelyOpenEmpty(X + 1, Y - 1) Then OpenEmpties(X + 1, Y - 1)
        If SafelyOpenEmpty(X - 1, Y + 1) Then OpenEmpties(X - 1, Y + 1)
        If SafelyOpenEmpty(X + 1, Y + 1) Then OpenEmpties(X + 1, Y + 1)
    End Sub

    Private Function SafelyOpenEmpty(ByVal X As Integer, ByVal Y As Integer) As Boolean
        If X >= 0 And X < BoardWidth And Y >= 0 And Y < BoardHeight Then
            If GameBoard(X, Y).Mark = 0 Then
                If GameBoard(X, Y).SurroundingMines = 0 And GameBoard(X, Y).Clicked = False Then
                    GameBoard(X, Y).Clicked = True
                    ClickCount += 1
                    Return True
                ElseIf GameBoard(X, Y).Clicked = False Then
                    GameBoard(X, Y).Clicked = True
                    ClickCount += 1
                End If
            End If
        End If
    End Function

    Private Sub DrawGameBoard()
        Dim b As New Bitmap(Board.Width, Board.Height)
        Dim g As Graphics = Graphics.FromImage(b)

        For X As Integer = 0 To BoardWidth - 1
            For Y As Integer = 0 To BoardHeight - 1
                g.DrawImage(DrawTile(GameBoard(X, Y)), X * 25, Y * 25)
            Next
        Next
        g.Dispose()

        Board.Image = b
    End Sub

    Private Sub NewGame()
        Dim GameInfo() As String = GameTypes(My.Settings.SelectedGame).Tag.ToString.Split(CChar(","))

        BoardWidth = CInt(GameInfo(0))
        BoardHeight = CInt(GameInfo(1))
        BoardMines = CInt(GameInfo(2))

        ReDim GameBoard(BoardWidth - 1, BoardHeight - 1)
        For X As Integer = 0 To BoardWidth - 1
            For Y As Integer = 0 To BoardHeight - 1
                GameBoard(X, Y) = New MineTile
            Next
        Next

        ClickCount = 0
        isGameOver = False
        newButton.Image = Eagle
        gameTimer.Enabled = False
        minesLabel.Text = BoardMines.ToString
        timeLabel.Text = "0"
        Me.Width = BoardWidth * 25 + 25
        Me.Height = BoardHeight * 25 + 135
        Me.CenterToScreen()
        Board.Width = BoardWidth * 25
        Board.Height = BoardHeight * 25
        DrawGameBoard()

        'Insert Mines
        Dim Loc As Point = New Point(Rand.Next(0, BoardWidth), Rand.Next(0, BoardHeight))
        For X As Integer = 1 To BoardMines
            While GameBoard(Loc.X, Loc.Y).Mine
                Loc = New Point(Rand.Next(0, BoardWidth), Rand.Next(0, BoardHeight))
            End While
            GameBoard(Loc.X, Loc.Y).Mine = True
        Next

        'Get Mine Numbers
        For X As Integer = 0 To BoardWidth - 1
            For Y As Integer = 0 To BoardHeight - 1
                If GameBoard(X, Y).Mine = False Then GameBoard(X, Y).SurroundingMines = GetMineNumber(X + 1, Y) + GetMineNumber(X - 1, Y) + GetMineNumber(X, Y + 1) + GetMineNumber(X, Y - 1) + GetMineNumber(X - 1, Y - 1) + GetMineNumber(X + 1, Y - 1) + GetMineNumber(X - 1, Y + 1) + GetMineNumber(X + 1, Y + 1)
            Next
        Next

    End Sub

    Private Function GetMineNumber(ByVal X As Integer, ByVal Y As Integer) As Integer
        If Y < BoardHeight And Y >= 0 And X >= 0 And X < BoardWidth Then
            If GameBoard(X, Y).Mine Then Return 1
        End If
    End Function

    Private Sub anyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuicideToolStripMenuItem.Click, IntermediateToolStripMenuItem.Click, ExpertToolStripMenuItem.Click, CustomToolStripMenuItem.Click, BeginnerToolStripMenuItem.Click
        Dim GameOption As ToolStripMenuItem = DirectCast(sender, ToolStripMenuItem)
        GameTypes(My.Settings.SelectedGame).Checked = False
        My.Settings.SelectedGame = Array.IndexOf(GameTypes, GameOption)
        GameOption.Checked = True
        If My.Settings.SelectedGame = 4 Then CustomForm.ShowDialog()
        NewGame()
    End Sub

    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Marks = MarksToolStripMenuItem.Checked
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SuicideToolStripMenuItem.Tag = My.Computer.Screen.Bounds.Width \ 25 & "," & (My.Computer.Screen.Bounds.Height - 135) \ 25 & "," & ((My.Computer.Screen.Bounds.Height - 135) \ 25) * (My.Computer.Screen.Bounds.Width \ 25) \ 6
        newButton.Image = Eagle
        newButton.ImageAlign = ContentAlignment.MiddleCenter
        MarksToolStripMenuItem.Checked = My.Settings.Marks
        CustomToolStripMenuItem.Tag = My.Settings.CustomSettings
        GameTypes = New ToolStripMenuItem() {BeginnerToolStripMenuItem, IntermediateToolStripMenuItem, ExpertToolStripMenuItem, SuicideToolStripMenuItem, CustomToolStripMenuItem}
        GameTypes(My.Settings.SelectedGame).Checked = True
        NewGame()
    End Sub

    Private Sub gameTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gameTimer.Tick
        timeLabel.Text = (CInt(timeLabel.Text) + 1).ToString
    End Sub

    Private Sub Board_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Board.MouseDown
        Dim X As Integer = e.X \ 25
        Dim Y As Integer = e.Y \ 25

        If isGameOver = False And GameBoard(X, Y).Clicked = False Then
            gameTimer.Enabled = True

            Select Case e.Button
                Case Windows.Forms.MouseButtons.Right
                    If GameBoard(X, Y).Clicked = False Then
                        If GameBoard(X, Y).Mark = 0 Then minesLabel.Text = (CInt(minesLabel.Text) - 1).ToString
                        If GameBoard(X, Y).Mark = 1 Then minesLabel.Text = (CInt(minesLabel.Text) + 1).ToString
                        GameBoard(X, Y).Mark += 1
                        If GameBoard(X, Y).Mark >= 2 - CInt(MarksToolStripMenuItem.Checked) Then GameBoard(X, Y).Mark = 0
                        OpenTile(X, Y)
                    End If
            End Select
        End If
    End Sub

    Private Sub Board_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Board.MouseUp
        Dim X As Integer = e.X \ 25
        Dim Y As Integer = e.Y \ 25

        If isGameOver = False And GameBoard(X, Y).Clicked = False Then
            gameTimer.Enabled = True

            Select Case e.Button
                Case Windows.Forms.MouseButtons.Left
                    If GameBoard(X, Y).Mark = 0 Then
                        ClickCount += 1
                        GameBoard(X, Y).Clicked = True
                        If GameBoard(X, Y).Mine Then GameBoard(X, Y).SurroundingMines = -1
                        If GameBoard(X, Y).SurroundingMines = 0 Then OpenEmpties(X, Y) : DrawGameBoard() Else OpenTile(X, Y)
                        If GameBoard(X, Y).Mine Then GameLose() Else If ClickCount = GameBoard.Length - BoardMines Then GameWin()
                    End If
            End Select
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NewGameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewGameToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you wish to start a new game?", "New Game", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then NewGame()
    End Sub

    Private Sub cheatButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For X As Integer = 0 To BoardWidth - 1
            For Y As Integer = 0 To BoardHeight - 1
                If GameBoard(X, Y).Mine = False Then GameBoard(X, Y).Clicked = True
            Next
        Next
        DrawGameBoard()
        GameWin()
    End Sub

    Private Sub GameLose()
        gameTimer.Enabled = False
        newButton.Image = EagleLose
        isGameOver = True

        For Each T As MineTile In GameBoard
            T.Clicked = True
        Next

        DrawGameBoard()
    End Sub

    Private Sub GameWin()
        gameTimer.Enabled = False
        newButton.Image = EagleWin
        isGameOver = True

        For Each T As MineTile In GameBoard
            If T.Mine Then T.Mark = 1
        Next

        DrawGameBoard()

        If My.Settings.SelectedGame < 3 Then If CInt(timeLabel.Text) < CInt(My.Settings.BestTimes.Split(CChar(","))(My.Settings.SelectedGame)) Then BestTimeForm.ShowDialog()
    End Sub

    Private Sub newButton_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles newButton.MouseClick
        NewGame()
    End Sub

    Private Sub BestTimesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BestTimesToolStripMenuItem.Click
        TimesForm.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Minesweeper Eastide High School Theme" & ControlChars.NewLine & "Programmed by Daniel Dara")
    End Sub
End Class