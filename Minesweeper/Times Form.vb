
Public Class TimesForm
    Dim Times() As String = My.Settings.BestTimes.Split(CChar(","))
    Dim Names() As String = My.Settings.BestTimeNames.Split(CChar(","))

    Private Sub okButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okButton.Click
        Me.Close()
    End Sub

    Private Sub TimesForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub TimesForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BringToFront()
        bName.Text = Names(0)
        iName.Text = Names(1)
        eName.Text = Names(2)
        bTime.Text = Times(0)
        iTime.Text = Times(1)
        eTime.Text = Times(2)
    End Sub

    Private Sub resetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resetButton.Click
        If MessageBox.Show("Are you sure you wish to reset all the best times?", "Reset", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            My.Settings.BestTimes = "999,999,999"
            My.Settings.BestTimeNames = "Anymous,Anymous,Anymous"
            bTime.Text = "999"
            iTime.Text = "999"
            eTime.Text = "999"
            bName.Text = "Anonymous"
            iName.Text = "Anonymous"
            eName.Text = "Anonymous"
        End If
    End Sub

End Class