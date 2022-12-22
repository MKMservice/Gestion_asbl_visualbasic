Imports System.Data.OleDb
Public Class Impression_des_caisse

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Me.Close()
        GESTION_DE_LA_CAISSE.Show()
        GESTION_DE_LA_CAISSE.MdiParent = ACCEUIL
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim ds As New DataTable
        Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
        Dim cmd As New OleDbCommand("select*from CAISSE where caissier like '%" + cmbnom.Text + "%'", cn)
        Dim da As New OleDbDataAdapter
        da.SelectCommand = cmd
        da.Fill(ds)
        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = Application.StartupPath & "\CAISSE.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds))
        End With
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub Impression_des_caisse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dr As OleDbDataReader
        Dim ds As New DataTable
        Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
        Dim cmd As New OleDbCommand("select*from CAISSE", cn)
        Dim da As New OleDbDataAdapter
        da.SelectCommand = cmd
        da.Fill(ds)
        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = Application.StartupPath & "\CAISSE.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds))
        End With
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
        cmd.CommandText = "select*from CAISSE"
        cmd.Connection = cn
        cn.Open()
        dr = cmd.ExecuteReader
        While dr.Read
            cmbnom.Items.Add(dr.GetValue(2))
        End While
        dr.Close()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Try
            If D1.Text = "" Then
                MsgBox("veuillez inserez la première date", MsgBoxStyle.Exclamation, "GESTION ASSOCIATION/IMPRESSION")
            ElseIf D2.Text = "" Then
                MsgBox("veuillez inserez la deuxième date", MsgBoxStyle.Exclamation, "GESTION ASSOCIATION/IMPRESSION")
            Else
                Dim ds As New DataTable
                Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
                Dim cmd As New OleDbCommand("select*from CAISSE where Deposer_le  between #" & D1.Text & "# and #" & D2.Text & "#", cn)
                Dim da As New OleDbDataAdapter
                da.SelectCommand = cmd
                da.Fill(ds)
                With Me.ReportViewer1.LocalReport
                    .DataSources.Clear()
                    .ReportPath = Application.StartupPath & "\CAISSE.rdlc"
                    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds))
                End With
                Me.ReportViewer1.RefreshReport()
            End If
        Catch ex As Exception
            MsgBox("ERREUR", vbCritical, "EXCEPTION")
        End Try
    End Sub
End Class