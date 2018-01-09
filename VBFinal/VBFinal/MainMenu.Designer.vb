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
        Me.lblName = New System.Windows.Forms.Label()
        Me.picLogo2 = New System.Windows.Forms.PictureBox()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.platform1 = New System.Windows.Forms.PictureBox()
        Me.platform2 = New System.Windows.Forms.PictureBox()
        Me.platform3 = New System.Windows.Forms.PictureBox()
        Me.tmrGravity = New System.Windows.Forms.Timer(Me.components)
        Me.platform5 = New System.Windows.Forms.PictureBox()
        Me.platform4 = New System.Windows.Forms.PictureBox()
        Me.picGoal = New System.Windows.Forms.PictureBox()
        CType(Me.picTurtleGames, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.platform1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.platform2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.platform3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.platform5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.platform4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGoal, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnStart.Location = New System.Drawing.Point(168, 98)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(97, 34)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        Me.btnStart.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(168, 161)
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
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Rage Italic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(55, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(330, 61)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Simple Platform"
        Me.lblName.Visible = False
        '
        'picLogo2
        '
        Me.picLogo2.Image = Global.VBFinal.My.Resources.Resources.TurtleGames
        Me.picLogo2.Location = New System.Drawing.Point(339, 262)
        Me.picLogo2.Name = "picLogo2"
        Me.picLogo2.Size = New System.Drawing.Size(78, 71)
        Me.picLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo2.TabIndex = 5
        Me.picLogo2.TabStop = False
        Me.picLogo2.Visible = False
        '
        'picPlayer
        '
        Me.picPlayer.Image = Global.VBFinal.My.Resources.Resources.Characters
        Me.picPlayer.Location = New System.Drawing.Point(23, 244)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(36, 37)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer.TabIndex = 23
        Me.picPlayer.TabStop = False
        Me.picPlayer.Visible = False
        '
        'platform1
        '
        Me.platform1.Image = Global.VBFinal.My.Resources.Resources.platform
        Me.platform1.Location = New System.Drawing.Point(-1, 280)
        Me.platform1.Name = "platform1"
        Me.platform1.Size = New System.Drawing.Size(100, 30)
        Me.platform1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.platform1.TabIndex = 24
        Me.platform1.TabStop = False
        Me.platform1.Tag = "platform"
        Me.platform1.Visible = False
        '
        'platform2
        '
        Me.platform2.Image = Global.VBFinal.My.Resources.Resources.platform
        Me.platform2.Location = New System.Drawing.Point(136, 244)
        Me.platform2.Name = "platform2"
        Me.platform2.Size = New System.Drawing.Size(100, 30)
        Me.platform2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.platform2.TabIndex = 25
        Me.platform2.TabStop = False
        Me.platform2.Tag = "platform"
        Me.platform2.Visible = False
        '
        'platform3
        '
        Me.platform3.Image = Global.VBFinal.My.Resources.Resources.platform
        Me.platform3.Location = New System.Drawing.Point(-1, 98)
        Me.platform3.Name = "platform3"
        Me.platform3.Size = New System.Drawing.Size(100, 30)
        Me.platform3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.platform3.TabIndex = 26
        Me.platform3.TabStop = False
        Me.platform3.Tag = "platform"
        Me.platform3.Visible = False
        '
        'tmrGravity
        '
        Me.tmrGravity.Interval = 20
        '
        'platform5
        '
        Me.platform5.Image = Global.VBFinal.My.Resources.Resources.platform
        Me.platform5.Location = New System.Drawing.Point(260, 176)
        Me.platform5.Name = "platform5"
        Me.platform5.Size = New System.Drawing.Size(100, 30)
        Me.platform5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.platform5.TabIndex = 27
        Me.platform5.TabStop = False
        Me.platform5.Tag = "platform"
        Me.platform5.Visible = False
        '
        'platform4
        '
        Me.platform4.Image = Global.VBFinal.My.Resources.Resources.platform
        Me.platform4.Location = New System.Drawing.Point(136, 113)
        Me.platform4.Name = "platform4"
        Me.platform4.Size = New System.Drawing.Size(100, 30)
        Me.platform4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.platform4.TabIndex = 28
        Me.platform4.TabStop = False
        Me.platform4.Tag = "platform"
        Me.platform4.Visible = False
        '
        'picGoal
        '
        Me.picGoal.Enabled = False
        Me.picGoal.Image = Global.VBFinal.My.Resources.Resources.plains_door
        Me.picGoal.Location = New System.Drawing.Point(12, 59)
        Me.picGoal.Name = "picGoal"
        Me.picGoal.Size = New System.Drawing.Size(47, 42)
        Me.picGoal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGoal.TabIndex = 29
        Me.picGoal.TabStop = False
        Me.picGoal.Visible = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(429, 345)
        Me.Controls.Add(Me.picGoal)
        Me.Controls.Add(Me.platform4)
        Me.Controls.Add(Me.platform5)
        Me.Controls.Add(Me.platform3)
        Me.Controls.Add(Me.platform2)
        Me.Controls.Add(Me.platform1)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.picLogo2)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblTurtleGames)
        Me.Controls.Add(Me.picTurtleGames)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MainMenu"
        CType(Me.picTurtleGames, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.platform1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.platform2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.platform3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.platform5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.platform4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGoal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picTurtleGames As System.Windows.Forms.PictureBox
    Friend WithEvents lblTurtleGames As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents picLogo2 As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents platform1 As System.Windows.Forms.PictureBox
    Friend WithEvents platform2 As System.Windows.Forms.PictureBox
    Friend WithEvents platform3 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrGravity As System.Windows.Forms.Timer
    Friend WithEvents platform5 As System.Windows.Forms.PictureBox
    Friend WithEvents platform4 As System.Windows.Forms.PictureBox
    Friend WithEvents picGoal As System.Windows.Forms.PictureBox

End Class
