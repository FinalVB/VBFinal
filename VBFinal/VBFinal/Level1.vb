Public Class Level1

    Dim Velocity As Integer = 20
    Dim Gravity As Integer = 10
    Dim Jumping As Boolean

    Private Sub Level_1_Load(sender As Object, e As EventArgs) Handles Me.Load 'Game logic timer
        tmrGame.Start()
    End Sub

    Private Sub tmrGravity_Tick(sender As Object, e As EventArgs) Handles tmrGravity.Tick 'Gravity timer
        picPlayer.Top += Gravity
    End Sub

    ' Private Sub tmrCMA_Tick(sender As Object, e As EventArgs) Handles tmrCMA.Tick 'Animation timer

    '       If picPlayer.Visible = True Then 'Move Right Animation
    '        picPlayer.Visible = False
    '           picCMRW.Visible = True
    '      ElseIf picCMRW.Visible = True Then 'Standing still 
    '          picCMRW.Visible = False
    '         picPlayer.Visible = True
    '     End If
    '  End Sub
    Private Sub tmrUp_Tick(sender As Object, e As EventArgs) Handles tmrUp.Tick 'Jump timer
        picPlayer.Top -= 20
    End Sub

    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick 'Move Right timer
        picPlayer.Left += Velocity
    End Sub

    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick 'Move Left timer
        picPlayer.Left -= Velocity
    End Sub

    Private Sub tmrGameLogic_Tick(sender As Object, e As EventArgs) Handles tmrGame.Tick
        If picPlayer.Bounds.IntersectsWith(picAir.Bounds) Then
            tmrGravity.Start()
            'If isJumping = False Then
            'tmrGravity.Start()
            'End If
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

        ' Map Boundary
        ' Right
        For Each limit As Control In Me.Controls
            If TypeOf limit Is PictureBox Then
                If limit.Tag = "limitedRight" Then
                    If picPlayer.Bounds.IntersectsWith(limit.Bounds) Then
                        tmrRight.Stop()
                    End If
                End If
            End If
        Next

        For Each limit As Control In Me.Controls
            If TypeOf limit Is PictureBox Then
                If limit.Tag = "limitedLeft" Then
                    If picPlayer.Bounds.IntersectsWith(limit.Bounds) Then
                        tmrRight.Stop()
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub Level_1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown 'Key Down 
        Select Case e.KeyCode
            Case Keys.D
                tmrRight.Start()
                'tmrCMA.Start()
            Case Keys.A
                tmrLeft.Start()
                ' tmrCMA.Start()
            Case Keys.W
                tmrUp.Start()
                ' tmrCMA.Start()
                Jumping = True
        End Select
    End Sub

    Private Sub Level_1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp 'Key Up
        Select Case e.KeyCode
            Case Keys.D
                tmrRight.Stop()
                ' tmrCMA.Stop()
            Case Keys.A
                tmrLeft.Stop()
                ' tmrCMA.Stop()
            Case Keys.W
                tmrUp.Stop()
                '  tmrCMA.Stop()
                Jumping = False
        End Select
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Me.Close()
        Dim Box As New LevelSelect
        Box.Show()
    End Sub
End Class
