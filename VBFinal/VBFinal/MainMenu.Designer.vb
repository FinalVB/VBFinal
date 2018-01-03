<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.components = New System.ComponentModel.Container()
        Me.lblTurtleGames = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picTurtleGames = New System.Windows.Forms.PictureBox()
        CType(Me.picTurtleGames, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTurtleGames
        '
        Me.lblTurtleGames.AutoSize = True
        Me.lblTurtleGames.Font = New System.Drawing.Font("Comic Sans MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurtleGames.Location = New System.Drawing.Point(-1, 259)
        Me.lblTurtleGames.Name = "lblTurtleGames"
        Me.lblTurtleGames.Size = New System.Drawing.Size(418, 51)
        Me.lblTurtleGames.TabIndex = 1
        Me.lblTurtleGames.Text = "Turtle Entertainments"
        '
        'Timer1
        '
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(180, 81)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(97, 34)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        Me.btnStart.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(180, 144)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(97, 34)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        Me.btnExit.Visible = False
        '
        'picTurtleGames
        '
        Me.picTurtleGames.Image = Global.VBFinal.My.Resources.Resources.TurtleGames
        Me.picTurtleGames.Location = New System.Drawing.Point(79, 30)
        Me.picTurtleGames.Name = "picTurtleGames"
        Me.picTurtleGames.Size = New System.Drawing.Size(281, 226)
        Me.picTurtleGames.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTurtleGames.TabIndex = 0
        Me.picTurtleGames.TabStop = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 345)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblTurtleGames)
        Me.Controls.Add(Me.picTurtleGames)
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        CType(Me.picTurtleGames, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picTurtleGames As System.Windows.Forms.PictureBox
    Friend WithEvents lblTurtleGames As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
