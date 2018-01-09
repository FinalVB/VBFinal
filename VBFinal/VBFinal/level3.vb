Public Class level3
    Dim Velocity As Integer = 20
    Dim Gravity As Integer = 10
    Dim Jumping As Boolean
    Dim Score As Integer
    Dim DoorKey As Integer

    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick 'Move Right timer
        picPlayer.Left += Velocity
    End Sub

    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick 'Move Left timer
        picPlayer.Left -= Velocity
    End Sub

    Private Sub Level1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown   'Keys to move
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Start()
                picPlayer.Image = My.Resources.Characters
            Case Keys.Left
                tmrLeft.Start()
                picPlayer.Image = My.Resources.Characters_left
            Case Keys.Up
                tmrUp.Start()
                Jumping = True
            Case Keys.Escape
                Me.Close()
                LevelSelect.Visible = True
        End Select
    End Sub


    Private Sub Level1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp   'Keys to stop moveing
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Stop()
            Case Keys.Left
                tmrLeft.Stop()
            Case Keys.Up
                tmrUp.Stop()
                Jumping = False
        End Select
    End Sub

    Private Sub tmrUp_Tick(sender As Object, e As EventArgs) Handles tmrUp.Tick 'Jump timer
        picPlayer.Top -= 30
    End Sub

    Private Sub tmrGravity_Tick(sender As Object, e As EventArgs) Handles tmrGravity.Tick 'Gravity timer
        picPlayer.Top += Gravity
    End Sub

    Private Sub Level_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load   'Game logic timer
        tmrGame.Start()
    End Sub


    Private Sub tmrGameLogic_Tick(sender As Object, e As EventArgs) Handles tmrGame.Tick 'Controls the game logic
        If picPlayer.Bounds.IntersectsWith(picAir.Bounds) Then 'Gravity
            tmrGravity.Start()
            If Jumping = False Then
                tmrGravity.Start()
            End If
        ElseIf picPlayer.Bounds.IntersectsWith(picGround.Bounds) Then
            tmrGravity.Stop()
        End If

        For Each plat As Control In Me.Controls 'Able to walk on platforms
            If TypeOf plat Is PictureBox Then
                If plat.Tag = "platform" Then
                    If picPlayer.Bounds.IntersectsWith(plat.Bounds) Then
                        tmrGravity.Stop()
                    End If
                End If
            End If
        Next

        For Each plat As Control In Me.Controls
            If TypeOf plat Is PictureBox Then
                If plat.Tag = "ground" Then
                    If picPlayer.Bounds.IntersectsWith(plat.Bounds) Then
                        tmrGravity.Stop()
                    End If
                End If
            End If
        Next

        For Each plat As Control In Me.Controls
            If TypeOf plat Is PictureBox Then
                If plat.Tag = "LimitRight" Then
                    If picPlayer.Bounds.IntersectsWith(plat.Bounds) Then
                        tmrRight.Stop()
                    End If
                End If
            End If
        Next

        For Each plat As Control In Me.Controls
            If TypeOf plat Is PictureBox Then
                If plat.Tag = "LimitLeft" Then
                    If picPlayer.Bounds.IntersectsWith(plat.Bounds) Then
                        tmrLeft.Stop()
                    End If
                End If
            End If
        Next


        Dim Coins() = {Coin0, Coin1, Coin2}
        Dim x As Integer
        DoorKey = 0


        For x = 0 To 2
            If picPlayer.Bounds.IntersectsWith(Coins(x).Bounds) Then
                If Coins(x).Enabled = True Then
                    Score = Score + 1
                    lblScore.Text = Score.ToString
                End If
                Coins(x).Hide()
                Coins(x).Enabled = False
            End If
        Next


        If picPlayer.Bounds.IntersectsWith(picKey.Bounds) Then
            picGoal.Visible = True
            picGoal.Enabled = True
            picKey.Hide()
            picKey.Enabled = False
        End If

        If picPlayer.Bounds.IntersectsWith(picGoal.Bounds) Then
            If DoorKey = 0 And picGoal.Enabled = True Then
                Me.Close()
                MainMenu.Visible = True
            End If
        End If

        For Each spikes As Control In Me.Controls 'If you die 
            If TypeOf spikes Is PictureBox Then
                If spikes.Tag = "spikes" Then
                    If picPlayer.Bounds.IntersectsWith(spikes.Bounds) Then
                        Score = 0
                        lblScore.Text = Score.ToString
                        picPlayer.Location = New Point(54, 28)
                        Coin0.Enabled = True
                        Coin0.Visible = True
                        Coin1.Enabled = True
                        Coin1.Visible = True
                        Coin2.Enabled = True
                        Coin2.Visible = True
                        picKey.Enabled = True
                        picKey.Visible = True
                        picGoal.Enabled = False
                        picGoal.Visible = False
                    End If
                End If
            End If
        Next

    End Sub
End Class