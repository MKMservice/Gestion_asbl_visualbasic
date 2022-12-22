<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listemembre
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listemembre))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MEMBREBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New GESTION_ASSOCIATION.DataSet1()
        Me.MEMBRETableAdapter = New GESTION_ASSOCIATION.DataSet1TableAdapters.MEMBRETableAdapter()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Cmbnom = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.txtsexe = New System.Windows.Forms.ToolStripComboBox()
        CType(Me.MEMBREBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 58)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(890, 532)
        Me.ReportViewer1.TabIndex = 0
        '
        'MEMBREBindingSource
        '
        Me.MEMBREBindingSource.DataMember = "MEMBRE"
        Me.MEMBREBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MEMBRETableAdapter
        '
        Me.MEMBRETableAdapter.ClearBeforeFill = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Yellow
        Me.ToolStrip1.Font = New System.Drawing.Font("Rockwell Extra Bold", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.Cmbnom, Me.ToolStripButton2, Me.ToolStripButton1, Me.txtsexe, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(914, 43)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Font = New System.Drawing.Font("Rockwell Extra Bold", 9.0!)
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(79, 40)
        Me.ToolStripButton1.Text = "Chercher"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(0, 40)
        '
        'Cmbnom
        '
        Me.Cmbnom.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Cmbnom.Font = New System.Drawing.Font("Rockwell", 9.0!)
        Me.Cmbnom.Name = "Cmbnom"
        Me.Cmbnom.Size = New System.Drawing.Size(130, 43)
        Me.Cmbnom.Text = "selectionner le nom"
        Me.Cmbnom.ToolTipText = "selectionner le nom"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Font = New System.Drawing.Font("Rockwell Extra Bold", 9.0!)
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(63, 40)
        Me.ToolStripButton2.Text = "Quitter"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton4.Font = New System.Drawing.Font("Rockwell Extra Bold", 9.0!)
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(79, 40)
        Me.ToolStripButton4.Text = "Chercher"
        '
        'txtsexe
        '
        Me.txtsexe.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtsexe.Font = New System.Drawing.Font("Rockwell", 9.0!)
        Me.txtsexe.Items.AddRange(New Object() {"F", "M"})
        Me.txtsexe.Name = "txtsexe"
        Me.txtsexe.Size = New System.Drawing.Size(130, 43)
        Me.txtsexe.Text = "selectionner le sexe"
        Me.txtsexe.ToolTipText = "selectionner le nom"
        '
        'listemembre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(914, 602)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "listemembre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LISTE MEMBRE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MEMBREBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MEMBREBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As GESTION_ASSOCIATION.DataSet1
    Friend WithEvents MEMBRETableAdapter As GESTION_ASSOCIATION.DataSet1TableAdapters.MEMBRETableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Cmbnom As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtsexe As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
End Class
