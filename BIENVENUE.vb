Public Class BIENVENUE

    Private Sub BIENVENUE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CONNEXION.Show()
        Me.Hide()
        Timer1.Stop()
    End Sub
End Class