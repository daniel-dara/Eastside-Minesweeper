<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomForm
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
        Me.heightUpDown = New System.Windows.Forms.NumericUpDown
        Me.widthUpDown = New System.Windows.Forms.NumericUpDown
        Me.minesUpDown = New System.Windows.Forms.NumericUpDown
        Me.okButton = New System.Windows.Forms.Button
        CType(Me.heightUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.widthUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minesUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Height"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Width"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Mines"
        '
        'heightUpDown
        '
        Me.heightUpDown.Location = New System.Drawing.Point(63, 13)
        Me.heightUpDown.Minimum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.heightUpDown.Name = "heightUpDown"
        Me.heightUpDown.Size = New System.Drawing.Size(69, 23)
        Me.heightUpDown.TabIndex = 1
        Me.heightUpDown.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'widthUpDown
        '
        Me.widthUpDown.Location = New System.Drawing.Point(63, 42)
        Me.widthUpDown.Minimum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.widthUpDown.Name = "widthUpDown"
        Me.widthUpDown.Size = New System.Drawing.Size(69, 23)
        Me.widthUpDown.TabIndex = 3
        Me.widthUpDown.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'minesUpDown
        '
        Me.minesUpDown.Location = New System.Drawing.Point(63, 71)
        Me.minesUpDown.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.minesUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.minesUpDown.Name = "minesUpDown"
        Me.minesUpDown.Size = New System.Drawing.Size(69, 23)
        Me.minesUpDown.TabIndex = 5
        Me.minesUpDown.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'okButton
        '
        Me.okButton.Location = New System.Drawing.Point(147, 38)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(75, 31)
        Me.okButton.TabIndex = 6
        Me.okButton.Text = "OK"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'CustomForm
        '
        Me.AcceptButton = Me.okButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 106)
        Me.Controls.Add(Me.okButton)
        Me.Controls.Add(Me.minesUpDown)
        Me.Controls.Add(Me.widthUpDown)
        Me.Controls.Add(Me.heightUpDown)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "CustomForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Custom Size"
        CType(Me.heightUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.widthUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minesUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents heightUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents widthUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents minesUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents okButton As System.Windows.Forms.Button
End Class
