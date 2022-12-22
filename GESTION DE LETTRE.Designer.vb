<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GESTION_DE_LETTRE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GESTION_DE_LETTRE))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lblmessage = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txtdate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdestination = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtobjet = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txtcopie = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtref = New System.Windows.Forms.TextBox()
        Me.Id_membre = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.boutonfichier = New System.Windows.Forms.ToolStripButton()
        Me.boutonedition = New System.Windows.Forms.ToolStripButton()
        Me.boutonpolice = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
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
        Me.Lblmontant = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.MembreTableAdapter1 = New GESTION_ASSOCIATION.DataSet1TableAdapters.MEMBRETableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtlettre = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Menufichier.SuspendLayout()
        Me.Menupolice.SuspendLayout()
        Me.menuedition.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(257, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(645, 42)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "LETTRE ENVOYEZ DE L'ASSOCIATION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lblmessage
        '
        Me.Lblmessage.BackColor = System.Drawing.SystemColors.Control
        Me.Lblmessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lblmessage.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblmessage.Location = New System.Drawing.Point(257, 95)
        Me.Lblmessage.Name = "Lblmessage"
        Me.Lblmessage.Size = New System.Drawing.Size(645, 39)
        Me.Lblmessage.TabIndex = 52
        Me.Lblmessage.Text = "LUTTE CONTRE LA MENDICITE DES HANDICAPEES DE KASUMBALESA"
        Me.Lblmessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txtdate)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtdestination)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Txtobjet)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txtcopie)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txtref)
        Me.GroupBox1.Controls.Add(Me.Id_membre)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(245, 376)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu enregistrement"
        '
        'Txtdate
        '
        Me.Txtdate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Txtdate.Location = New System.Drawing.Point(95, 47)
        Me.Txtdate.Name = "Txtdate"
        Me.Txtdate.Size = New System.Drawing.Size(139, 23)
        Me.Txtdate.TabIndex = 56
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(50, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Date :"
        '
        'txtdestination
        '
        Me.txtdestination.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdestination.Location = New System.Drawing.Point(95, 295)
        Me.txtdestination.Multiline = True
        Me.txtdestination.Name = "txtdestination"
        Me.txtdestination.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtdestination.Size = New System.Drawing.Size(139, 70)
        Me.txtdestination.TabIndex = 48
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 327)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Envoyé à :"
        '
        'Txtobjet
        '
        Me.Txtobjet.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtobjet.Location = New System.Drawing.Point(95, 213)
        Me.Txtobjet.Multiline = True
        Me.Txtobjet.Name = "Txtobjet"
        Me.Txtobjet.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Txtobjet.Size = New System.Drawing.Size(139, 77)
        Me.Txtobjet.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Objet :"
        '
        'Txtcopie
        '
        Me.Txtcopie.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcopie.Location = New System.Drawing.Point(95, 74)
        Me.Txtcopie.Multiline = True
        Me.Txtcopie.Name = "Txtcopie"
        Me.Txtcopie.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Txtcopie.Size = New System.Drawing.Size(139, 135)
        Me.Txtcopie.TabIndex = 45
        Me.Txtcopie.Text = "Entrée le nom"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-1, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 45)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Copie pour information à :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txtref
        '
        Me.Txtref.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtref.Location = New System.Drawing.Point(95, 19)
        Me.Txtref.Name = "Txtref"
        Me.Txtref.Size = New System.Drawing.Size(139, 23)
        Me.Txtref.TabIndex = 44
        '
        'Id_membre
        '
        Me.Id_membre.AutoSize = True
        Me.Id_membre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_membre.Location = New System.Drawing.Point(19, 22)
        Me.Id_membre.Name = "Id_membre"
        Me.Id_membre.Size = New System.Drawing.Size(74, 13)
        Me.Id_membre.TabIndex = 43
        Me.Id_membre.Text = "Reference :"
        '
        'Timer1
        '
        Me.Timer1.Interval = 7500
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button9)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.Button10)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(4, 504)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(247, 121)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Menu de navigation"
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Transparent
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(80, 49)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(95, 29)
        Me.Button9.TabIndex = 23
        Me.Button9.Text = "Impression"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(5, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 29)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "nouveau"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button8.Location = New System.Drawing.Point(178, 81)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(63, 29)
        Me.Button8.TabIndex = 11
        Me.Button8.Text = ">>"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Transparent
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button10.Location = New System.Drawing.Point(175, 49)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(67, 29)
        Me.Button10.TabIndex = 24
        Me.Button10.Text = "Retour"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button7.Location = New System.Drawing.Point(120, 81)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(58, 29)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = ">"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(167, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 29)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "modifier"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button6.Location = New System.Drawing.Point(68, 81)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(53, 29)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "<"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(79, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 29)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "ajouter"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(5, 81)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(63, 29)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "<<"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(5, 49)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(76, 29)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "suprimer"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.boutonfichier, Me.boutonedition, Me.boutonpolice, Me.ToolStripTextBox1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(911, 25)
        Me.ToolStrip1.TabIndex = 57
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'boutonfichier
        '
        Me.boutonfichier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.boutonfichier.Image = CType(resources.GetObject("boutonfichier.Image"), System.Drawing.Image)
        Me.boutonfichier.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boutonfichier.Name = "boutonfichier"
        Me.boutonfichier.Size = New System.Drawing.Size(46, 22)
        Me.boutonfichier.Text = "Fichier"
        '
        'boutonedition
        '
        Me.boutonedition.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.boutonedition.Image = CType(resources.GetObject("boutonedition.Image"), System.Drawing.Image)
        Me.boutonedition.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boutonedition.Name = "boutonedition"
        Me.boutonedition.Size = New System.Drawing.Size(48, 22)
        Me.boutonedition.Text = "Edition"
        '
        'boutonpolice
        '
        Me.boutonpolice.BackColor = System.Drawing.SystemColors.Control
        Me.boutonpolice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.boutonpolice.Image = CType(resources.GetObject("boutonpolice.Image"), System.Drawing.Image)
        Me.boutonpolice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boutonpolice.Name = "boutonpolice"
        Me.boutonpolice.Size = New System.Drawing.Size(43, 22)
        Me.boutonpolice.Text = "Police"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'Menufichier
        '
        Me.Menufichier.BackColor = System.Drawing.SystemColors.Control
        Me.Menufichier.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripButton14})
        Me.Menufichier.Location = New System.Drawing.Point(0, 25)
        Me.Menufichier.Name = "Menufichier"
        Me.Menufichier.Size = New System.Drawing.Size(911, 25)
        Me.Menufichier.TabIndex = 58
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
        Me.Menupolice.Location = New System.Drawing.Point(0, 50)
        Me.Menupolice.Name = "Menupolice"
        Me.Menupolice.Size = New System.Drawing.Size(911, 25)
        Me.Menupolice.TabIndex = 59
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
        Me.menuedition.BackColor = System.Drawing.SystemColors.Control
        Me.menuedition.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton9, Me.ToolStripButton10, Me.ToolStripButton11, Me.ToolStripButton12, Me.ToolStripButton13})
        Me.menuedition.Location = New System.Drawing.Point(0, 50)
        Me.menuedition.Name = "menuedition"
        Me.menuedition.Size = New System.Drawing.Size(911, 25)
        Me.menuedition.TabIndex = 60
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
        'Lblmontant
        '
        Me.Lblmontant.AutoSize = True
        Me.Lblmontant.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblmontant.Location = New System.Drawing.Point(49, 27)
        Me.Lblmontant.Name = "Lblmontant"
        Me.Lblmontant.Size = New System.Drawing.Size(105, 34)
        Me.Lblmontant.TabIndex = 61
        Me.Lblmontant.Text = "Label5"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Lblmontant)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 45)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(247, 77)
        Me.GroupBox3.TabIndex = 61
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Recaptilatif"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Document au format RTF|*.rtf"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'FontDialog1
        '
        Me.FontDialog1.Color = System.Drawing.SystemColors.ControlText
        '
        'MembreTableAdapter1
        '
        Me.MembreTableAdapter1.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(276, 214)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(602, 150)
        Me.DataGridView1.TabIndex = 62
        '
        'txtlettre
        '
        Me.txtlettre.Location = New System.Drawing.Point(257, 137)
        Me.txtlettre.Name = "txtlettre"
        Me.txtlettre.Size = New System.Drawing.Size(644, 488)
        Me.txtlettre.TabIndex = 63
        Me.txtlettre.Text = ""
        '
        'GESTION_DE_LETTRE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 627)
        Me.Controls.Add(Me.txtlettre)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Menupolice)
        Me.Controls.Add(Me.menuedition)
        Me.Controls.Add(Me.Menufichier)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Lblmessage)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GESTION_DE_LETTRE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GESTION_DE_LETTRE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Menufichier.ResumeLayout(False)
        Me.Menufichier.PerformLayout()
        Me.Menupolice.ResumeLayout(False)
        Me.Menupolice.PerformLayout()
        Me.menuedition.ResumeLayout(False)
        Me.menuedition.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lblmessage As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Txtdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtdestination As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txtobjet As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txtcopie As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txtref As System.Windows.Forms.TextBox
    Friend WithEvents Id_membre As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Menufichier As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton14 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Menupolice As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton15 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents menuedition As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton9 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton10 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton11 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton12 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton13 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Lblmontant As System.Windows.Forms.Label
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents boutonfichier As System.Windows.Forms.ToolStripButton
    Friend WithEvents boutonedition As System.Windows.Forms.ToolStripButton
    Friend WithEvents boutonpolice As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents MembreTableAdapter1 As GESTION_ASSOCIATION.DataSet1TableAdapters.MEMBRETableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtlettre As System.Windows.Forms.RichTextBox
End Class
