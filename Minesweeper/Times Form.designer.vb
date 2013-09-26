<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimesForm
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.iTime = New System.Windows.Forms.Label
        Me.bTime = New System.Windows.Forms.Label
        Me.eTime = New System.Windows.Forms.Label
        Me.eName = New System.Windows.Forms.Label
        Me.bName = New System.Windows.Forms.Label
        Me.iName = New System.Windows.Forms.Label
        Me.okButton = New System.Windows.Forms.Button
        Me.resetButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Beginner:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Expert:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Intermediate:"
        '
        'iTime
        '
        Me.iTime.Location = New System.Drawing.Point(101, 42)
        Me.iTime.Name = "iTime"
        Me.iTime.Size = New System.Drawing.Size(96, 24)
        Me.iTime.TabIndex = 3
        Me.iTime.Text = "999 seconds"
        Me.iTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bTime
        '
        Me.bTime.Location = New System.Drawing.Point(101, 11)
        Me.bTime.Name = "bTime"
        Me.bTime.Size = New System.Drawing.Size(96, 24)
        Me.bTime.TabIndex = 4
        Me.bTime.Text = "999 seconds"
        Me.bTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'eTime
        '
        Me.eTime.Location = New System.Drawing.Point(101, 73)
        Me.eTime.Name = "eTime"
        Me.eTime.Size = New System.Drawing.Size(96, 24)
        Me.eTime.TabIndex = 5
        Me.eTime.Text = "999 seconds"
        Me.eTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'eName
        '
        Me.eName.Location = New System.Drawing.Point(203, 73)
        Me.eName.Name = "eName"
        Me.eName.Size = New System.Drawing.Size(96, 24)
        Me.eName.TabIndex = 8
        Me.eName.Text = "Anymous"
        Me.eName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bName
        '
        Me.bName.Location = New System.Drawing.Point(203, 11)
        Me.bName.Name = "bName"
        Me.bName.Size = New System.Drawing.Size(96, 24)
        Me.bName.TabIndex = 7
        Me.bName.Text = "Anymous"
        Me.bName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'iName
        '
        Me.iName.Location = New System.Drawing.Point(203, 42)
        Me.iName.Name = "iName"
        Me.iName.Size = New System.Drawing.Size(96, 24)
        Me.iName.TabIndex = 6
        Me.iName.Text = "Anymous"
        Me.iName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'okButton
        '
        Me.okButton.Location = New System.Drawing.Point(157, 107)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(75, 23)
        Me.okButton.TabIndex = 9
        Me.okButton.Text = "OK"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'resetButton
        '
        Me.resetButton.Location = New System.Drawing.Point(76, 107)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(75, 23)
        Me.resetButton.TabIndex = 10
        Me.resetButton.Text = "Reset"
        Me.resetButton.UseVisualStyleBackColor = True
        '
        'TimesForm
        '
        Me.AcceptButton = Me.okButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 139)
        Me.Controls.Add(Me.resetButton)
        Me.Controls.Add(Me.okButton)
        Me.Controls.Add(Me.eName)
        Me.Controls.Add(Me.bName)
        Me.Controls.Add(Me.iName)
        Me.Controls.Add(Me.eTime)
        Me.Controls.Add(Me.bTime)
        Me.Controls.Add(Me.iTime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "TimesForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Best Times"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents iTime As System.Windows.Forms.Label
    Friend WithEvents bTime As System.Windows.Forms.Label
    Friend WithEvents eTime As System.Windows.Forms.Label
    Friend WithEvents eName As System.Windows.Forms.Label
    Friend WithEvents bName As System.Windows.Forms.Label
    Friend WithEvents iName As System.Windows.Forms.Label
    Friend WithEvents okButton As System.Windows.Forms.Button
    Friend WithEvents resetButton As System.Windows.Forms.Button
End Class
