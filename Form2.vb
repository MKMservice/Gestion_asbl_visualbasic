Imports System.Data.OleDb
Public Class listemembre

    Private Sub listemembre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dr As OleDbDataReader
        Dim ds As New DataTable
        Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
        Dim cmd As New OleDbCommand("select*from FICHE", cn)
        Dim da As New OleDbDataAdapter
        da.SelectCommand = cmd
        da.Fill(ds)
        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = Application.StartupPath & "\LISTEMEMBRE.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds))
        End With
        Me.ReportViewer1.RefreshReport()
        cmd.CommandText = "select*from FICHE"
        cmd.Connection = cn
        cn.Open()
        dr = cmd.ExecuteReader
        While dr.Read
            Cmbnom.Items.Add(dr.GetValue(1))
        End While
        dr.Close()
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
        FICHE_ADHESION.Show()
        FICHE_ADHESION.MdiParent = ACCEUIL
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            Dim ds As New DataTable
            Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
            Dim cmd As New OleDbCommand("select*from FICHE where nom like '%" + Cmbnom.Text + "%'", cn)
            Dim da As New OleDbDataAdapter
            da.SelectCommand = cmd
            da.Fill(ds)
            With Me.ReportViewer1.LocalReport
                .DataSources.Clear()
                .ReportPath = Application.StartupPath & "\LISTEMEMBRE.rdlc"
                .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds))
            End With
            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception
            MsgBox("ERREUR", vbCritical, "EXCEPTION")
        End Try
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Try
            Dim ds As New DataTable
            Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
            Dim cmd As New OleDbCommand("select*from FICHE where sexe like '%" + txtsexe.Text + "%'", cn)
            Dim da As New OleDbDataAdapter
            da.SelectCommand = cmd
            da.Fill(ds)
            With Me.ReportViewer1.LocalReport
                .DataSources.Clear()
                .ReportPath = Application.StartupPath & "\LISTEMEMBRE.rdlc"
                .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds))
            End With
            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception
            MsgBox("ERREUR", vbCritical, "EXCEPTION")
        End Try

    End Sub
End Class