
Public Class BestTimeForm
    Dim Times() As String = My.Settings.BestTimes.Split(CChar(","))
    Dim Names() As String = My.Settings.BestTimeNames.Split(CChar(","))
    Dim DisplayTexts() As String = {"beginner", "intermediate", "expert"}

    Private Sub BestTimeForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub BestTimeForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        middleLabel.Text = "for " & DisplayTexts(My.Settings.SelectedGame) & " level."
        nameTextBox.Text = Names(My.Settings.SelectedGame)
        nameTextBox.SelectAll()
    End Sub

    Private Sub okButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okButton.Click
        Names(My.Settings.SelectedGame) = nameTextBox.Text
        Times(My.Settings.SelectedGame) = MainForm.timeLabel.Text
        My.Settings.BestTimeNames = Names(0) & "," & Names(1) & "," & Names(2)
        My.Settings.BestTimes = Times(0) & "," & Times(1) & "," & Times(2)
        TimesForm.ShowDialog()
        Me.Close()
    End Sub
End Class