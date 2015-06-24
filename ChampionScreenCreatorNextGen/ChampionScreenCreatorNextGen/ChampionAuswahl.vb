Imports System.Data
Imports RiotSharp.StaticDataEndpoint
Public Class ChampionAuswahl

    Dim dt As New DataTable
    Dim db As ChampionDatabase
    Dim db2 As ChampionDatabase2
    Dim hit As DataGridView.HitTestInfo
    Public useAPI As Boolean = False

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

       

        dgvChampions.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvChampions.MultiSelect = False
        dgvChampions.RowTemplate.Height = 64
        dgvChampions.RowHeadersWidth = 20
        dgvChampions.DataSource = dt

       
        dt.Columns.Clear()
        dt.Columns.Add("Icon", GetType(Image))
        'dt.Columns(0).DataType = GetType(Image)
        dt.Columns.Add("Name")
        dt.Columns(1).DataType = GetType(String)
        dt.Columns.Add("Primär-Rolle")
        dt.Columns(2).DataType = GetType(String)
        dt.Columns.Add("Sekundär-Rolle")
        dt.Columns(3).DataType = GetType(String)


        For Each x As CheckBox In GroupBox1.Controls
            AddHandler x.CheckedChanged, AddressOf suche
        Next

        AddHandler TextBox1.TextChanged, AddressOf suche

    End Sub

    Public Sub ladeAuswahl()

        dt.Clear()

        If useAPI Then
            For i As Integer = 0 To db2.getChampionCount - 1
                Dim a As Champion = db2.getChampionByIterator(i)
                Dim dr As DataRow = dt.NewRow
                dr.Item(0) = a.ICON
                dr.Item(1) = a.DISPLAYNAME
                dr.Item(2) = a.PRIMARY_ROLE
                dr.Item(3) = a.SECOND_ROLE
                dt.Rows.Add(dr)
            Next
            dgvChampions.Sort(dgvChampions.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
        Else
            For i As Integer = 0 To db.getChampionCount - 1
                Dim a As Champion = db.getChampionByIterator(i)
                Dim dr As DataRow = dt.NewRow
                dr.Item(1) = a.DISPLAYNAME
                dr.Item(0) = a.ICON
                dr.Item(2) = a.PRIMARY_ROLE
                dr.Item(3) = a.SECOND_ROLE
                dt.Rows.Add(dr)
            Next
        End If
    End Sub

    Private Sub cmdSuche_Click(sender As Object, e As EventArgs) Handles cmdSuche.Click
        suche()
    End Sub

    Private Sub suche()
        Dim sucheNachRolle As Boolean = False
        Dim sucheNachText As Boolean = False
        Dim txtSuche As String = TextBox1.Text
        Dim txtRolle As String = ""
        Dim paramRolle As New List(Of TagStatic)

        sucheNachText = Not txtSuche.Equals(String.Empty) And Not txtSuche.Equals("*")


        If chkAssassin.Checked Then
            sucheNachRolle = True
            txtRolle &= chkAssassin.Tag & "#"
            paramRolle.Add(TagStatic.Assassin)
        End If

        If chkTank.Checked Then
            sucheNachRolle = True
            txtRolle &= chkTank.Tag & "#"
            paramRolle.Add(TagStatic.Tank)
        End If

        If chkMage.Checked Then
            sucheNachRolle = True
            txtRolle &= chkMage.Tag & "#"
            paramRolle.Add(TagStatic.Mage)
        End If

        If chkMarksman.Checked Then
            sucheNachRolle = True
            txtRolle &= chkMarksman.Tag & "#"
            paramRolle.Add(TagStatic.Marksman)
        End If

        If chkFighter.Checked Then
            sucheNachRolle = True
            txtRolle &= chkFighter.Tag & "#"
            paramRolle.Add(TagStatic.Fighter)
        End If

        If chkSupport.Checked Then
            sucheNachRolle = True
            txtRolle &= chkSupport.Tag & "#"
            paramRolle.Add(TagStatic.Support)
        End If

        Dim champs1() As Champion
        If sucheNachRolle Then
            If useAPI Then
                champs1 = db2.getChampionsWithRoles(paramRolle.ToArray)
            Else
                champs1 = db.getChampionsWithRoles(txtRolle)
            End If
        Else
            If useAPI Then
                ReDim champs1(db2.getChampionCount - 1)
                For i As Integer = 0 To db2.getChampionCount - 1
                    champs1(i) = db2.getChampionByIterator(i)
                Next
            Else
                ReDim champs1(db.getChampionCount - 1)
                For i As Integer = 0 To db.getChampionCount - 1
                    champs1(i) = db.getChampionByIterator(i)
                Next
            End If
        End If

        Dim champs2 As New List(Of Champion)
        If sucheNachText Then
           For i As Integer = 0 To champs1.Count - 1
                If champs1(i).isChampion(txtSuche) Then
                    champs2.Add(champs1(i))
                End If
            Next
        Else
            champs2 = New List(Of Champion)(champs1)
        End If

        dt.Clear()
        For i As Integer = 0 To champs2.Count - 1
            Dim a As Champion = champs2(i)
            Dim dr As DataRow = dt.NewRow
            dr.Item(1) = a.DISPLAYNAME
            dr.Item(0) = a.ICON
            dr.Item(2) = a.PRIMARY_ROLE
            dr.Item(3) = a.SECOND_ROLE
            dt.Rows.Add(dr)
        Next
        dgvChampions.Sort(dgvChampions.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs)
        reset()
    End Sub


    Public Sub reset()
        For Each x As CheckBox In GroupBox1.Controls
            x.Checked = False
        Next
        TextBox1.Text = ""
        ladeAuswahl()
    End Sub

    Public Sub setDB(ByRef x As ChampionDatabase)
        db = x
    End Sub

    Public Sub setDB(ByRef x As ChampionDatabase2)
        db2 = x
        useAPI = True
    End Sub

    Private Sub onDoDragDrop(sender As Object, e As MouseEventArgs) Handles dgvChampions.MouseDown
        hit = dgvChampions.HitTest(e.X, e.Y)
        Try
            If useAPI Then
                Me.dgvChampions.DoDragDrop(db2.getChampionByName(dgvChampions.Rows(hit.RowIndex).Cells(1).Value), DragDropEffects.Copy)
            Else
                Me.dgvChampions.DoDragDrop(db.getChampionByName(dgvChampions.Rows(hit.RowIndex).Cells(1).Value), DragDropEffects.Copy)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Public Sub onDragCompleted()
        dgvChampions.Rows.RemoveAt(hit.RowIndex)
    End Sub

End Class
