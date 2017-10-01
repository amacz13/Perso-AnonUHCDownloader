Public Class Licence
    Private Sub Licence_Load(sender As Object, e As EventArgs) Handles Me.Load
        MaterialFlatButton1.Enabled = False
    End Sub

    Private Sub MaterialCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox1.CheckedChanged
        If MaterialCheckBox1.Checked = True Then
            MaterialFlatButton1.Enabled = True
        Else
            MaterialFlatButton1.Enabled = False
        End If
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        Dossier_de_Sortie.Show()
        Me.Close()
    End Sub
End Class