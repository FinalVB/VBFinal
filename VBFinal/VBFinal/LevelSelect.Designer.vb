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
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.lblCoinP = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLevel1
        '
        Me.btnLevel1.Location = New System.Drawing.Point(123, 52)
        Me.btnLevel1.Name = "btnLevel1"
        Me.btnLevel1.Size = New System.Drawing.Size(92, 42)
        Me.btnLevel1.TabIndex = 0
        Me.btnLevel1.Text = "Level 1"
        Me.btnLevel1.UseVisualStyleBackColor = True
        '
        'btnLevel2
        '
        Me.btnLevel2.Location = New System.Drawing.Point(58, 114)
        Me.btnLevel2.Name = "btnLevel2"
        Me.btnLevel2.Size = New System.Drawing.Size(92, 42)
        Me.btnLevel2.TabIndex = 1
        Me.btnLevel2.Text = "Level 2"
        Me.btnLevel2.UseVisualStyleBackColor = True
        '
        'btnLevel3
        '
        Me.btnLevel3.Location = New System.Drawing.Point(201, 114)
        Me.btnLevel3.Name = "btnLevel3"
        Me.btnLevel3.Size = New System.Drawing.Size(92, 42)
        Me.btnLevel3.TabIndex = 2
        Me.btnLevel3.Text = "Level 3"
        Me.btnLevel3.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Location = New System.Drawing.Point(123, 174)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(92, 23)
        Me.btnMainMenu.TabIndex = 12
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'lblCoinP
        '
        Me.lblCoinP.Font = New System.Drawing.Font("Tempus Sans ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoinP.Location = New System.Drawing.Point(278, 9)
        Me.lblCoinP.Name = "lblCoinP"
        Me.lblCoinP.Size = New System.Drawing.Size(53, 45)
        Me.lblCoinP.TabIndex = 13
        '
        'LevelSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(343, 227)
        Me.Controls.Add(Me.lblCoinP)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnLevel3)
        Me.Controls.Add(Me.btnLevel2)
        Me.Controls.Add(Me.btnLevel1)
        Me.Name = "LevelSelect"
        Me.Text = "LevelSelect"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLevel1 As System.Windows.Forms.Button
    Friend WithEvents btnLevel2 As System.Windows.Forms.Button
    Friend WithEvents btnLevel3 As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents lblCoinP As System.Windows.Forms.Label
End Class
