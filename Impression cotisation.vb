Imports System.Data.OleDb
Public Class Impression_cotisation
    Private Sub Impression_cotisation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dr As OleDbDataReader
        Dim ds As New DataTable
        Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
        Dim cmd As New OleDbCommand("select*from COTISATION", cn)
        Dim da As New OleDbDataAdapter
        da.SelectCommand = cmd
        da.Fill(ds)
        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = Application.StartupPath & "\COTISATION.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds))
        End With
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
        cmd.CommandText = "select*from COTISATION"
        cmd.Connection = cn
        cn.Open()
        dr = cmd.ExecuteReader
        While dr.Read
            cmbnom.Items.Add(dr.GetValue(2))
        End While
        dr.Close()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Me.Close()
        GESTION_DES_COTISATIONS.Show()
        GESTION_DES_COTISATIONS.MdiParent = ACCEUIL
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim ds As New DataTable
        Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
        Dim cmd As New OleDbCommand("select*from COTISATION where nom like '%" + cmbnom.Text + "%'", cn)
        Dim da As New OleDbDataAdapter
        da.SelectCommand = cmd
        da.Fill(ds)
        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = Application.StartupPath & "\COTISATION.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds))
        End With
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If D1.Text = "" Then
            MsgBox("Veuillez inserer la date de depart celle d'arriver", MsgBoxStyle.Exclamation, "Recherche de date")
        ElseIf D1.Text = "Entrée 1er date" Then
            MsgBox("Veuillez inserer la date de depart celle d'arriver", MsgBoxStyle.Exclamation, "Recherche de date")
        ElseIf D2.Text = "Entrée 2ème date" Then
            MsgBox("Veuillez Entrée 2ème date", MsgBoxStyle.Exclamation, "Recherche de date")
        Else
            Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
            Dim cmd1 As New OleDbCommand("select*from cotisation where cotise  between #" & D1.Text & "# and #" & D2.Text & "#", cn)
            Dim da As New OleDbDataAdapter
            Dim dt As New DataTable
            da.SelectCommand = cmd1
            da.Fill(dt)
            With Me.ReportViewer1.LocalReport
                .DataSources.Clear()
                .ReportPath = Application.StartupPath & "\COTISATION.rdlc"
                .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
            End With
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub


    Private Sub cmbnom_Enter(sender As Object, e As EventArgs) Handles cmbnom.Enter
        If cmbnom.Text = "selectioner le nom" Then
            cmbnom.Text = ""
            cmbnom.ForeColor = Color.Black
        End If
    End Sub

    Private Sub cmbnom_Leave(sender As Object, e As EventArgs) Handles cmbnom.Leave
        If cmbnom.Text = "" Then
            cmbnom.Text = "selectioner le nom"
            cmbnom.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub D1_Click(sender As Object, e As EventArgs) Handles D1.Click

    End Sub

    Private Sub D1_Enter(sender As Object, e As EventArgs) Handles D1.Enter
        If D1.Text = "Entrée 1er date" Then
            D1.Text = ""
            D1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub D1_Leave(sender As Object, e As EventArgs) Handles D1.Leave
        If D1.Text = "" Then
            D1.Text = "Entrée 1er date"
            D1.ForeColor = Color.Silver
        End If

    End Sub
    Private Sub D2_Enter(sender As Object, e As EventArgs) Handles D2.Enter
        If D2.Text = "Entrée 2ème date" Then
            D2.Text = ""
            D2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub D2_Leave(sender As Object, e As EventArgs) Handles D2.Leave
        If D2.Text = "" Then
            D2.Text = "Entrée 2ème date"
            D2.ForeColor = Color.Silver
        End If
    End Sub
End Class