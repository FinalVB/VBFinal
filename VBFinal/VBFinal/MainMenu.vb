Public Class MainMenu

    Dim second As Integer
    'Dim Gravity As Integer = 10

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 2000
        Timer1.Start() 'Timer starts functioning


        '    For Each plat As Control In Me.Controls 'Able to walk on platforms
        '        If TypeOf plat Is PictureBox Then
        '            If plat.Tag = "platform" Then
        '                If picPlayer.Bounds.IntersectsWith(plat.Bounds) Then
        '                    tmrGravity.Stop()
        '                End If
        '            End If
        '        End If
        '    Next
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        picTurtleGames.Visible = False
        lblTurtleGames.Visible = False

        second = second + 1
        If second >= 2 Then
            btnStart.Visible = True
            btnExit.Visible = True
            lblName.Visible = True
            picLogo2.Visible = True
            'picPlayer.Visible = True
            'platform1.Visible = True
            'platform2.Visible = True
            'platform3.Visible = True
            'platform4.Visible = True
            'platform5.Visible = True
            'picGoal.Visible = True
        End If
    End Sub

    Private Sub MainMenu_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim Box As New LevelSelect
        Box.Show()
        'Me.Visible = False
    End Sub

    'Private Sub tmrGravity_Tick(sender As Object, e As EventArgs) Handles tmrGravity.Tick  'Gravity timer
    '    picPlayer.Top += Gravity
    'End Sub

End Class
