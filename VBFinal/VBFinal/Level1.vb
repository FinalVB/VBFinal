Public Class Level1

    'Dim Velocity As Integer = 20
    'Dim Gravity As Integer = 10
    'Dim Jumping As Boolean

    'Private Sub Level_1_Load(sender As Object, e As EventArgs) Handles Me.Load 'Game logic timer
    '    tmrGame.Start()
    'End Sub

    'Private Sub tmrGravity_Tick(sender As Object, e As EventArgs) Handles tmrGravity.Tick 'Gravity timer
    '    picPlayer.Top += Gravity
    'End Sub

    'Private Sub tmrUp_Tick(sender As Object, e As EventArgs) Handles tmrUp.Tick 'Jump timer
    '    picPlayer.Top -= 30
    'End Sub

    'Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick 'Move Right timer
    '    picPlayer.Left += Velocity
    'End Sub

    'Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick 'Move Left timer
    '    picPlayer.Left -= Velocity
    'End Sub

    'Private Sub tmrGameLogic_Tick(sender As Object, e As EventArgs) Handles tmrGame.Tick
    '    If picPlayer.Bounds.IntersectsWith(picAir.Bounds) Then
    '        tmrGravity.Start()
    '        'If isJumping = False Then
    '        'tmrGravity.Start()
    '        'End If
    '    ElseIf picPlayer.Bounds.IntersectsWith(picGround.Bounds) Then
    '        tmrGravity.Stop()
    '    End If

    '    For Each plat As Control In Me.Controls
    '        If TypeOf plat Is PictureBox Then
    '            If plat.Tag = "platform" Then
    '                If picPlayer.Bounds.IntersectsWith(plat.Bounds) Then
    '                    tmrGravity.Stop()
    '                End If
    '            End If
    '        End If
    '    Next

    '    ' Map Boundary
    '    ' Right
    '    For Each limit As Control In Me.Controls
    '        If TypeOf limit Is PictureBox Then
    '            If limit.Tag = "limitedRight" Then
    '                If picPlayer.Bounds.IntersectsWith(limit.Bounds) Then
    '                    tmrRight.Stop()
    '                End If
    '            End If
    '        End If
    '    Next

    '    For Each limit As Control In Me.Controls
    '        If TypeOf limit Is PictureBox Then
    '            If limit.Tag = "limitedLeft" Then
    '                If picPlayer.Bounds.IntersectsWith(limit.Bounds) Then
    '                    tmrRight.Stop()
    '                End If
    '            End If
    '        End If
    '    Next
    'End Sub

    'Private Sub Level_1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown 'When key is pressed down 
    '    Select Case e.KeyCode
    '        Case Keys.D
    '            tmrRight.Start()
    '            'tmrCMA.Start()
    '        Case Keys.A
    '            tmrLeft.Start()
    '            ' tmrCMA.Start()
    '        Case Keys.W
    '            tmrUp.Start()
    '            ' tmrCMA.Start()
    '            Jumping = True
    '    End Select
    '    If Keys.D Then
    '        picPlayer.Left += Velocity
    '        picPlayerLeft.Visible = False
    '        picPlayer.Visible = True
    '        picPlayerLeft.Left += Velocity
    '    ElseIf Keys.A Then
    '        picPlayer.Visible = False
    '        picPlayerLeft.Visible = True
    '        picPlayer.Left -= Velocity
    '        picPlayerLeft.Left -= Velocity
    '    ElseIf Keys.W Then
    '        tmrUp.Start()
    '        Jumping = True
    '    End If
    'End Sub

    'Private Sub Level_1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp 'When key is up
    '    Select Case e.KeyCode
    '        Case Keys.D
    '            tmrRight.Stop()
    '            ' tmrCMA.Stop()
    '        Case Keys.A
    '            tmrLeft.Stop()
    '            ' tmrCMA.Stop()
    '        Case Keys.W
    '            tmrUp.Stop()
    '            '  tmrCMA.Stop()
    '            Jumping = False
    '    End Select
    '    If Keys.D Then
    '        picPlayer.Left += Velocity
    '        picPlayerLeft.Left += Velocity
    '        picPlayerLeft.Visible = False
    '        picPlayer.Visible = True
    '    ElseIf Keys.A Then
    '        picPlayer.Visible = False
    '        picPlayerLeft.Visible = True
    '        picPlayer.Left -= Velocity
    '        picPlayerLeft.Left -= Velocity
    '    ElseIf Keys.W Then
    '        tmrUp.Stop()
    '        Jumping = False
    '    End If
    'End Sub



    Dim Velocity As Integer = 20
    Dim Gravity As Integer = 10
    Dim Jumping As Boolean
   


    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick 'Move Right timer
        picPlayer.Left += Velocity
    End Sub

    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick 'Move Left timer
        picPlayer.Left -= Velocity
    End Sub

    Private Sub Level1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Start()
            Case Keys.Left
                tmrLeft.Start()
            Case Keys.Up
                tmrUp.Start()
                Jumping = True
            Case Keys.Escape
                Me.Close()
                LevelSelect.Visible = True
        End Select
    End Sub


    Private Sub Level1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
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

    Private Sub Level_1_Load(sender As Object, e As EventArgs) Handles Me.Load 'Game logic timer
        tmrGame.Start()
    End Sub


    Private Sub tmrGameLogic_Tick(sender As Object, e As EventArgs) Handles tmrGame.Tick
        If picPlayer.Bounds.IntersectsWith(picAir.Bounds) Then
            tmrGravity.Start()
            If Jumping = False Then
                tmrGravity.Start()
            End If
        ElseIf picPlayer.Bounds.IntersectsWith(picGround.Bounds) Then
            tmrGravity.Stop()
        End If

        For Each plat As Control In Me.Controls
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


        Dim Coins() = {Coin0, Coin2, Coin1}
        Dim CoinPoints As Integer
        Dim Score As Integer

      

        For CoinPoints = 0 To 2
            If picPlayer.Bounds.IntersectsWith(Coins(CoinPoints).Bounds) Then
                If Coins(CoinPoints).Enabled = True Then
                    Score += 1
                    lblScore.Text = Score.ToString
                End If
                Coins(CoinPoints).Hide()
                Coins(CoinPoints).Enabled = False
            End If
        Next


        If picPlayer.Bounds.IntersectsWith(picKey.Bounds) Then
            picGoal.Visible = True
            picKey.Hide()
            picKey.Enabled = False
        End If


        If picPlayer.Bounds.IntersectsWith(picGoal.Bounds) Then
            Me.Close()
            LevelSelect.Visible = True
            level2.Visible = True
        End If

    End Sub

End Class
