<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class level3
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
        Me.picAir = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.picSpikes0 = New System.Windows.Forms.PictureBox()
        Me.picSpikes4 = New System.Windows.Forms.PictureBox()
        Me.picSpikes3 = New System.Windows.Forms.PictureBox()
        Me.picSpikes2 = New System.Windows.Forms.PictureBox()
        Me.picSpikes1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.Coin0 = New System.Windows.Forms.PictureBox()
        Me.Coin2 = New System.Windows.Forms.PictureBox()
        Me.Coin1 = New System.Windows.Forms.PictureBox()
        Me.picGoal = New System.Windows.Forms.PictureBox()
        Me.picKey = New System.Windows.Forms.PictureBox()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGravity = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGame = New System.Windows.Forms.Timer(Me.components)
        Me.lblScore = New System.Windows.Forms.Label()
        Me.picGround = New System.Windows.Forms.PictureBox()
        Me.picLimitLeft = New System.Windows.Forms.PictureBox()
        Me.picLimitRight = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSpikes0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSpikes4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSpikes3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSpikes2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSpikes1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Coin0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Coin2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Coin1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGoal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKey, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLimitLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLimitRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picAir
        '
        Me.picAir.Image = Global.VBFinal.My.Resources.Resources.plains_level
        Me.picAir.Location = New System.Drawing.Point(2, 1)
        Me.picAir.Name = "picAir"
        Me.picAir.Size = New System.Drawing.Size(935, 459)
        Me.picAir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAir.TabIndex = 0
        Me.picAir.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.VBFinal.My.Resources.Resources.platform
        Me.PictureBox2.Location = New System.Drawing.Point(21, 63)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "platform"
        '
        'picSpikes0
        '
        Me.picSpikes0.Image = Global.VBFinal.My.Resources.Resources.spike
        Me.picSpikes0.Location = New System.Drawing.Point(2, 327)
        Me.picSpikes0.Name = "picSpikes0"
        Me.picSpikes0.Size = New System.Drawing.Size(174, 39)
        Me.picSpikes0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSpikes0.TabIndex = 2
        Me.picSpikes0.TabStop = False
        Me.picSpikes0.Tag = "spikes"
        '
        'picSpikes4
        '
        Me.picSpikes4.Image = Global.VBFinal.My.Resources.Resources.spike
        Me.picSpikes4.Location = New System.Drawing.Point(719, 325)
        Me.picSpikes4.Name = "picSpikes4"
        Me.picSpikes4.Size = New System.Drawing.Size(218, 39)
        Me.picSpikes4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSpikes4.TabIndex = 5
        Me.picSpikes4.TabStop = False
        Me.picSpikes4.Tag = "spikes"
        '
        'picSpikes3
        '
        Me.picSpikes3.Image = Global.VBFinal.My.Resources.Resources.spike
        Me.picSpikes3.Location = New System.Drawing.Point(517, 325)
        Me.picSpikes3.Name = "picSpikes3"
        Me.picSpikes3.Size = New System.Drawing.Size(208, 39)
        Me.picSpikes3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSpikes3.TabIndex = 6
        Me.picSpikes3.TabStop = False
        Me.picSpikes3.Tag = "spikes"
        '
        'picSpikes2
        '
        Me.picSpikes2.Image = Global.VBFinal.My.Resources.Resources.spike
        Me.picSpikes2.Location = New System.Drawing.Point(345, 327)
        Me.picSpikes2.Name = "picSpikes2"
        Me.picSpikes2.Size = New System.Drawing.Size(174, 39)
        Me.picSpikes2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSpikes2.TabIndex = 7
        Me.picSpikes2.TabStop = False
        Me.picSpikes2.Tag = "spikes"
        '
        'picSpikes1
        '
        Me.picSpikes1.Image = Global.VBFinal.My.Resources.Resources.spike
        Me.picSpikes1.Location = New System.Drawing.Point(172, 327)
        Me.picSpikes1.Name = "picSpikes1"
        Me.picSpikes1.Size = New System.Drawing.Size(174, 39)
        Me.picSpikes1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSpikes1.TabIndex = 8
        Me.picSpikes1.TabStop = False
        Me.picSpikes1.Tag = "spikes"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.VBFinal.My.Resources.Resources.platform
        Me.PictureBox4.Location = New System.Drawing.Point(40, 261)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(180, 30)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 9
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "platform"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.VBFinal.My.Resources.Resources.platform
        Me.PictureBox5.Location = New System.Drawing.Point(273, 291)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(121, 30)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 10
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "platform"
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.VBFinal.My.Resources.Resources.platform
        Me.PictureBox10.Location = New System.Drawing.Point(434, 261)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(100, 30)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 11
        Me.PictureBox10.TabStop = False
        Me.PictureBox10.Tag = "platform"
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = Global.VBFinal.My.Resources.Resources.platform
        Me.PictureBox11.Location = New System.Drawing.Point(467, 242)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(100, 30)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 12
        Me.PictureBox11.TabStop = False
        Me.PictureBox11.Tag = "platform"
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = Global.VBFinal.My.Resources.Resources.platform
        Me.PictureBox12.Location = New System.Drawing.Point(517, 225)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(100, 30)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 13
        Me.PictureBox12.TabStop = False
        Me.PictureBox12.Tag = "platform"
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = Global.VBFinal.My.Resources.Resources.platform
        Me.PictureBox13.Location = New System.Drawing.Point(237, 63)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(227, 30)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox13.TabIndex = 14
        Me.PictureBox13.TabStop = False
        Me.PictureBox13.Tag = "platform"
        '
        'PictureBox14
        '
        Me.PictureBox14.Image = Global.VBFinal.My.Resources.Resources.platform
        Me.PictureBox14.Location = New System.Drawing.Point(824, 291)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(100, 30)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox14.TabIndex = 15
        Me.PictureBox14.TabStop = False
        Me.PictureBox14.Tag = "platform"
        '
        'PictureBox15
        '
        Me.PictureBox15.Image = Global.VBFinal.My.Resources.Resources.platform
        Me.PictureBox15.Location = New System.Drawing.Point(702, 196)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(100, 30)
        Me.PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox15.TabIndex = 16
        Me.PictureBox15.TabStop = False
        Me.PictureBox15.Tag = "platform"
        '
        'Coin0
        '
        Me.Coin0.Image = Global.VBFinal.My.Resources.Resources.coin_point
        Me.Coin0.Location = New System.Drawing.Point(54, 225)
        Me.Coin0.Name = "Coin0"
        Me.Coin0.Size = New System.Drawing.Size(33, 30)
        Me.Coin0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Coin0.TabIndex = 17
        Me.Coin0.TabStop = False
        '
        'Coin2
        '
        Me.Coin2.Image = Global.VBFinal.My.Resources.Resources.coin_point
        Me.Coin2.Location = New System.Drawing.Point(719, 160)
        Me.Coin2.Name = "Coin2"
        Me.Coin2.Size = New System.Drawing.Size(33, 30)
        Me.Coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Coin2.TabIndex = 18
        Me.Coin2.TabStop = False
        '
        'Coin1
        '
        Me.Coin1.Image = Global.VBFinal.My.Resources.Resources.coin_point
        Me.Coin1.Location = New System.Drawing.Point(467, 160)
        Me.Coin1.Name = "Coin1"
        Me.Coin1.Size = New System.Drawing.Size(33, 30)
        Me.Coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Coin1.TabIndex = 19
        Me.Coin1.TabStop = False
        '
        'picGoal
        '
        Me.picGoal.Enabled = False
        Me.picGoal.Image = Global.VBFinal.My.Resources.Resources.plains_door
        Me.picGoal.Location = New System.Drawing.Point(837, 224)
        Me.picGoal.Name = "picGoal"
        Me.picGoal.Size = New System.Drawing.Size(71, 67)
        Me.picGoal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGoal.TabIndex = 20
        Me.picGoal.TabStop = False
        Me.picGoal.Visible = False
        '
        'picKey
        '
        Me.picKey.Image = Global.VBFinal.My.Resources.Resources.key_for_plains
        Me.picKey.Location = New System.Drawing.Point(382, 15)
        Me.picKey.Name = "picKey"
        Me.picKey.Size = New System.Drawing.Size(32, 50)
        Me.picKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKey.TabIndex = 21
        Me.picKey.TabStop = False
        '
        'picPlayer
        '
        Me.picPlayer.Image = Global.VBFinal.My.Resources.Resources.Characters
        Me.picPlayer.Location = New System.Drawing.Point(54, 28)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(36, 37)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer.TabIndex = 22
        Me.picPlayer.TabStop = False
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
        'lblScore
        '
        Me.lblScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblScore.Font = New System.Drawing.Font("Viner Hand ITC", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.Yellow
        Me.lblScore.Location = New System.Drawing.Point(859, 1)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(65, 59)
        Me.lblScore.TabIndex = 30
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picGround
        '
        Me.picGround.BackColor = System.Drawing.Color.Transparent
        Me.picGround.Location = New System.Drawing.Point(2, 355)
        Me.picGround.Name = "picGround"
        Me.picGround.Size = New System.Drawing.Size(935, 11)
        Me.picGround.TabIndex = 31
        Me.picGround.TabStop = False
        Me.picGround.Tag = "ground"
        '
        'picLimitLeft
        '
        Me.picLimitLeft.BackColor = System.Drawing.Color.Transparent
        Me.picLimitLeft.Location = New System.Drawing.Point(2, -27)
        Me.picLimitLeft.Name = "picLimitLeft"
        Me.picLimitLeft.Size = New System.Drawing.Size(10, 475)
        Me.picLimitLeft.TabIndex = 32
        Me.picLimitLeft.TabStop = False
        Me.picLimitLeft.Tag = "LimitLeft"
        '
        'picLimitRight
        '
        Me.picLimitRight.BackColor = System.Drawing.Color.Transparent
        Me.picLimitRight.Location = New System.Drawing.Point(927, 1)
        Me.picLimitRight.Name = "picLimitRight"
        Me.picLimitRight.Size = New System.Drawing.Size(10, 493)
        Me.picLimitRight.TabIndex = 33
        Me.picLimitRight.TabStop = False
        Me.picLimitRight.Tag = "LimitRight"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VBFinal.My.Resources.Resources.spike
        Me.PictureBox1.Location = New System.Drawing.Point(316, 291)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(43, 13)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "spikes"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.VBFinal.My.Resources.Resources.spike
        Me.PictureBox3.Location = New System.Drawing.Point(115, 257)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(43, 15)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 35
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "spikes"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.VBFinal.My.Resources.Resources.spike
        Me.PictureBox6.Location = New System.Drawing.Point(303, 63)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(43, 13)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 36
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Tag = "spikes"
        '
        'level3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 460)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.picKey)
        Me.Controls.Add(Me.picGoal)
        Me.Controls.Add(Me.Coin1)
        Me.Controls.Add(Me.Coin2)
        Me.Controls.Add(Me.Coin0)
        Me.Controls.Add(Me.PictureBox15)
        Me.Controls.Add(Me.PictureBox14)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.picSpikes1)
        Me.Controls.Add(Me.picSpikes2)
        Me.Controls.Add(Me.picSpikes3)
        Me.Controls.Add(Me.picSpikes4)
        Me.Controls.Add(Me.picSpikes0)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.picAir)
        Me.Controls.Add(Me.picGround)
        Me.Controls.Add(Me.picLimitRight)
        Me.Controls.Add(Me.picLimitLeft)
        Me.Name = "level3"
        Me.Tag = "spikes"
        Me.Text = "level3"
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSpikes0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSpikes4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSpikes3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSpikes2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSpikes1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Coin0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Coin2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Coin1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGoal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKey, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLimitLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLimitRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picAir As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents picSpikes0 As System.Windows.Forms.PictureBox
    Friend WithEvents picSpikes4 As System.Windows.Forms.PictureBox
    Friend WithEvents picSpikes3 As System.Windows.Forms.PictureBox
    Friend WithEvents picSpikes2 As System.Windows.Forms.PictureBox
    Friend WithEvents picSpikes1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox14 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox15 As System.Windows.Forms.PictureBox
    Friend WithEvents Coin0 As System.Windows.Forms.PictureBox
    Friend WithEvents Coin2 As System.Windows.Forms.PictureBox
    Friend WithEvents Coin1 As System.Windows.Forms.PictureBox
    Friend WithEvents picGoal As System.Windows.Forms.PictureBox
    Friend WithEvents picKey As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents tmrRight As System.Windows.Forms.Timer
    Friend WithEvents tmrUp As System.Windows.Forms.Timer
    Friend WithEvents tmrGravity As System.Windows.Forms.Timer
    Friend WithEvents tmrLeft As System.Windows.Forms.Timer
    Friend WithEvents tmrGame As System.Windows.Forms.Timer
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents picGround As System.Windows.Forms.PictureBox
    Friend WithEvents picLimitLeft As System.Windows.Forms.PictureBox
    Friend WithEvents picLimitRight As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
End Class
