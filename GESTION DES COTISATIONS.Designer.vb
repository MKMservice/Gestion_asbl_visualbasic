<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GESTION_DES_COTISATIONS
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Txtdate = New System.Windows.Forms.DateTimePicker()
        Me.Txtnom = New System.Windows.Forms.ComboBox()
        Me.txtnmontant = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtprenom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtpostnom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtid_ordre = New System.Windows.Forms.TextBox()
        Me.Id_Ordre = New System.Windows.Forms.Label()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Lblmessage = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.D2 = New System.Windows.Forms.TextBox()
        Me.D1 = New System.Windows.Forms.TextBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Txtrecherche2 = New System.Windows.Forms.TextBox()
        Me.Txtrecherche4 = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Txtrecherche1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Lblmontant = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txtrecherche = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Txtdate)
        Me.Panel1.Controls.Add(Me.Txtnom)
        Me.Panel1.Controls.Add(Me.txtnmontant)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtprenom)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Txtpostnom)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Txtid_ordre)
        Me.Panel1.Controls.Add(Me.Id_Ordre)
        Me.Panel1.Location = New System.Drawing.Point(1, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(233, 229)
        Me.Panel1.TabIndex = 3
        '
        'Txtdate
        '
        Me.Txtdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Txtdate.Location = New System.Drawing.Point(79, 49)
        Me.Txtdate.Name = "Txtdate"
        Me.Txtdate.Size = New System.Drawing.Size(139, 20)
        Me.Txtdate.TabIndex = 44
        '
        'Txtnom
        '
        Me.Txtnom.FormattingEnabled = True
        Me.Txtnom.Location = New System.Drawing.Point(78, 81)
        Me.Txtnom.Name = "Txtnom"
        Me.Txtnom.Size = New System.Drawing.Size(137, 21)
        Me.Txtnom.TabIndex = 5
        Me.Txtnom.Text = "selectionner le nom"
        '
        'txtnmontant
        '
        Me.txtnmontant.Location = New System.Drawing.Point(79, 188)
        Me.txtnmontant.Name = "txtnmontant"
        Me.txtnmontant.Size = New System.Drawing.Size(108, 20)
        Me.txtnmontant.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(187, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "CDF"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 191)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Montant"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(39, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Date"
        '
        'txtprenom
        '
        Me.txtprenom.Location = New System.Drawing.Point(78, 152)
        Me.txtprenom.Name = "txtprenom"
        Me.txtprenom.ReadOnly = True
        Me.txtprenom.Size = New System.Drawing.Size(139, 20)
        Me.txtprenom.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Prénom"
        '
        'Txtpostnom
        '
        Me.Txtpostnom.Location = New System.Drawing.Point(78, 114)
        Me.Txtpostnom.Name = "Txtpostnom"
        Me.Txtpostnom.ReadOnly = True
        Me.Txtpostnom.Size = New System.Drawing.Size(139, 20)
        Me.Txtpostnom.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Post-nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nom"
        '
        'Txtid_ordre
        '
        Me.Txtid_ordre.Location = New System.Drawing.Point(78, 14)
        Me.Txtid_ordre.Name = "Txtid_ordre"
        Me.Txtid_ordre.Size = New System.Drawing.Size(139, 20)
        Me.Txtid_ordre.TabIndex = 1
        '
        'Id_Ordre
        '
        Me.Id_Ordre.AutoSize = True
        Me.Id_Ordre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_Ordre.Location = New System.Drawing.Point(20, 17)
        Me.Id_Ordre.Name = "Id_Ordre"
        Me.Id_Ordre.Size = New System.Drawing.Size(53, 13)
        Me.Id_Ordre.TabIndex = 0
        Me.Id_Ordre.Text = "Id Ordre"
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.SystemColors.Control
        Me.Button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Location = New System.Drawing.Point(79, 51)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(86, 29)
        Me.Button14.TabIndex = 71
        Me.Button14.Text = "Impression"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Lblmessage
        '
        Me.Lblmessage.BackColor = System.Drawing.SystemColors.Control
        Me.Lblmessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lblmessage.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblmessage.Location = New System.Drawing.Point(237, 162)
        Me.Lblmessage.Name = "Lblmessage"
        Me.Lblmessage.Size = New System.Drawing.Size(671, 67)
        Me.Lblmessage.TabIndex = 45
        Me.Lblmessage.Text = "LUTTE CONTRE LA MENDICITE DES HANDICAPEES DE KASUMBALESA"
        Me.Lblmessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Button9)
        Me.Panel4.Controls.Add(Me.Button13)
        Me.Panel4.Controls.Add(Me.Label21)
        Me.Panel4.Controls.Add(Me.Label37)
        Me.Panel4.Controls.Add(Me.D2)
        Me.Panel4.Controls.Add(Me.D1)
        Me.Panel4.Controls.Add(Me.Button12)
        Me.Panel4.Controls.Add(Me.Button11)
        Me.Panel4.Controls.Add(Me.Txtrecherche2)
        Me.Panel4.Controls.Add(Me.Txtrecherche4)
        Me.Panel4.Controls.Add(Me.Label22)
        Me.Panel4.Controls.Add(Me.Label19)
        Me.Panel4.Controls.Add(Me.Txtrecherche1)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel4.ForeColor = System.Drawing.Color.Red
        Me.Panel4.Location = New System.Drawing.Point(239, 267)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(668, 86)
        Me.Panel4.TabIndex = 44
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(561, 4)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(100, 23)
        Me.Button9.TabIndex = 77
        Me.Button9.Text = "Load Search"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.SystemColors.Control
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.Color.Black
        Me.Button13.Location = New System.Drawing.Point(189, 7)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(152, 23)
        Me.Button13.TabIndex = 76
        Me.Button13.Text = "rehercher le prénom"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(487, 36)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(73, 15)
        Me.Label21.TabIndex = 75
        Me.Label21.Text = "Jusqu'à le"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(356, 37)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(23, 15)
        Me.Label37.TabIndex = 74
        Me.Label37.Text = "de"
        '
        'D2
        '
        Me.D2.Location = New System.Drawing.Point(561, 33)
        Me.D2.Name = "D2"
        Me.D2.Size = New System.Drawing.Size(100, 20)
        Me.D2.TabIndex = 73
        '
        'D1
        '
        Me.D1.Location = New System.Drawing.Point(385, 34)
        Me.D1.Name = "D1"
        Me.D1.Size = New System.Drawing.Size(100, 20)
        Me.D1.TabIndex = 72
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.SystemColors.Control
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.Color.Black
        Me.Button12.Location = New System.Drawing.Point(370, 4)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(179, 24)
        Me.Button12.TabIndex = 71
        Me.Button12.Text = "date"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.SystemColors.Control
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.Black
        Me.Button11.Location = New System.Drawing.Point(21, 7)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(132, 23)
        Me.Button11.TabIndex = 70
        Me.Button11.Text = "rehercher le nom"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Txtrecherche2
        '
        Me.Txtrecherche2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtrecherche2.ForeColor = System.Drawing.Color.DimGray
        Me.Txtrecherche2.Location = New System.Drawing.Point(225, 33)
        Me.Txtrecherche2.Name = "Txtrecherche2"
        Me.Txtrecherche2.Size = New System.Drawing.Size(123, 20)
        Me.Txtrecherche2.TabIndex = 47
        Me.Txtrecherche2.Text = "rehercher le prénom"
        Me.Txtrecherche2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txtrecherche4
        '
        Me.Txtrecherche4.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Txtrecherche4.Location = New System.Drawing.Point(327, 57)
        Me.Txtrecherche4.Name = "Txtrecherche4"
        Me.Txtrecherche4.Size = New System.Drawing.Size(130, 20)
        Me.Txtrecherche4.TabIndex = 44
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(202, 60)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(123, 15)
        Me.Label22.TabIndex = 43
        Me.Label22.Text = "Date de cotisation"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(168, 34)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(57, 15)
        Me.Label19.TabIndex = 23
        Me.Label19.Text = "Prénom"
        '
        'Txtrecherche1
        '
        Me.Txtrecherche1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtrecherche1.ForeColor = System.Drawing.Color.DimGray
        Me.Txtrecherche1.Location = New System.Drawing.Point(46, 32)
        Me.Txtrecherche1.Name = "Txtrecherche1"
        Me.Txtrecherche1.Size = New System.Drawing.Size(116, 20)
        Me.Txtrecherche1.TabIndex = 24
        Me.Txtrecherche1.Text = "rehercher le nom"
        Me.Txtrecherche1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(3, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 15)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Nom"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Font = New System.Drawing.Font("Lucida Bright", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(238, 235)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(670, 29)
        Me.Label20.TabIndex = 40
        Me.Label20.Text = "MENU DE RECHERCHE"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Transparent
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button10.Location = New System.Drawing.Point(165, 51)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(67, 29)
        Me.Button10.TabIndex = 24
        Me.Button10.Text = "Retour"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button8.Location = New System.Drawing.Point(178, 82)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(53, 29)
        Me.Button8.TabIndex = 11
        Me.Button8.Text = ">>"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button7.Location = New System.Drawing.Point(110, 82)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(65, 29)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = ">"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button6.Location = New System.Drawing.Point(54, 81)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(53, 29)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "<"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(0, 81)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(53, 29)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "<<"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(1, 20)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 29)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "nouveau"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(-1, 51)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 29)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "suprimer"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(75, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 29)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "ajouter"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(159, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 29)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "modifier"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Lblmontant)
        Me.Panel3.Location = New System.Drawing.Point(237, 49)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(671, 110)
        Me.Panel3.TabIndex = 46
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(208, 10)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(264, 28)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "RECAPTILATIF DES ACTIVITES"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(350, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 42)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "CDF"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lblmontant
        '
        Me.Lblmontant.BackColor = System.Drawing.Color.Transparent
        Me.Lblmontant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lblmontant.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblmontant.Location = New System.Drawing.Point(207, 42)
        Me.Lblmontant.Name = "Lblmontant"
        Me.Lblmontant.Size = New System.Drawing.Size(150, 42)
        Me.Lblmontant.TabIndex = 14
        Me.Lblmontant.Text = "000000"
        Me.Lblmontant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 7500
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(1, 359)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Size = New System.Drawing.Size(907, 234)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Button10)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button14)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 238)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(233, 115)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MENU DE NAVIGATION"
        '
        'Label18
        '
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Font = New System.Drawing.Font("Lucida Bright", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(238, 4)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(669, 39)
        Me.Label18.TabIndex = 73
        Me.Label18.Text = "GESTION DE LA COTISATION DE L'ASSOCIATION "
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Lime
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Txtrecherche)
        Me.Panel2.Location = New System.Drawing.Point(2, 599)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(905, 34)
        Me.Panel2.TabIndex = 74
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Yellow
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(419, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 26)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "CDF"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(13, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(217, 28)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "TOTAL SUR LA RECHERCHE"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txtrecherche
        '
        Me.Txtrecherche.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Txtrecherche.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtrecherche.ForeColor = System.Drawing.SystemColors.Info
        Me.Txtrecherche.Location = New System.Drawing.Point(233, 3)
        Me.Txtrecherche.Multiline = True
        Me.Txtrecherche.Name = "Txtrecherche"
        Me.Txtrecherche.Size = New System.Drawing.Size(182, 28)
        Me.Txtrecherche.TabIndex = 0
        Me.Txtrecherche.Text = "000000000"
        Me.Txtrecherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GESTION_DES_COTISATIONS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(914, 631)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Lblmessage)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label20)
        Me.Name = "GESTION_DES_COTISATIONS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GESTION_DES_COTISATIONS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Txtdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Txtnom As System.Windows.Forms.ComboBox
    Friend WithEvents txtnmontant As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtprenom As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txtpostnom As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txtid_ordre As System.Windows.Forms.TextBox
    Friend WithEvents Id_Ordre As System.Windows.Forms.Label
    Friend WithEvents Lblmessage As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Txtrecherche2 As System.Windows.Forms.TextBox
    Friend WithEvents Txtrecherche4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Txtrecherche1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Lblmontant As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents D2 As System.Windows.Forms.TextBox
    Friend WithEvents D1 As System.Windows.Forms.TextBox
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txtrecherche As System.Windows.Forms.TextBox
End Class
