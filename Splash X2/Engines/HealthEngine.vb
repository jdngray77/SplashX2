Public Class HealthEngine

    Public Sub harm(Quantity)
        Game.PlayerHealth += -Quantity
        If Game.PlayerHealth <= 0 Then
            Game.Hide()
            death.ShowDialog()
        End If
        Game.DisplayHealth.Text = Game.PlayerHealth & " / " & Game.PlayerMaxHealth
    End Sub

    Public Sub heal(Quantity)
        If Game.PlayerHealth = 10 Then
            Exit Sub
        End If

        Game.PlayerHealth += Quantity
        Game.DisplayHealth.Text = Game.PlayerHealth & " / " & Game.PlayerMaxHealth
    End Sub
End Class
