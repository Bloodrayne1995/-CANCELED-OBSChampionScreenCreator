Imports System.Threading

Public Class ChampionSelector

    Public meineForm As MainForm

    Private selectedChamp As String = ""
    Private hasSelected As Boolean = False
    Private alreadySelectedChamps As New List(Of String)

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

    Public Sub lade(ByRef x As MainForm)
        Me.meineForm = x
        Dim a As New Thread(AddressOf ladeItems)
        a.Start()
    End Sub

    Private Sub ladeItems()
        alreadySelectedChamps.Clear()
        lstChampions.Items.Clear()
        icons.Images.Clear()
        For Each champ As ChampionData In meineForm.memory.championDB.db
            icons.Images.Add(champ.Name, champ.Square)
            Dim x As New ListViewItem
            x.Name = champ.Name
            x.Tag = champ.Name
            x.ImageKey = champ.Name
            x.Text = champ.Name
            lstChampions.Items.Add(x)
            Debug.WriteLine("Champion " & champ.Name & " hinzugefügt")
        Next

    End Sub

    Private Sub lstChampions_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstChampions.MouseDoubleClick
        If hasSelected = True Or Not selectedChamp = "" Then
            meineForm.setzeChampion(selectedChamp)
            If meineForm.modus = 0 Then
                lstChampions.Items.RemoveByKey(selectedChamp)
                alreadySelectedChamps.Add(selectedChamp)
            Else
                If alreadySelectedChamps.Contains(selectedChamp) Then
                    lstChampions.Items.RemoveByKey(selectedChamp)
                Else
                    alreadySelectedChamps.Add(selectedChamp)
                End If
            End If
            hasSelected = False
        End If
    End Sub



    Private Sub lstChampions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstChampions.SelectedIndexChanged
        If hasSelected = False Then
            hasSelected = True
        End If
        Try
            selectedChamp = lstChampions.SelectedItems(0).Tag
        Catch ex As Exception

        End Try
    End Sub



End Class
