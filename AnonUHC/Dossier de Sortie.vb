Public Class Dossier_de_Sortie
    Private Sub Dossier_de_Sortie_Load(sender As Object, e As EventArgs) Handles Me.Load
        MaterialSingleLineTextField1.Text = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\AnonUHC"
        FolderBrowserDialog1.SelectedPath = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\AnonUHC"
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        Dim result As DialogResult = FolderBrowserDialog1.ShowDialog()
        If (result = DialogResult.OK) Then
            Dim folder As String = FolderBrowserDialog1.SelectedPath
            MaterialSingleLineTextField1.Text = folder
        End If
    End Sub

    Private Sub MaterialFlatButton2_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton2.Click
        Variables.Dossier = MaterialSingleLineTextField1.Text
        Configuration.Show()
        Me.Close()
    End Sub
End Class