<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dépendances
    Inherits MaterialSkin.Controls.MaterialForm

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialRadioButton1 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialRadioButton2 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialRadioButton3 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.SuspendLayout()
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(21, 80)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(470, 24)
        Me.MaterialLabel1.TabIndex = 0
        Me.MaterialLabel1.Text = "Souhaitez vous télécharger les dépendances requises?"
        '
        'MaterialRadioButton1
        '
        Me.MaterialRadioButton1.AutoSize = True
        Me.MaterialRadioButton1.Checked = True
        Me.MaterialRadioButton1.Depth = 0
        Me.MaterialRadioButton1.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialRadioButton1.Location = New System.Drawing.Point(68, 152)
        Me.MaterialRadioButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton1.Name = "MaterialRadioButton1"
        Me.MaterialRadioButton1.Ripple = True
        Me.MaterialRadioButton1.Size = New System.Drawing.Size(62, 30)
        Me.MaterialRadioButton1.TabIndex = 1
        Me.MaterialRadioButton1.TabStop = True
        Me.MaterialRadioButton1.Text = "Non"
        Me.MaterialRadioButton1.UseVisualStyleBackColor = True
        '
        'MaterialRadioButton2
        '
        Me.MaterialRadioButton2.AutoSize = True
        Me.MaterialRadioButton2.Depth = 0
        Me.MaterialRadioButton2.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialRadioButton2.Location = New System.Drawing.Point(68, 216)
        Me.MaterialRadioButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton2.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton2.Name = "MaterialRadioButton2"
        Me.MaterialRadioButton2.Ripple = True
        Me.MaterialRadioButton2.Size = New System.Drawing.Size(181, 30)
        Me.MaterialRadioButton2.TabIndex = 2
        Me.MaterialRadioButton2.TabStop = True
        Me.MaterialRadioButton2.Text = "Oui, pour Spigot 1.8"
        Me.MaterialRadioButton2.UseVisualStyleBackColor = True
        '
        'MaterialRadioButton3
        '
        Me.MaterialRadioButton3.AutoSize = True
        Me.MaterialRadioButton3.Depth = 0
        Me.MaterialRadioButton3.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialRadioButton3.Location = New System.Drawing.Point(68, 282)
        Me.MaterialRadioButton3.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton3.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton3.Name = "MaterialRadioButton3"
        Me.MaterialRadioButton3.Ripple = True
        Me.MaterialRadioButton3.Size = New System.Drawing.Size(181, 30)
        Me.MaterialRadioButton3.TabIndex = 3
        Me.MaterialRadioButton3.TabStop = True
        Me.MaterialRadioButton3.Text = "Oui, pour Spigot 1.9"
        Me.MaterialRadioButton3.UseVisualStyleBackColor = True
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(713, 411)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(85, 36)
        Me.MaterialFlatButton1.TabIndex = 4
        Me.MaterialFlatButton1.Text = "Suivant"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'Dépendances
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 462)
        Me.Controls.Add(Me.MaterialFlatButton1)
        Me.Controls.Add(Me.MaterialRadioButton3)
        Me.Controls.Add(Me.MaterialRadioButton2)
        Me.Controls.Add(Me.MaterialRadioButton1)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.MaximizeBox = False
        Me.Name = "Dépendances"
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dépendances"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialRadioButton1 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialRadioButton2 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialRadioButton3 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
End Class
