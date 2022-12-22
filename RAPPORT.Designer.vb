<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RAPPORT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RAPPORT))
        Me.Richtxt = New System.Windows.Forms.RichTextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.boutonfichier = New System.Windows.Forms.ToolStripSplitButton()
        Me.OuvrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnregistréToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnregistréSousToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.boutonedition = New System.Windows.Forms.ToolStripSplitButton()
        Me.CopierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CouperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CollerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnnulerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RétablirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.boutonpolice = New System.Windows.Forms.ToolStripSplitButton()
        Me.CouleurDeLaPoliceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CouleurDeFondToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CouleurDeFondToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menufichier = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton14 = New System.Windows.Forms.ToolStripButton()
        Me.Menupolice = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton15 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.menuedition = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton13 = New System.Windows.Forms.ToolStripButton()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Lblmessage = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        Me.Menufichier.SuspendLayout()
        Me.Menupolice.SuspendLayout()
        Me.menuedition.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Richtxt
        '
        Me.Richtxt.Location = New System.Drawing.Point(216, 174)
        Me.Richtxt.Name = "Richtxt"
        Me.Richtxt.Size = New System.Drawing.Size(686, 453)
        Me.Richtxt.TabIndex = 1
        Me.Richtxt.Text = ""
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.boutonfichier, Me.boutonedition, Me.boutonpolice})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(914, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'boutonfichier
        '
        Me.boutonfichier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.boutonfichier.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OuvrirToolStripMenuItem, Me.ModifierToolStripMenuItem, Me.EnregistréToolStripMenuItem1, Me.EnregistréSousToolStripMenuItem2, Me.ImprimerToolStripMenuItem1, Me.QuitterToolStripMenuItem})
        Me.boutonfichier.Image = CType(resources.GetObject("boutonfichier.Image"), System.Drawing.Image)
        Me.boutonfichier.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boutonfichier.Name = "boutonfichier"
        Me.boutonfichier.Size = New System.Drawing.Size(58, 22)
        Me.boutonfichier.Text = "Fichier"
        '
        'OuvrirToolStripMenuItem
        '
        Me.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        Me.OuvrirToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.OuvrirToolStripMenuItem.Text = "Ouvrir"
        '
        'ModifierToolStripMenuItem
        '
        Me.ModifierToolStripMenuItem.Name = "ModifierToolStripMenuItem"
        Me.ModifierToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ModifierToolStripMenuItem.Text = "Modifier"
        '
        'EnregistréToolStripMenuItem1
        '
        Me.EnregistréToolStripMenuItem1.Name = "EnregistréToolStripMenuItem1"
        Me.EnregistréToolStripMenuItem1.Size = New System.Drawing.Size(153, 22)
        Me.EnregistréToolStripMenuItem1.Text = "Enregistré"
        '
        'EnregistréSousToolStripMenuItem2
        '
        Me.EnregistréSousToolStripMenuItem2.Name = "EnregistréSousToolStripMenuItem2"
        Me.EnregistréSousToolStripMenuItem2.Size = New System.Drawing.Size(153, 22)
        Me.EnregistréSousToolStripMenuItem2.Text = "Enregistré sous"
        '
        'ImprimerToolStripMenuItem1
        '
        Me.ImprimerToolStripMenuItem1.Name = "ImprimerToolStripMenuItem1"
        Me.ImprimerToolStripMenuItem1.Size = New System.Drawing.Size(153, 22)
        Me.ImprimerToolStripMenuItem1.Text = "Imprimer"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'boutonedition
        '
        Me.boutonedition.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.boutonedition.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopierToolStripMenuItem, Me.CouperToolStripMenuItem, Me.CollerToolStripMenuItem, Me.AnnulerToolStripMenuItem, Me.RétablirToolStripMenuItem})
        Me.boutonedition.Image = CType(resources.GetObject("boutonedition.Image"), System.Drawing.Image)
        Me.boutonedition.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boutonedition.Name = "boutonedition"
        Me.boutonedition.Size = New System.Drawing.Size(60, 22)
        Me.boutonedition.Text = "Edition"
        '
        'CopierToolStripMenuItem
        '
        Me.CopierToolStripMenuItem.Name = "CopierToolStripMenuItem"
        Me.CopierToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.CopierToolStripMenuItem.Text = "Copier"
        '
        'CouperToolStripMenuItem
        '
        Me.CouperToolStripMenuItem.Name = "CouperToolStripMenuItem"
        Me.CouperToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.CouperToolStripMenuItem.Text = "Couper"
        '
        'CollerToolStripMenuItem
        '
        Me.CollerToolStripMenuItem.Name = "CollerToolStripMenuItem"
        Me.CollerToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.CollerToolStripMenuItem.Text = "Coller"
        '
        'AnnulerToolStripMenuItem
        '
        Me.AnnulerToolStripMenuItem.Name = "AnnulerToolStripMenuItem"
        Me.AnnulerToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.AnnulerToolStripMenuItem.Text = "annuler"
        '
        'RétablirToolStripMenuItem
        '
        Me.RétablirToolStripMenuItem.Name = "RétablirToolStripMenuItem"
        Me.RétablirToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.RétablirToolStripMenuItem.Text = "Rétablir"
        '
        'boutonpolice
        '
        Me.boutonpolice.BackColor = System.Drawing.Color.Red
        Me.boutonpolice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.boutonpolice.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CouleurDeLaPoliceToolStripMenuItem, Me.CouleurDeFondToolStripMenuItem, Me.CouleurDeFondToolStripMenuItem1})
        Me.boutonpolice.Image = CType(resources.GetObject("boutonpolice.Image"), System.Drawing.Image)
        Me.boutonpolice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boutonpolice.Name = "boutonpolice"
        Me.boutonpolice.Size = New System.Drawing.Size(55, 22)
        Me.boutonpolice.Text = "Police"
        '
        'CouleurDeLaPoliceToolStripMenuItem
        '
        Me.CouleurDeLaPoliceToolStripMenuItem.Name = "CouleurDeLaPoliceToolStripMenuItem"
        Me.CouleurDeLaPoliceToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.CouleurDeLaPoliceToolStripMenuItem.Text = "Modifier la police"
        '
        'CouleurDeFondToolStripMenuItem
        '
        Me.CouleurDeFondToolStripMenuItem.Name = "CouleurDeFondToolStripMenuItem"
        Me.CouleurDeFondToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.CouleurDeFondToolStripMenuItem.Text = "couleur de la police"
        '
        'CouleurDeFondToolStripMenuItem1
        '
        Me.CouleurDeFondToolStripMenuItem1.Name = "CouleurDeFondToolStripMenuItem1"
        Me.CouleurDeFondToolStripMenuItem1.Size = New System.Drawing.Size(177, 22)
        Me.CouleurDeFondToolStripMenuItem1.Text = "couleur de fond"
        '
        'Menufichier
        '
        Me.Menufichier.BackColor = System.Drawing.SystemColors.Control
        Me.Menufichier.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripButton14})
        Me.Menufichier.Location = New System.Drawing.Point(0, 25)
        Me.Menufichier.Name = "Menufichier"
        Me.Menufichier.Size = New System.Drawing.Size(914, 25)
        Me.Menufichier.TabIndex = 4
        Me.Menufichier.Text = "ToolStrip2"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripButton3.Text = "Ouvrir"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripButton4.Text = "Modifier"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripButton5.Text = "Enregistré"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(60, 22)
        Me.ToolStripButton6.Text = "Imprimer"
        '
        'ToolStripButton14
        '
        Me.ToolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton14.Image = CType(resources.GetObject("ToolStripButton14.Image"), System.Drawing.Image)
        Me.ToolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton14.Name = "ToolStripButton14"
        Me.ToolStripButton14.Size = New System.Drawing.Size(48, 22)
        Me.ToolStripButton14.Text = "Quitter"
        '
        'Menupolice
        '
        Me.Menupolice.BackColor = System.Drawing.SystemColors.Control
        Me.Menupolice.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton7, Me.ToolStripButton15, Me.ToolStripButton8})
        Me.Menupolice.Location = New System.Drawing.Point(0, 25)
        Me.Menupolice.Name = "Menupolice"
        Me.Menupolice.Size = New System.Drawing.Size(914, 25)
        Me.Menupolice.TabIndex = 5
        Me.Menupolice.Text = "ToolStrip2"
        Me.Menupolice.Visible = False
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(99, 22)
        Me.ToolStripButton7.Text = "Modifié la police"
        '
        'ToolStripButton15
        '
        Me.ToolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton15.Image = CType(resources.GetObject("ToolStripButton15.Image"), System.Drawing.Image)
        Me.ToolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton15.Name = "ToolStripButton15"
        Me.ToolStripButton15.Size = New System.Drawing.Size(116, 22)
        Me.ToolStripButton15.Text = "Couleur de la police"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(95, 22)
        Me.ToolStripButton8.Text = "couleur de fond"
        '
        'menuedition
        '
        Me.menuedition.BackColor = System.Drawing.Color.OrangeRed
        Me.menuedition.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton9, Me.ToolStripButton10, Me.ToolStripButton11, Me.ToolStripButton12, Me.ToolStripButton13})
        Me.menuedition.Location = New System.Drawing.Point(61, 0)
        Me.menuedition.Name = "menuedition"
        Me.menuedition.Size = New System.Drawing.Size(853, 25)
        Me.menuedition.TabIndex = 6
        Me.menuedition.Text = "ToolStrip2"
        Me.menuedition.Visible = False
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Size = New System.Drawing.Size(46, 22)
        Me.ToolStripButton9.Text = "Copier"
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), System.Drawing.Image)
        Me.ToolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripButton10.Text = "Couper"
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"), System.Drawing.Image)
        Me.ToolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.Size = New System.Drawing.Size(42, 22)
        Me.ToolStripButton11.Text = "Coller"
        '
        'ToolStripButton12
        '
        Me.ToolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton12.Image = CType(resources.GetObject("ToolStripButton12.Image"), System.Drawing.Image)
        Me.ToolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton12.Name = "ToolStripButton12"
        Me.ToolStripButton12.Size = New System.Drawing.Size(53, 22)
        Me.ToolStripButton12.Text = "Annuler"
        '
        'ToolStripButton13
        '
        Me.ToolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton13.Image = CType(resources.GetObject("ToolStripButton13.Image"), System.Drawing.Image)
        Me.ToolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton13.Name = "ToolStripButton13"
        Me.ToolStripButton13.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripButton13.Text = "Retablir"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Document au format RTF|*.rtf"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "ouvré le fichier"
        Me.OpenFileDialog1.Filter = "Document au format RTF|*.rtf"
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'FontDialog1
        '
        Me.FontDialog1.Color = System.Drawing.SystemColors.ControlText
        '
        'Lblmessage
        '
        Me.Lblmessage.BackColor = System.Drawing.SystemColors.Control
        Me.Lblmessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lblmessage.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblmessage.Location = New System.Drawing.Point(215, 114)
        Me.Lblmessage.Name = "Lblmessage"
        Me.Lblmessage.Size = New System.Drawing.Size(687, 54)
        Me.Lblmessage.TabIndex = 49
        Me.Lblmessage.Text = "LUTTE CONTRE LA MENDICITE DES HANDICAPEES DE KASUMBALESA"
        Me.Lblmessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Elephant", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(215, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(687, 56)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "RAPPORT DE L'ASSOCIATION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 7500
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.GESTION_ASSOCIATION.My.Resources.Resources.Logo_Template___Logo_1910001
        Me.PictureBox1.Location = New System.Drawing.Point(12, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(197, 274)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = Global.GESTION_ASSOCIATION.My.Resources.Resources.Logo_Template___Logo_12
        Me.PictureBox2.Location = New System.Drawing.Point(12, 341)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(197, 274)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 52
        Me.PictureBox2.TabStop = False
        '
        'RAPPORT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(914, 627)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lblmessage)
        Me.Controls.Add(Me.Menufichier)
        Me.Controls.Add(Me.Menupolice)
        Me.Controls.Add(Me.menuedition)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Richtxt)
        Me.Name = "RAPPORT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RAPPORT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Menufichier.ResumeLayout(False)
        Me.Menufichier.PerformLayout()
        Me.Menupolice.ResumeLayout(False)
        Me.Menupolice.PerformLayout()
        Me.menuedition.ResumeLayout(False)
        Me.menuedition.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Richtxt As System.Windows.Forms.RichTextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents boutonpolice As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents CouleurDeLaPoliceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CouleurDeFondToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents boutonedition As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents CopierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CouperToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CollerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnnulerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RétablirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menufichier As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents boutonfichier As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents OuvrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnregistréToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnregistréSousToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Menupolice As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents menuedition As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton9 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton10 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton11 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton12 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton13 As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents CouleurDeFondToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton14 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton15 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Lblmessage As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
