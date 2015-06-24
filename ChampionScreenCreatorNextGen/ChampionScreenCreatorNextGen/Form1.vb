Imports System.Threading
Public Class Form1

    Public Shared db As New ChampionDatabase
    Public Shared db2 As New ChampionDatabase2
    Public Shared teamDB As TeamManager
    Public Shared Event DragCompleted()
    Public Shared main As Form1

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        Splash.ShowDialog()

        CheckForIllegalCrossThreadCalls = False
        'db.ladeDB()
        ChampionAuswahl1.setDB(db2)
        AddHandler Form1.DragCompleted, AddressOf ChampionAuswahl1.onDragCompleted
        Dim x As New Thread(AddressOf ChampionAuswahl1.ladeAuswahl)
        x.Start()

        Form1.main = Me

        BlueSide.setSide(True)
        RedSide.setSide(False)

       
    End Sub

    Public Sub wenngeladen() Handles Me.Shown
        teamDB = New TeamManager
        RedSide.Team1.ladeTeams()
        BlueSide.Team1.ladeTeams()
    End Sub


    Public Shared Sub onDragCompletedSub()
        RaiseEvent DragCompleted()
    End Sub

    Private Sub ZurücksetzenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZurücksetzenToolStripMenuItem.Click
        ChampionAuswahl1.reset()
        BlueSide.resetChampionsAndBans()
        RedSide.resetChampionsAndBans()
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As New ImageCreator
        x.side_red = RedSide
        x.side_blue = BlueSide
        x.create()
        Dim p As New Preview
        p.BackgroundImage = x.img
        p.BackgroundImageLayout = ImageLayout.Stretch

        
        x.img.Save("C:\test.png", Drawing.Imaging.ImageFormat.Png)
        p.Show()
    End Sub

  
End Class
