Public Class Dépendances
    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        If MaterialRadioButton2.Checked = True Then
            Variables.Dep18 = True
            Variables.Dep19 = False
        ElseIf MaterialRadioButton3.Checked = True Then
            Variables.Dep18 = False
            Variables.Dep19 = True
        Else
            Variables.Dep18 = False
            Variables.Dep19 = False
        End If
        Téléchargement.Show()
        Me.Close()
    End Sub
End Class