Imports System.Threading

Public Class ChampionSelector

    Public meineForm As MainForm

    Private selectedChamp As String = ""
    Private hasSelected As Boolean = False
    Private alreadySelectedChamps As New List(Of String)
    Public OVERRIDE_MAIN_MODE As Boolean = False



    Private _HiddenChamps As New List(Of String)
    Private _lastSuche As String = "-1"
    Private _sucheAktiv As Boolean = False


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

    Private Sub ladeItems(Optional removeAlready As Boolean = True)
        If removeAlready Then
            alreadySelectedChamps.Clear()
        End If

        Dim ds As New DataSet
        Dim dt As DataTable = ds.Tables.Add("champions")

        'Tabelle vorbereiten
        dt.Columns.Add("Icon")
        dt.Columns.Add("Name")
        dt.Columns(0).DataType = GetType(Bitmap)


        icons.Images.Clear()
        For Each champ As ChampionData In meineForm.memory.championDB.db
            Dim dr As DataRow = dt.NewRow
            'Dim img As New DataGridViewImageCell
            'img.Image = champ.Square


            icons.Images.Add(champ.Name, champ.Square)

            dr.Item(0) = champ.Square
            dr.Item(1) = champ.Name

            dt.Rows.Add(dr)
            'Dim x As New ListViewItem
            'x.Name = champ.Name
            'x.Tag = champ.Name
            'x.ImageKey = champ.Name
            'x.Text = champ.Name
            'lstChampions.Items.Add(x)
            Debug.WriteLine("Champion " & champ.Name & " hinzugefügt")
        Next

        drgChampions.DataSource = dt
        'drgChampions.AutoResizeRows()
        AddHandler drgChampions.SelectionChanged, AddressOf lstChampions_SelectedIndexChanged
    End Sub

    Private Sub lstChampions_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles drgChampions.MouseDoubleClick
        If hasSelected = True Or Not selectedChamp = "" Then
            meineForm.setzeChampion(selectedChamp)
            If Not OVERRIDE_MAIN_MODE Then
                If meineForm.modus = 0 Then
                    hideRowByName(selectedChamp)
                    alreadySelectedChamps.Add(selectedChamp)
                Else
                    If alreadySelectedChamps.Contains(selectedChamp) Then
                        hideRowByName(selectedChamp)
                    Else
                        alreadySelectedChamps.Add(selectedChamp)
                    End If

                End If
            Else
                'lstChampions.Items.RemoveByKey(selectedChamp)
                alreadySelectedChamps.Add(selectedChamp)
            End If
            hasSelected = False
        End If
    End Sub



    Private Sub lstChampions_SelectedIndexChanged(sender As Object, e As EventArgs)
        If hasSelected = False Then
            hasSelected = True
        End If
        Try
            selectedChamp = drgChampions.SelectedRows(0).Cells(1).Value
        Catch ex As Exception

        End Try
    End Sub


    

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        lstChampions_MouseDoubleClick(Nothing, Nothing)
    End Sub

    

    

    Public Sub hideRowByName(champName As String)

        
        drgChampions.ClearSelection()
        For i As Integer = 0 To drgChampions.Rows.Count - 1
            If DirectCast(drgChampions.Rows(i).Cells(1).Value, String).ToLower = champName.ToLower Then
                drgChampions.Rows.RemoveAt(i)
                Exit For
            End If
        Next

        'For Each x As DataGridViewRow In drgChampions.Rows
        '    If DirectCast(x.Cells(1).Value, String).ToLower = champName.ToLower Then
        '        x.Visible = False
        '    End If
        'Next
    End Sub

    Public Sub showAllHidden()
        For Each x As DataGridViewRow In drgChampions.Rows
            If x.Visible = False Then
                x.Visible = True
            End If
        Next
    End Sub
   
    Private Sub txtSuche_TextChanged(sender As Object, e As EventArgs) Handles txtSuche.TextChanged

    End Sub
End Class
