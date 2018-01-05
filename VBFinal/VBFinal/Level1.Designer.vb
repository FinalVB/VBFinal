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
        Me.tmrCMA = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGame = New System.Windows.Forms.Timer(Me.components)
        Me.picPlayerLeft = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picLimitRight = New System.Windows.Forms.PictureBox()
        Me.picLimitLeft = New System.Windows.Forms.PictureBox()
        Me.picGround = New System.Windows.Forms.PictureBox()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
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
        CType(Me.picPlayerLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLimitRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLimitLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'picPlayerLeft
        '
        Me.picPlayerLeft.Image = Global.VBFinal.My.Resources.Resources.Characters_left
        Me.picPlayerLeft.Location = New System.Drawing.Point(14, 317)
        Me.picPlayerLeft.Name = "picPlayerLeft"
        Me.picPlayerLeft.Size = New System.Drawing.Size(36, 37)
        Me.picPlayerLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayerLeft.TabIndex = 28
        Me.picPlayerLeft.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = Global.VBFinal.My.Resources.Resources.plains_door
        Me.PictureBox11.Location = New System.Drawing.Point(36, 26)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 10
        Me.PictureBox11.TabStop = False
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
        Me.picLimitRight.Location = New System.Drawing.Point(683, -1)
        Me.picLimitRight.Name = "picLimitRight"
        Me.picLimitRight.Size = New System.Drawing.Size(10, 475)
        Me.picLimitRight.TabIndex = 23
        Me.picLimitRight.TabStop = False
        Me.picLimitRight.Tag = "bound"
        '
        'picLimitLeft
        '
        Me.picLimitLeft.BackColor = System.Drawing.Color.Transparent
        Me.picLimitLeft.Location = New System.Drawing.Point(-2, -4)
        Me.picLimitLeft.Name = "picLimitLeft"
        Me.picLimitLeft.Size = New System.Drawing.Size(10, 475)
        Me.picLimitLeft.TabIndex = 22
        Me.picLimitLeft.TabStop = False
        Me.picLimitLeft.Tag = "bound"
        '
        'picGround
        '
        Me.picGround.BackColor = System.Drawing.Color.Transparent
        Me.picGround.Location = New System.Drawing.Point(0, 377)
        Me.picGround.Name = "picGround"
        Me.picGround.Size = New System.Drawing.Size(696, 10)
        Me.picGround.TabIndex = 21
        Me.picGround.TabStop = False
        Me.picGround.Tag = "bound"
        '
        'picPlayer
        '
        Me.picPlayer.Image = Global.VBFinal.My.Resources.Resources.Characters
        Me.picPlayer.Location = New System.Drawing.Point(14, 317)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(36, 37)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer.TabIndex = 17
        Me.picPlayer.TabStop = False
        '
        'PictureBox16
        '
        Me.PictureBox16.Image = Global.VBFinal.My.Resources.Resources.coin_point
        Me.PictureBox16.Location = New System.Drawing.Point(732, -1)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(36, 33)
        Me.PictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox16.TabIndex = 16
        Me.PictureBox16.TabStop = False
        '
        'PictureBox15
        '
        Me.PictureBox15.Image = Global.VBFinal.My.Resources.Resources.coin_point
        Me.PictureBox15.Location = New System.Drawing.Point(185, 286)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(33, 25)
        Me.PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox15.TabIndex = 14
        Me.PictureBox15.TabStop = False
        '
        'PictureBox14
        '
        Me.PictureBox14.Image = Global.VBFinal.My.Resources.Resources.coin_point
        Me.PictureBox14.Location = New System.Drawing.Point(630, 190)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(33, 25)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox14.TabIndex = 13
        Me.PictureBox14.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = Global.VBFinal.My.Resources.Resources.coin_point
        Me.PictureBox13.Location = New System.Drawing.Point(337, 111)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(33, 25)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox13.TabIndex = 12
        Me.PictureBox13.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = Global.VBFinal.My.Resources.Resources.key_for_plains
        Me.PictureBox12.Location = New System.Drawing.Point(113, 142)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(26, 50)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 11
        Me.PictureBox12.TabStop = False
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
        Me.PictureBox2.Location = New System.Drawing.Point(173, 317)
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
        Me.PictureBox10.Location = New System.Drawing.Point(145, 88)
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
        Me.PictureBox9.Location = New System.Drawing.Point(290, 142)
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
        Me.PictureBox8.Location = New System.Drawing.Point(469, 153)
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
        Me.PictureBox6.Location = New System.Drawing.Point(74, 191)
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
        Me.PictureBox5.Location = New System.Drawing.Point(303, 272)
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
        Me.PictureBox4.Location = New System.Drawing.Point(437, 248)
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
        Me.PictureBox3.Location = New System.Drawing.Point(573, 222)
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
        Me.picAir.Location = New System.Drawing.Point(0, -1)
        Me.picAir.Name = "picAir"
        Me.picAir.Size = New System.Drawing.Size(759, 469)
        Me.picAir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAir.TabIndex = 0
        Me.picAir.TabStop = False
        Me.picAir.Tag = "limitedLeft"
        '
        'Level1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 468)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.picPlayerLeft)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picLimitRight)
        Me.Controls.Add(Me.picLimitLeft)
        Me.Controls.Add(Me.picGround)
        Me.Controls.Add(Me.PictureBox16)
        Me.Controls.Add(Me.PictureBox15)
        Me.Controls.Add(Me.PictureBox14)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.PictureBox12)
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
        Me.Name = "Level1"
        Me.Text = "Level1"
        CType(Me.picPlayerLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLimitRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLimitLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox14 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox15 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox16 As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox17 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrRight As System.Windows.Forms.Timer
    Friend WithEvents tmrUp As System.Windows.Forms.Timer
    Friend WithEvents tmrGravity As System.Windows.Forms.Timer
    Friend WithEvents tmrLeft As System.Windows.Forms.Timer
    Friend WithEvents picGround As System.Windows.Forms.PictureBox
    Friend WithEvents picLimitLeft As System.Windows.Forms.PictureBox
    Friend WithEvents picLimitRight As System.Windows.Forms.PictureBox
    Friend WithEvents tmrCMA As System.Windows.Forms.Timer
    Friend WithEvents tmrGame As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayerLeft As System.Windows.Forms.PictureBox
End Class
