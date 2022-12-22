<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Email
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Txtmotdepasse = New System.Windows.Forms.TextBox()
        Me.txtemailenvoi = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtmessage = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtobjet = New System.Windows.Forms.TextBox()
        Me.Txtdestinataire = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Txtmotdepasse)
        Me.GroupBox1.Controls.Add(Me.txtemailenvoi)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(860, 108)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connexion           "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mot de passe :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Adresse Email :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(158, 79)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(673, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Connexion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Txtmotdepasse
        '
        Me.Txtmotdepasse.Location = New System.Drawing.Point(85, 49)
        Me.Txtmotdepasse.Name = "Txtmotdepasse"
        Me.Txtmotdepasse.Size = New System.Drawing.Size(758, 20)
        Me.Txtmotdepasse.TabIndex = 1
        Me.Txtmotdepasse.UseSystemPasswordChar = True
        '
        'txtemailenvoi
        '
        Me.txtemailenvoi.Location = New System.Drawing.Point(85, 24)
        Me.txtemailenvoi.Name = "txtemailenvoi"
        Me.txtemailenvoi.Size = New System.Drawing.Size(759, 20)
        Me.txtemailenvoi.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Txtmessage)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.txtobjet)
        Me.GroupBox2.Controls.Add(Me.Txtdestinataire)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(8, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(860, 406)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Envoyer un message"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GESTION_ASSOCIATION.My.Resources.Resources.Logo_Template___Logo_12
        Me.PictureBox1.Location = New System.Drawing.Point(4, 101)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 268)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Message :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "object :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "destinataire :"
        '
        'Txtmessage
        '
        Me.Txtmessage.Location = New System.Drawing.Point(129, 70)
        Me.Txtmessage.Name = "Txtmessage"
        Me.Txtmessage.Size = New System.Drawing.Size(715, 299)
        Me.Txtmessage.TabIndex = 5
        Me.Txtmessage.Text = ""
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(159, 375)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(665, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Envoyer"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtobjet
        '
        Me.txtobjet.Location = New System.Drawing.Point(84, 44)
        Me.txtobjet.Name = "txtobjet"
        Me.txtobjet.Size = New System.Drawing.Size(759, 20)
        Me.txtobjet.TabIndex = 3
        '
        'Txtdestinataire
        '
        Me.Txtdestinataire.Location = New System.Drawing.Point(84, 19)
        Me.Txtdestinataire.Name = "Txtdestinataire"
        Me.Txtdestinataire.Size = New System.Drawing.Size(760, 20)
        Me.Txtdestinataire.TabIndex = 2
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Email
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(880, 536)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(310, 376)
        Me.Name = "Email"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Email"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Txtmotdepasse As System.Windows.Forms.TextBox
    Friend WithEvents txtemailenvoi As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txtmessage As System.Windows.Forms.RichTextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtobjet As System.Windows.Forms.TextBox
    Friend WithEvents Txtdestinataire As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
