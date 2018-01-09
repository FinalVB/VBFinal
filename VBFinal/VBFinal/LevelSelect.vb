Public Class LevelSelect

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Close()
        MainMenu.Visible = True
    End Sub

    Private Sub LevelSelect_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
                MainMenu.Visible = True
        End Select
    End Sub

    Private Sub btnLevel1_Click(sender As Object, e As EventArgs) Handles btnLevel1.Click
        Dim Box As New Level1
        Box.Show()
        Me.Close()
        MainMenu.Visible = False
    End Sub

    Private Sub btnLevel2_Click(sender As Object, e As EventArgs) Handles btnLevel2.Click
        Dim Box As New level2
        Box.Show()
        Me.Close()
        MainMenu.Visible = False
    End Sub

    Private Sub btnLevel3_Click(sender As Object, e As EventArgs) Handles btnLevel3.Click
        Dim Box As New level3
        Box.Show()
        Me.Close()
        MainMenu.Visible = False
    End Sub
End Class