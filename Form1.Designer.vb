<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CONNEXION
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
        Me.txtmegs = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtpass = New System.Windows.Forms.TextBox()
        Me.Txtprenom = New System.Windows.Forms.TextBox()
        Me.Txtnom = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Pr = New System.Windows.Forms.ProgressBar()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lbllongin = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtmegs
        '
        Me.txtmegs.BackColor = System.Drawing.SystemColors.Control
        Me.txtmegs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmegs.Location = New System.Drawing.Point(1, 216)
        Me.txtmegs.Name = "txtmegs"
        Me.txtmegs.Size = New System.Drawing.Size(335, 22)
        Me.txtmegs.TabIndex = 21
        Me.txtmegs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(3, 244)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 41)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Annuler"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(240, 244)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 41)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Connexion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(123, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Password :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(134, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Prénom :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(134, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Nom :"
        '
        'Txtpass
        '
        Me.Txtpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Txtpass.Location = New System.Drawing.Point(209, 115)
        Me.Txtpass.Name = "Txtpass"
        Me.Txtpass.Size = New System.Drawing.Size(120, 22)
        Me.Txtpass.TabIndex = 14
        Me.Txtpass.UseSystemPasswordChar = True
        '
        'Txtprenom
        '
        Me.Txtprenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtprenom.Location = New System.Drawing.Point(209, 75)
        Me.Txtprenom.Name = "Txtprenom"
        Me.Txtprenom.Size = New System.Drawing.Size(120, 22)
        Me.Txtprenom.TabIndex = 13
        '
        'Txtnom
        '
        Me.Txtnom.AccessibleName = ""
        Me.Txtnom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Txtnom.Location = New System.Drawing.Point(209, 34)
        Me.Txtnom.Name = "Txtnom"
        Me.Txtnom.Size = New System.Drawing.Size(120, 22)
        Me.Txtnom.TabIndex = 12
        Me.Txtnom.Tag = ""
        '
        'Timer1
        '
        '
        'Pr
        '
        Me.Pr.Location = New System.Drawing.Point(1, 187)
        Me.Pr.Name = "Pr"
        Me.Pr.Size = New System.Drawing.Size(335, 23)
        Me.Pr.TabIndex = 22
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(94, 244)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(140, 41)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Afficher le mot de passe"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lbllongin
        '
        Me.lbllongin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllongin.ForeColor = System.Drawing.Color.White
        Me.lbllongin.Location = New System.Drawing.Point(229, 150)
        Me.lbllongin.Name = "lbllongin"
        Me.lbllongin.Size = New System.Drawing.Size(100, 23)
        Me.lbllongin.TabIndex = 24
        Me.lbllongin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(124, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Chargement :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GESTION_ASSOCIATION.My.Resources.Resources.images__1_2
        Me.PictureBox1.Location = New System.Drawing.Point(3, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 147)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(335, 23)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "LONGIN D'UTILISATEUR"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CONNEXION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(336, 290)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbllongin)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Pr)
        Me.Controls.Add(Me.txtmegs)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txtpass)
        Me.Controls.Add(Me.Txtprenom)
        Me.Controls.Add(Me.Txtnom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CONNEXION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONNEXION"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtmegs As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtpass As System.Windows.Forms.TextBox
    Friend WithEvents Txtprenom As System.Windows.Forms.TextBox
    Friend WithEvents Txtnom As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Pr As System.Windows.Forms.ProgressBar
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lbllongin As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
