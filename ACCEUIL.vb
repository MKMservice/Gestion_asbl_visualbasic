Public Class ACCEUIL
    Private Sub ACCEUIL_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try
            GESTION_DE_LA_CAISSE.Close()
            FICHE_ADHESION.Close()
            USERS.Close()
            GESTION_DES_COTISATIONS.Close()
            Impression_cotisation.Close()
            MEMBRE.MdiParent = Me

        Catch ex As Exception
            MsgBox("Erreur")
        End Try
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        Try
            GESTION_DE_LA_CAISSE.Close()
            FICHE_ADHESION.Close()
            USERS.Close()
            GESTION_DES_COTISATIONS.Close()
            Impression_cotisation.Close()
            RAPPORT.Close()
            FICHE_ADHESION.Show()
            FICHE_ADHESION.MdiParent = Me
        Catch ex As Exception
            MsgBox("Erreur")
        End Try
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
     
        Try
            MEMBRE.Close()
            GESTION_DE_LA_CAISSE.Close()
            FICHE_ADHESION.Close()
            USERS.Close()
            Impression_cotisation.Close()
            RAPPORT.Close()
            GESTION_DES_COTISATIONS.Show()
            GESTION_DES_COTISATIONS.MdiParent = Me
        Catch ex As Exception
            MsgBox("Erreur")
        End Try

    End Sub

    Private Sub ACCEUIL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            ToolStripLabel2.Text = Date.Now
        Catch ex As Exception
            MsgBox("Erreur")
        End Try

    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        Try
            GESTION_DES_COTISATIONS.Close()
            FICHE_ADHESION.Close()
            USERS.Close()
            MEMBRE.Close()
            Impression_cotisation.Close()
            RAPPORT.Close()
            GESTION_DE_LA_CAISSE.Show()
            GESTION_DE_LA_CAISSE.MdiParent = Me
        Catch ex As Exception
            MsgBox("Erreur")
        End Try

    End Sub

    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles ToolStripButton10.Click
        Try
            GESTION_DE_LA_CAISSE.Close()
            FICHE_ADHESION.Close()
            MEMBRE.Close()
            GESTION_DES_COTISATIONS.Close()
            USERS.Close()
            Impression_cotisation.Close()
            DOCUMENTATION.Show()
            DOCUMENTATION.MdiParent = Me
        Catch ex As Exception
            MsgBox("Erreur")
        End Try

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            GESTION_DE_LA_CAISSE.Close()
            FICHE_ADHESION.Close()
            MEMBRE.Close()
            GESTION_DES_COTISATIONS.Close()
            USERS.Close()
            RAPPORT.Close()
            Impression_cotisation.Close()
            CONNEXION.Show()

        Catch ex As Exception
            MsgBox("Erreur")
        End Try

    End Sub

    Private Sub ToolStripButton11_Click(sender As Object, e As EventArgs) Handles ToolStripButton11.Click
        Try
            GESTION_DE_LA_CAISSE.Close()
            FICHE_ADHESION.Close()
            MEMBRE.Close()
            GESTION_DES_COTISATIONS.Close()
            USERS.Close()
            RAPPORT.Close()
            Impression_cotisation.Show()
            Impression_cotisation.MdiParent = Me

        Catch ex As Exception
            MsgBox("Erreur")
        End Try

    End Sub

    Private Sub ToolStripButton12_Click(sender As Object, e As EventArgs) Handles ToolStripButton12.Click
        Try
            FICHE_ADHESION.Close()
            MEMBRE.Close()
            GESTION_DES_COTISATIONS.Close()
            USERS.Close()
            RAPPORT.Close()
            Impression_cotisation.Close()
            CALCULATRICE.Show()
            CALCULATRICE.MdiParent = Me

        Catch ex As Exception
            MsgBox("Erreur")
        End Try
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        Try
            GESTION_DE_LA_CAISSE.Close()
            FICHE_ADHESION.Close()
            MEMBRE.Close()
            GESTION_DES_COTISATIONS.Close()
            USERS.Close()
            RAPPORT.Close()
            Impression_cotisation.Close()
            Email.Close()
            AIDE.Show()
            AIDE.MdiParent = Me

        Catch ex As Exception
            MsgBox("Erreur")
        End Try
    End Sub

    Private Sub Menuadmin_Click(sender As Object, e As EventArgs) Handles Menuadmin.Click
        Try
            GESTION_DE_LA_CAISSE.Close()
            FICHE_ADHESION.Close()
            MEMBRE.Close()
            GESTION_DES_COTISATIONS.Close()
            Impression_cotisation.Close()
            RAPPORT.Close()
            USERS.Show()
            USERS.MdiParent = Me
        Catch ex As Exception
            MsgBox("Erreur")
        End Try
    End Sub

    Private Sub LETTREENVOYEZToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try
            GESTION_DE_LA_CAISSE.Close()
            FICHE_ADHESION.Close()
            MEMBRE.Close()
            GESTION_DES_COTISATIONS.Close()
            Impression_cotisation.Close()
            RAPPORT.Close()
            USERS.Close()
            GESTION_DE_LETTRE.Show()
            GESTION_DE_LETTRE.MdiParent = Me
        Catch ex As Exception
            MsgBox("Erreur")
        End Try
    End Sub

    Private Sub FghhjjToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try
            GESTION_DE_LA_CAISSE.Close()
            FICHE_ADHESION.Close()
            MEMBRE.Close()
            GESTION_DES_COTISATIONS.Close()
            Impression_cotisation.Close()
            RAPPORT.Close()
            USERS.Close()
            GESTION_DE_LETTRE.Close()
            LETTRE_REUSSI.Show()
            LETTRE_REUSSI.MdiParent = Me
        Catch ex As Exception
            MsgBox("Erreur")
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            GESTION_DE_LA_CAISSE.Close()
            FICHE_ADHESION.Close()
            MEMBRE.Close()
            GESTION_DES_COTISATIONS.Close()
            USERS.Close()
            RAPPORT.Close()
            Impression_cotisation.Close()
            Email.Close()
            AIDE.Show()
            AIDE.MdiParent = Me
        Catch ex As Exception
            MsgBox("Erreur")
        End Try

    End Sub

    Private Sub ToolStripSplitButton1_Click(sender As Object, e As EventArgs) Handles ToolStripSplitButton1.Click
        Try
            GESTION_DE_LA_CAISSE.Close()
            FICHE_ADHESION.Close()
            MEMBRE.Close()
            GESTION_DES_COTISATIONS.Close()
            USERS.Close()
            RAPPORT.Close()
            Impression_cotisation.Close()
            Email.Show()
            Email.MdiParent = Me
        Catch ex As Exception
            MsgBox("Erreur")
        End Try

    End Sub
End Class