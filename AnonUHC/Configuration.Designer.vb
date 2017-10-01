<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Configuration
    Inherits MaterialSkin.Controls.MaterialForm

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialCheckBox1 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.MaterialCheckBox2 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.MaterialCheckBox3 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialCheckBox4 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.MaterialRadioButton1 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialRadioButton2 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.SuspendLayout()
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(713, 411)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(85, 36)
        Me.MaterialFlatButton1.TabIndex = 2
        Me.MaterialFlatButton1.Text = "Suivant"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'MaterialCheckBox1
        '
        Me.MaterialCheckBox1.AutoSize = True
        Me.MaterialCheckBox1.BackColor = System.Drawing.Color.Chocolate
        Me.MaterialCheckBox1.Depth = 0
        Me.MaterialCheckBox1.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialCheckBox1.Location = New System.Drawing.Point(30, 127)
        Me.MaterialCheckBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckBox1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckBox1.Name = "MaterialCheckBox1"
        Me.MaterialCheckBox1.Ripple = True
        Me.MaterialCheckBox1.Size = New System.Drawing.Size(110, 30)
        Me.MaterialCheckBox1.TabIndex = 3
        Me.MaterialCheckBox1.Text = "Anon UHC"
        Me.MaterialCheckBox1.UseVisualStyleBackColor = False
        '
        'MaterialCheckBox2
        '
        Me.MaterialCheckBox2.AutoSize = True
        Me.MaterialCheckBox2.Depth = 0
        Me.MaterialCheckBox2.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialCheckBox2.Location = New System.Drawing.Point(30, 172)
        Me.MaterialCheckBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckBox2.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckBox2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckBox2.Name = "MaterialCheckBox2"
        Me.MaterialCheckBox2.Ripple = True
        Me.MaterialCheckBox2.Size = New System.Drawing.Size(183, 30)
        Me.MaterialCheckBox2.TabIndex = 4
        Me.MaterialCheckBox2.Text = "Interfaçe Graphique"
        Me.MaterialCheckBox2.UseVisualStyleBackColor = True
        '
        'MaterialCheckBox3
        '
        Me.MaterialCheckBox3.AutoSize = True
        Me.MaterialCheckBox3.Depth = 0
        Me.MaterialCheckBox3.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialCheckBox3.Location = New System.Drawing.Point(30, 359)
        Me.MaterialCheckBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckBox3.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckBox3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckBox3.Name = "MaterialCheckBox3"
        Me.MaterialCheckBox3.Ripple = True
        Me.MaterialCheckBox3.Size = New System.Drawing.Size(240, 30)
        Me.MaterialCheckBox3.TabIndex = 5
        Me.MaterialCheckBox3.Text = "ViaVersion (Protocol Hack)"
        Me.MaterialCheckBox3.UseVisualStyleBackColor = True
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(15, 87)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(74, 24)
        Me.MaterialLabel1.TabIndex = 6
        Me.MaterialLabel1.Text = "Général"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(15, 223)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(62, 24)
        Me.MaterialLabel2.TabIndex = 7
        Me.MaterialLabel2.Text = "Divers"
        '
        'MaterialCheckBox4
        '
        Me.MaterialCheckBox4.AutoSize = True
        Me.MaterialCheckBox4.Depth = 0
        Me.MaterialCheckBox4.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialCheckBox4.Location = New System.Drawing.Point(30, 263)
        Me.MaterialCheckBox4.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckBox4.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckBox4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckBox4.Name = "MaterialCheckBox4"
        Me.MaterialCheckBox4.Ripple = True
        Me.MaterialCheckBox4.Size = New System.Drawing.Size(81, 30)
        Me.MaterialCheckBox4.TabIndex = 8
        Me.MaterialCheckBox4.Text = "Spigot"
        Me.MaterialCheckBox4.UseVisualStyleBackColor = True
        '
        'MaterialRadioButton1
        '
        Me.MaterialRadioButton1.AutoSize = True
        Me.MaterialRadioButton1.Depth = 0
        Me.MaterialRadioButton1.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialRadioButton1.Location = New System.Drawing.Point(55, 308)
        Me.MaterialRadioButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton1.Name = "MaterialRadioButton1"
        Me.MaterialRadioButton1.Ripple = True
        Me.MaterialRadioButton1.Size = New System.Drawing.Size(123, 30)
        Me.MaterialRadioButton1.TabIndex = 9
        Me.MaterialRadioButton1.TabStop = True
        Me.MaterialRadioButton1.Text = "Spigot 1.8.7"
        Me.MaterialRadioButton1.UseVisualStyleBackColor = True
        '
        'MaterialRadioButton2
        '
        Me.MaterialRadioButton2.AutoSize = True
        Me.MaterialRadioButton2.Depth = 0
        Me.MaterialRadioButton2.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialRadioButton2.Location = New System.Drawing.Point(191, 308)
        Me.MaterialRadioButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton2.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton2.Name = "MaterialRadioButton2"
        Me.MaterialRadioButton2.Ripple = True
        Me.MaterialRadioButton2.Size = New System.Drawing.Size(108, 30)
        Me.MaterialRadioButton2.TabIndex = 10
        Me.MaterialRadioButton2.TabStop = True
        Me.MaterialRadioButton2.Text = "Spigot 1.9"
        Me.MaterialRadioButton2.UseVisualStyleBackColor = True
        '
        'Configuration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 462)
        Me.Controls.Add(Me.MaterialRadioButton2)
        Me.Controls.Add(Me.MaterialRadioButton1)
        Me.Controls.Add(Me.MaterialCheckBox4)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.MaterialCheckBox3)
        Me.Controls.Add(Me.MaterialCheckBox2)
        Me.Controls.Add(Me.MaterialCheckBox1)
        Me.Controls.Add(Me.MaterialFlatButton1)
        Me.MaximizeBox = False
        Me.Name = "Configuration"
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents MaterialCheckBox1 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents MaterialCheckBox2 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents MaterialCheckBox3 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCheckBox4 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents MaterialRadioButton1 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialRadioButton2 As MaterialSkin.Controls.MaterialRadioButton
End Class
