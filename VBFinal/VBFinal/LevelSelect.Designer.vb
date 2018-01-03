<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LevelSelect
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
        Me.btnLevel1 = New System.Windows.Forms.Button()
        Me.btnLevel2 = New System.Windows.Forms.Button()
        Me.btnLevel3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCoinNumber = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLevel1
        '
        Me.btnLevel1.Location = New System.Drawing.Point(122, 35)
        Me.btnLevel1.Name = "btnLevel1"
        Me.btnLevel1.Size = New System.Drawing.Size(92, 42)
        Me.btnLevel1.TabIndex = 0
        Me.btnLevel1.Text = "Level 1"
        Me.btnLevel1.UseVisualStyleBackColor = True
        '
        'btnLevel2
        '
        Me.btnLevel2.Location = New System.Drawing.Point(57, 97)
        Me.btnLevel2.Name = "btnLevel2"
        Me.btnLevel2.Size = New System.Drawing.Size(92, 42)
        Me.btnLevel2.TabIndex = 1
        Me.btnLevel2.Text = "Level 2"
        Me.btnLevel2.UseVisualStyleBackColor = True
        '
        'btnLevel3
        '
        Me.btnLevel3.Location = New System.Drawing.Point(200, 97)
        Me.btnLevel3.Name = "btnLevel3"
        Me.btnLevel3.Size = New System.Drawing.Size(92, 42)
        Me.btnLevel3.TabIndex = 2
        Me.btnLevel3.Text = "Level 3"
        Me.btnLevel3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Coins:"
        '
        'lblCoinNumber
        '
        Me.lblCoinNumber.AutoSize = True
        Me.lblCoinNumber.Location = New System.Drawing.Point(65, 194)
        Me.lblCoinNumber.Name = "lblCoinNumber"
        Me.lblCoinNumber.Size = New System.Drawing.Size(13, 13)
        Me.lblCoinNumber.TabIndex = 4
        Me.lblCoinNumber.Text = "="
        '
        'LevelSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 227)
        Me.Controls.Add(Me.lblCoinNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLevel3)
        Me.Controls.Add(Me.btnLevel2)
        Me.Controls.Add(Me.btnLevel1)
        Me.Name = "LevelSelect"
        Me.Text = "LevelSelect"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLevel1 As System.Windows.Forms.Button
    Friend WithEvents btnLevel2 As System.Windows.Forms.Button
    Friend WithEvents btnLevel3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCoinNumber As System.Windows.Forms.Label
End Class
