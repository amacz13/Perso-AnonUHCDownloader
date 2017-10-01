Public Class Configuration
    Private Sub Configuration_Load(sender As Object, e As EventArgs) Handles Me.Load
        MaterialRadioButton1.Enabled = False
        MaterialRadioButton2.Enabled = False
        MaterialCheckBox1.Enabled = False
        MaterialCheckBox1.Checked = True
    End Sub



    Private Sub MaterialCheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox4.CheckedChanged
        If MaterialCheckBox4.Checked = True Then
            MaterialRadioButton1.Enabled = True
            MaterialRadioButton1.Checked = True
            MaterialRadioButton2.Enabled = True
        Else
            MaterialRadioButton1.Enabled = False
            MaterialRadioButton1.Checked = False
            MaterialRadioButton2.Enabled = False
            MaterialRadioButton2.Checked = False
        End If
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        If MaterialCheckBox2.Checked = True Then
            Variables.GUI = True
        Else
            Variables.GUI = False
        End If
        If MaterialRadioButton1.Checked = True Then
            Variables.Spigot18 = True
        Else
            Variables.Spigot18 = False
        End If
        If MaterialRadioButton2.Checked = True Then
            Variables.Spigot19 = True
        Else
            Variables.Spigot19 = False
        End If
        If MaterialCheckBox3.Checked = True Then
            Variables.ViaVersion = True
        Else
            Variables.ViaVersion = False
        End If
        Dépendances.Show()
        Me.Close()
    End Sub

End Class