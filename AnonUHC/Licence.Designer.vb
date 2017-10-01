<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Licence
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Licence))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialCheckBox1 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 84)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(787, 303)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
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
        Me.MaterialFlatButton1.TabIndex = 1
        Me.MaterialFlatButton1.Text = "Suivant"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'MaterialCheckBox1
        '
        Me.MaterialCheckBox1.AutoSize = True
        Me.MaterialCheckBox1.BackColor = System.Drawing.Color.White
        Me.MaterialCheckBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.MaterialCheckBox1.Depth = 0
        Me.MaterialCheckBox1.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialCheckBox1.Location = New System.Drawing.Point(12, 407)
        Me.MaterialCheckBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckBox1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckBox1.Name = "MaterialCheckBox1"
        Me.MaterialCheckBox1.Ripple = True
        Me.MaterialCheckBox1.Size = New System.Drawing.Size(417, 30)
        Me.MaterialCheckBox1.TabIndex = 2
        Me.MaterialCheckBox1.Text = "J'ai lu et j'accepte les termes du contrat de licence"
        Me.MaterialCheckBox1.UseVisualStyleBackColor = False
        '
        'Licence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 462)
        Me.Controls.Add(Me.MaterialCheckBox1)
        Me.Controls.Add(Me.MaterialFlatButton1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.MaximizeBox = False
        Me.Name = "Licence"
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Licence"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialCheckBox1 As MaterialSkin.Controls.MaterialCheckBox
End Class
