Imports System.IO
Imports System.IO.Compression
Public Class Téléchargement
    Dim shObj As Object = Activator.CreateInstance(Type.GetTypeFromProgID("Shell.Application"))
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DownloadAnonUHC()
    End Sub

    Private Sub Téléchargement_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub

    Public Sub DownloadAnonUHC()
        MaterialLabel2.Text = "AnonUHC"
        Threading.Thread.Sleep(2000)
        My.Computer.Network.DownloadFile("http://informatiquenet.fr/files/anonuhc/anonuhc.sk", Variables.Dossier + "\plugins\Skript\scripts\anonuhc.sk")
        ProgressBar2.Value = 20
        Threading.Thread.Sleep(2000)
        If Variables.GUI = True Then
            MaterialLabel2.Text = "Interfaçe Graphique pour AnonUHC"
            Threading.Thread.Sleep(2000)
            My.Computer.Network.DownloadFile("http://informatiquenet.fr/files/anonuhc/menu.sk", Variables.Dossier + "\plugins\Skript\scripts\menu.sk")
            Threading.Thread.Sleep(2000)
        End If
        ProgressBar2.Value = 30
        If Variables.Spigot18 = True Then
            MaterialLabel2.Text = "Spigot 1.8"
            My.Computer.Network.DownloadFile("http://informatiquenet.fr/files/anonuhc/spigot-1.8.jar", Variables.Dossier + "\spigot.jar")
            Threading.Thread.Sleep(2000)
        End If
        ProgressBar2.Value = 40
        If Variables.Spigot19 = True Then
            MaterialLabel2.Text = "Spigot 1.9"
            My.Computer.Network.DownloadFile("http://informatiquenet.fr/files/anonuhc/spigot-1.9.jar", Variables.Dossier + "\spigot.jar")
            Threading.Thread.Sleep(2000)
        End If
        ProgressBar2.Value = 50
        If Variables.ViaVersion = True Then
            MaterialLabel2.Text = "ViaVersion"
            My.Computer.Network.DownloadFile("https://ci.viaversion.com/job/ViaVersion/6/artifact/target/ViaVersion-0.8.5-SNAPSHOT.jar", Variables.Dossier + "\plugins\ViaVersion.jar")
            Threading.Thread.Sleep(2000)
        End If
        ProgressBar2.Value = 60
        If Variables.Dep18 = True Then
            MaterialLabel2.Text = "Dépendances pour Spigot 1.8"
            My.Computer.Network.DownloadFile("http://informatiquenet.fr/files/anonuhc/dependances-1.8.zip", Variables.Dossier + "\plugins\dependances.zip")
            'Declare the folder where the items will be extracted.
            Dim output As Object = shObj.NameSpace((Variables.Dossier + "\plugins"))

            'Declare the input zip file.
            Dim input As Object = shObj.NameSpace((Variables.Dossier + "\plugins\dependances.zip"))

            'Extract the items from the zip file.
            output.CopyHere((input.Items), 4)
            Threading.Thread.Sleep(2000)
        End If
        ProgressBar2.Value = 80
        If Variables.Dep19 = True Then
            MaterialLabel2.Text = "Dépendances pour Spigot 1.9"
            My.Computer.Network.DownloadFile("http://informatiquenet.fr/files/anonuhc/dependances-1.9.zip", Variables.Dossier + "\plugins\dependances.zip")
            Dim output As Object = shObj.NameSpace((Variables.Dossier + "\plugins"))

            'Declare the input zip file.
            Dim input As Object = shObj.NameSpace((Variables.Dossier + "\plugins\dependances.zip"))

            'Extract the items from the zip file.
            output.CopyHere((input.Items), 4)
            Threading.Thread.Sleep(2000)
        End If
        ProgressBar2.Value = 100
        Threading.Thread.Sleep(2000)
        Fin.Show()
        Me.Close()
    End Sub
End Class