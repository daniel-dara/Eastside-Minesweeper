Option Strict On

Public Class CustomForm

    Private Sub okButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okButton.Click
        My.Settings.CustomSettings = widthUpDown.Value & "," & heightUpDown.Value & "," & minesUpDown.Value
        MainForm.CustomToolStripMenuItem.Tag = My.Settings.CustomSettings
        Me.Close()
    End Sub

    Private Sub CustomForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub CustomForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        heightUpDown.Maximum = (My.Computer.Screen.Bounds.Height - 135) \ 25
        widthUpDown.Maximum = (My.Computer.Screen.Bounds.Width) \ 25
        widthUpDown.Value = CInt(My.Settings.CustomSettings.Split(CChar(","))(0))
        heightUpDown.Value = CInt(My.Settings.CustomSettings.Split(CChar(","))(1))
        minesUpDown.Value = CInt(My.Settings.CustomSettings.Split(CChar(","))(2))
        minesUpDown.Maximum = heightUpDown.Value * widthUpDown.Value - 1
    End Sub

    Private Sub heightUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles heightUpDown.ValueChanged, widthUpDown.ValueChanged
        minesUpDown.Maximum = heightUpDown.Value * widthUpDown.Value - 1
    End Sub
End Class