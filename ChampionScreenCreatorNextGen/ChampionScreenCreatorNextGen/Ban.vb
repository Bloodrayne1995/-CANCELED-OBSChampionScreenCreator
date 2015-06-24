Public Class Ban

#Region "Intern"

    Private _champ As Champion = Nothing

#End Region

#Region "Eigenschaften"

    ''' <summary>
    ''' Gibt oder setzt den gebannten Champion
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CHAMP As Champion
        Get
            Return _champ
        End Get
        Set(value As Champion)
            _champ = value
            updateBan()
        End Set
    End Property

#End Region

#Region "Werkzeuge"

    ''' <summary>
    ''' Aktualisiert ds Element sobald eine Eigenschaft geändert wurde
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub updateBan()
        If Not IsNothing(_champ) Then
            lblChampName.Text = _champ.DISPLAYNAME
            pnlChamp.BackgroundImage = _champ.ICON
        Else
            lblChampName.Text = "<champion>"
            pnlChamp.BackgroundImage = Nothing
        End If
    End Sub

    Public Sub resetBan()
        _champ = Nothing
        updateBan()
    End Sub

#End Region


#Region "EventHandler"

    Private Sub dragHandler(sender As Object, e As DragEventArgs) Handles pnlChamp.DragDrop
        Try
            Dim x As DataObject = DirectCast(e.Data, DataObject)
            _champ = DirectCast(x.GetData(GetType(Champion)), Champion)
            updateBan()
            Form1.onDragCompletedSub()
            pnlChamp.BackColor = Me.BackColor
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dragHandler2(sender As Object, e As DragEventArgs) Handles pnlChamp.DragEnter
        If (e.AllowedEffect = DragDropEffects.Copy) Then
            pnlChamp.BackColor = Color.Yellow
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub dragHandler3(sender As Object, e As EventArgs) Handles pnlChamp.DragLeave
        'Debug.WriteLine("DragLeave")
        pnlChamp.BackColor = Me.BackColor
    End Sub

#End Region

End Class
