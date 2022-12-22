Public Class RAPPORT


    Private Sub QuitterToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        '==================================================================================================================
        'procedure de quitter la gestion des membres
        '=================================================================================================================
        Me.Close()
        ACCEUIL.Show()
    End Sub

    Private Sub ToolStripSplitButton2_ButtonClick(sender As Object, e As EventArgs) Handles boutonfichier.ButtonClick
        boutonfichier.ForeColor = Color.Red
        Menufichier.Visible = True
        Menupolice.Visible = False
        menuedition.Visible = False
        boutonpolice.ForeColor = Color.Black
        boutonedition.ForeColor = Color.Black

    End Sub

    Private Sub ToolStripButton1_ButtonClick(sender As Object, e As EventArgs) Handles boutonpolice.ButtonClick
        boutonpolice.ForeColor = Color.Red
        Menupolice.Visible = True
        Menufichier.Visible = False
        menuedition.Visible = False
        boutonfichier.ForeColor = Color.Black
        boutonedition.forecolor = Color.Black
    End Sub

    Private Sub ToolStripButton2_ButtonClick(sender As Object, e As EventArgs) Handles boutonedition.ButtonClick
        boutonedition.ForeColor = Color.Red
        menuedition.Visible = True
        Menupolice.Visible = False
        Menufichier.Visible = False
        boutonfichier.ForeColor = Color.Black
        boutonpolice.ForeColor = Color.Black

    End Sub

    Private Sub OuvrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = 1 Then
            Richtxt.LoadFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub EnregistréToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EnregistréToolStripMenuItem1.Click
        If SaveFileDialog1.ShowDialog = 1 Then
            Richtxt.SaveFile(SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub ImprimerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ImprimerToolStripMenuItem1.Click
        If MsgBox("cliquer sur oui pour avoir l'aperçu, et sur non pour ne pas l'avoir.", MsgBoxStyle.YesNo, "Impression") = MsgBoxResult.Yes Then
            PrintPreviewDialog1.ShowDialog()
        Else
            If PrintDialog1.ShowDialog = 1 Then
                PrintDocument1.Print()
            End If
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(Richtxt.Text, Richtxt.SelectionFont, Brushes.Black, 100, 100)
    End Sub

    Private Sub CouleurDeFondToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CouleurDeFondToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = 1 Then
            Richtxt.SelectionColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub CouleurDeLaPoliceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CouleurDeLaPoliceToolStripMenuItem.Click
        If FontDialog1.ShowDialog = 1 Then
            Richtxt.SelectionFont = FontDialog1.Font
        End If
    End Sub

    Private Sub CouleurDeFondToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CouleurDeFondToolStripMenuItem1.Click
        If ColorDialog1.ShowDialog = 1 Then
            Richtxt.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub CopierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopierToolStripMenuItem.Click
        Richtxt.Copy()
    End Sub

    Private Sub CouperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CouperToolStripMenuItem.Click
        Richtxt.Cut()
    End Sub

    Private Sub CollerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CollerToolStripMenuItem.Click
        Richtxt.Paste()
    End Sub

    Private Sub AnnulerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnnulerToolStripMenuItem.Click
        Richtxt.Undo()
    End Sub

    Private Sub RétablirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RétablirToolStripMenuItem.Click
        Richtxt.Redo()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        If OpenFileDialog1.ShowDialog = 1 Then
            Richtxt.LoadFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub ModifierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        If SaveFileDialog1.ShowDialog = 1 Then
            Richtxt.SaveFile(SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        If MsgBox("cliquer sur oui pour avoir l'aperçu, et sur non pour ne pas l'avoir.", MsgBoxStyle.YesNo, "Impression") = MsgBoxResult.Yes Then
            PrintPreviewDialog1.ShowDialog()
        Else
            If PrintDialog1.ShowDialog = 1 Then
                PrintDocument1.Print()
            End If
        End If
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Me.Close()
        ACCEUIL.Show()
    End Sub

    Private Sub ToolStripButton14_Click(sender As Object, e As EventArgs) Handles ToolStripButton14.Click
        Me.Close()
        DOCUMENTATION.Show()
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        If FontDialog1.ShowDialog = 1 Then
            Richtxt.SelectionFont = FontDialog1.Font
        End If
    End Sub

    Private Sub ToolStripButton15_Click(sender As Object, e As EventArgs) Handles ToolStripButton15.Click
        If ColorDialog1.ShowDialog = 1 Then
            Richtxt.SelectionColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        If ColorDialog1.ShowDialog = 1 Then
            Richtxt.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        Richtxt.Copy()
    End Sub

    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles ToolStripButton10.Click
        Richtxt.Cut()
    End Sub

    Private Sub ToolStripButton11_Click(sender As Object, e As EventArgs) Handles ToolStripButton11.Click
        Richtxt.Paste()
    End Sub

    Private Sub ToolStripButton12_Click(sender As Object, e As EventArgs) Handles ToolStripButton12.Click
        Richtxt.Undo()
    End Sub

    Private Sub ToolStripButton13_Click(sender As Object, e As EventArgs) Handles ToolStripButton13.Click
        Richtxt.Redo()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Lblmessage.Text = "LUTTE CONTRE LA MENDICITE DES HANDICAPEES DE KASUMBALESA" Then
            Lblmessage.BackColor = Color.Lime
            Lblmessage.ForeColor = Color.Black
            Lblmessage.Text = "L'ASSOCIATION DES HANDICAPEES TRANSITAIRES DE KASUMBALESA"
        ElseIf Lblmessage.Text = "L'ASSOCIATION DES HANDICAPEES TRANSITAIRES DE KASUMBALESA" Then
            Lblmessage.BackColor = Color.Aqua
            Lblmessage.ForeColor = Color.Red
            Lblmessage.Text = "LUTTE CONTRE LA MENDICITE DES HANDICAPEES DE KASUMBALESA"
        End If


    End Sub

    Private Sub RAPPORT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'demarer le timer 
        Timer1.Start()

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click

    End Sub
End Class