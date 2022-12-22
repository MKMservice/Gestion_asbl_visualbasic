Public Class DOCUMENTATION

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        ACCEUIL.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LETTRE_REUSSI.Close()
        RAPPORT.Close()
        GESTION_DE_LETTRE.Show()
        GESTION_DE_LETTRE.MdiParent = ACCEUIL
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GESTION_DE_LETTRE.Close()
        RAPPORT.Close()
        LETTRE_REUSSI.Show()
        LETTRE_REUSSI.MdiParent = ACCEUIL
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GESTION_DE_LETTRE.Close()
        LETTRE_REUSSI.Close()
        RAPPORT.Show()
        RAPPORT.MdiParent = ACCEUIL
        Me.Close()

    End Sub
End Class