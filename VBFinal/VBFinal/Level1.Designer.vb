<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Level1
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
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGravity = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGame = New System.Windows.Forms.Timer(Me.components)
        Me.picGoal = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picLimitRight = New System.Windows.Forms.PictureBox()
        Me.picLimitLeft = New System.Windows.Forms.PictureBox()
        Me.picGround = New System.Windows.Forms.PictureBox()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.Coin0 = New System.Windows.Forms.PictureBox()
        Me.picKey = New System.Windows.Forms.PictureBox()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.picAir = New System.Windows.Forms.PictureBox()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.Coin1 = New System.Windows.Forms.PictureBox()
        Me.Coin2 = New System.Windows.Forms.PictureBox()
        CType(Me.picGoal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLimitRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLimitLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Coin0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKey, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Coin1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Coin2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrRight
        '
        '
        'tmrUp
        '
        Me.tmrUp.Interval = 90
        '
        'tmrGravity
        '
        Me.tmrGravity.Interval = 20
        '
        'tmrLeft
        '
        '
        'tmrGame
        '
        Me.tmrGame.Interval = 20
        '
        'picGoal
        '
        Me.picGoal.Enabled = False
        Me.picGoal.Image = Global.VBFinal.My.Resources.Resources.plains_door
        Me.picGoal.Location = New System.Drawing.Point(36, 26)
        Me.picGoal.Name = "picGoal"
        Me.picGoal.Size = New System.Drawing.Size(48, 50)
        Me.picGoal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGoal.TabIndex = 10
        Me.picGoal.TabStop = False
        Me.picGoal.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VBFinal.My.Resources.Resources.platform
        Me.PictureBox1.Location = New System.Drawing.Point(14, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "platform"
        '
        'picLimitRight
        '
        Me.picLimitRight.BackColor = System.Drawing.Color.Transparent
        Me.picLimitRight.Location = New System.Drawing.Point(716, -22)
        Me.picLimitRight.Name = "picLimitRight"
        Me.picLimitRight.Size = New System.Drawing.Size(10, 493)
        Me.picLimitRight.TabIndex = 23
        Me.picLimitRight.TabStop = False
        Me.picLimitRight.Tag = "LimitRight"
        '
        'picLimitLeft
        '
        Me.picLimitLeft.BackColor = System.Drawing.Color.Transparent
        Me.picLimitLeft.Location = New System.Drawing.Point(-2, -4)
        Me.picLimitLeft.Name = "picLimitLeft"
        Me.picLimitLeft.Size = New System.Drawing.Size(10, 475)
        Me.picLimitLeft.TabIndex = 22
        Me.picLimitLeft.TabStop = False
        Me.picLimitLeft.Tag = "LimitLeft"
        '
        'picGround
        '
        Me.picGround.BackColor = System.Drawing.Color.Transparent
        Me.picGround.Location = New System.Drawing.Point(0, 377)
        Me.picGround.Name = "picGround"
        Me.picGround.Size = New System.Drawing.Size(726, 11)
        Me.picGround.TabIndex = 21
        Me.picGround.TabStop = False
        Me.picGround.Tag = "ground"
        '
        'picPlayer
        '
        Me.picPlayer.Image = Global.VBFinal.My.Resources.Resources.Characters
        Me.picPlayer.Location = New System.Drawing.Point(23, 317)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(36, 37)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer.TabIndex = 17
        Me.picPlayer.TabStop = False
        '
        'Coin0
        '
        Me.Coin0.Image = Global.VBFinal.My.Resources.Resources.coin_point
        Me.Coin0.Location = New System.Drawing.Point(209, 286)
        Me.Coin0.Name = "Coin0"
        Me.Coin0.Size = New System.Drawing.Size(33, 25)
        Me.Coin0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Coin0.TabIndex = 14
        Me.Coin0.TabStop = False
        Me.Coin0.Tag = "coin"
        '
        'picKey
        '
        Me.picKey.Image = Global.VBFinal.My.Resources.Resources.key_for_plains
        Me.picKey.Location = New System.Drawing.Point(58, 128)
        Me.picKey.Name = "picKey"
        Me.picKey.Size = New System.Drawing.Size(26, 50)
        Me.picKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKey.TabIndex = 11
        Me.picKey.TabStop = False
        '
        'PictureBox17
        '
        Me.PictureBox17.Image = Global.VBFinal.My.Resources.Resources.platform
        Me.PictureBox17.Location = New System.Drawing.Point(12, 347)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(104, 24)
        Me.PictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox17.TabIndex = 20
        Me.PictureBox17.TabStop = False
        Me.PictureBox17.Tag = "platform"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.VBFinal.My.Resources.Resources.platform
        Me.PictureBox2.Location = New System.Drawing.Point(185, 317)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(104, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "platform"
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.VBFinal.My.Resources.Resources.platform
        Me.PictureBox10.Location = New System.Drawing.Point(185, 72)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(104, 24)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 9
        Me.PictureBox10.TabStop = False
        Me.PictureBox10.Tag = "platform"
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = Global.VBFinal.My.Resources.Resources.platform
        Me.PictureBox9.Location = New System.Drawing.Point(303, 129)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(104, 24)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 8
        Me.PictureBox9.TabStop = False
        Me.PictureBox9.Tag = "platform"
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.VBFinal.My.Resources.Resources.platform
        Me.PictureBox8.Location = New System.Drawing.Point(458, 142)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(104, 24)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 7
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Tag = "platform"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.VBFinal.My.Resources.Resources.platform
        Me.PictureBox6.Location = New System.Drawing.Point(14, 184)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(104, 24)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 5
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Tag = "platform"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.VBFinal.My.Resources.Resources.platform
        Me.PictureBox5.Location = New System.Drawing.Point(326, 238)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(104, 24)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "platform"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.VBFinal.My.Resources.Resources.platform
        Me.PictureBox4.Location = New System.Drawing.Point(481, 260)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(104, 24)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "platform"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.VBFinal.My.Resources.Resources.platform
        Me.PictureBox3.Location = New System.Drawing.Point(606, 209)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(104, 24)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "platform"
        '
        'picAir
        '
        Me.picAir.Image = Global.VBFinal.My.Resources.Resources.plains_level
        Me.picAir.Location = New System.Drawing.Point(0, -4)
        Me.picAir.Name = "picAir"
        Me.picAir.Size = New System.Drawing.Size(781, 475)
        Me.picAir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAir.TabIndex = 0
        Me.picAir.TabStop = False
        Me.picAir.Tag = "limitedLeft"
        '
        'lblScore
        '
        Me.lblScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblScore.Font = New System.Drawing.Font("Viner Hand ITC", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.Yellow
        Me.lblScore.Location = New System.Drawing.Point(716, -4)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(65, 59)
        Me.lblScore.TabIndex = 29
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Coin1
        '
        Me.Coin1.Image = Global.VBFinal.My.Resources.Resources.coin_point
        Me.Coin1.Location = New System.Drawing.Point(665, 329)
        Me.Coin1.Name = "Coin1"
        Me.Coin1.Size = New System.Drawing.Size(33, 25)
        Me.Coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Coin1.TabIndex = 30
        Me.Coin1.TabStop = False
        Me.Coin1.Tag = "coin"
        '
        'Coin2
        '
        Me.Coin2.Image = Global.VBFinal.My.Resources.Resources.coin_point
        Me.Coin2.Location = New System.Drawing.Point(493, 111)
        Me.Coin2.Name = "Coin2"
        Me.Coin2.Size = New System.Drawing.Size(33, 25)
        Me.Coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Coin2.TabIndex = 31
        Me.Coin2.TabStop = False
        Me.Coin2.Tag = "coin"
        '
        'Level1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 468)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.Coin2)
        Me.Controls.Add(Me.Coin1)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.picGoal)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Coin0)
        Me.Controls.Add(Me.picKey)
        Me.Controls.Add(Me.PictureBox17)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.picAir)
        Me.Controls.Add(Me.picGround)
        Me.Controls.Add(Me.picLimitRight)
        Me.Controls.Add(Me.picLimitLeft)
        Me.Name = "Level1"
        Me.Text = "Level1"
        CType(Me.picGoal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLimitRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLimitLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Coin0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKey, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Coin1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Coin2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picAir As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents picGoal As System.Windows.Forms.PictureBox
    Friend WithEvents picKey As System.Windows.Forms.PictureBox
    Friend WithEvents Coin0 As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox17 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrRight As System.Windows.Forms.Timer
    Friend WithEvents tmrUp As System.Windows.Forms.Timer
    Friend WithEvents tmrGravity As System.Windows.Forms.Timer
    Friend WithEvents tmrLeft As System.Windows.Forms.Timer
    Friend WithEvents picGround As System.Windows.Forms.PictureBox
    Friend WithEvents picLimitLeft As System.Windows.Forms.PictureBox
    Friend WithEvents picLimitRight As System.Windows.Forms.PictureBox
    Friend WithEvents tmrGame As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents Coin1 As System.Windows.Forms.PictureBox
    Friend WithEvents Coin2 As System.Windows.Forms.PictureBox
End Class
