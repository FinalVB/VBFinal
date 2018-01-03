Public Class LevelSelect

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Close()
        MainMenu.Visible = True
    End Sub

    Private Sub btnLevel1_Click(sender As Object, e As EventArgs) Handles btnLevel1.Click
        Dim Box As New Level1
        Box.Show()
        ' Me.Close()

    End Sub
End Class