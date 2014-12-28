Imports System.Windows.Forms.ListView

Public Class ChampionSelecterV2

    Private itemL As New ArrayList()
    Private itemClicked As Boolean = False


    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        For Each x As String In SharedMem.liste.Items

            Dim chmp As ChampionData = SharedMem.getChampionByName(x)
            imgListChampions.Images.Add(chmp.Name.ToLower, chmp.Square)
            itemL.Add(lvChampions.Items.Add(x, chmp.Name.ToLower))


        Next

    End Sub

    Private Sub showRelevantItems(Optional txt As String = "*")
        If itemClicked = False Then
            lvChampions.Items.Clear()
            If txt = "*" Or txt = "" Then
                For Each x As ListViewItem In itemL
                    lvChampions.Items.Add(x)
                Next
            Else
                For Each x As ListViewItem In itemL
                    If x.Text.ToLower Like (txt & "*").ToLower Then
                        lvChampions.Items.Add(x)
                    End If
                Next
            End If
        End If
    End Sub


    Public Overloads Sub ShowDialog(cmd As Button)
        Dim rst As DialogResult = Me.ShowDialog()
        If rst = Windows.Forms.DialogResult.OK Then
            Dim name As String = txtSearch.Text
            For Each x As ChampionData In SharedMem.database.ChampionDataList
                If x.Name = name Then
                    cmd.BackColor = Color.Transparent
                    cmd.BackgroundImage = x.Square
                    cmd.BackgroundImageLayout = ImageLayout.Stretch
                    cmd.Tag = name
                End If
            Next
        End If
    End Sub

    Private Sub lvChampions_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lvChampions.KeyPress
        Debug.Write("Taste gedrückt")
    End Sub

    Private Sub lvChampions_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvChampions.MouseDoubleClick
        If lvChampions.SelectedItems.Count > 0 Then
            txtSearch.Text = lvChampions.SelectedItems(0).Text
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub



    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            itemClicked = False
            showRelevantItems(txtSearch.Text)
        Catch ex As Exception

        End Try
    End Sub
End Class