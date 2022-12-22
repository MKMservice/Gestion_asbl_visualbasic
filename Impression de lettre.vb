Imports System.Data.OleDb

Public Class Impression_de_lettre

    Private Sub Impression_de_lettre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dr As OleDbDataReader
        Dim ds As New DataTable
        Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
        Dim cmd As New OleDbCommand("select*from lettre", cn)
        Dim da As New OleDbDataAdapter
        da.SelectCommand = cmd
        da.Fill(ds)
        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = Application.StartupPath & "\lettre envoyer.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds))
        End With
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
        cmd.CommandText = "select*from lettre"
        cmd.Connection = cn
        cn.Open()
        dr = cmd.ExecuteReader
        While dr.Read
            cmbnom.Items.Add(dr.GetValue(2))
        End While
        dr.Close()

    End Sub
End Class