Public Class Splash

    
    Private fertig As Boolean = False

    Private Sub Splash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CheckForIllegalCrossThreadCalls = False
        lblLade1.Text = "Lade Champions mittels RiotAPI"
        Dim x As New ChampionDatabase2
        AddHandler x.onChampionLoaded, AddressOf zeigeChampion
        AddHandler x.onFinishedLoading, Sub()
                                            Form1.db2 = x
                                            Me.Close()
                                        End Sub
        Dim t As New Threading.Thread(AddressOf x.ladeDB)
        t.Start()
        Me.Visible = True



    End Sub


    Private Sub zeigeChampion(c As Champion)
        lblChamp.Text = "Champion geladen: " & c.DISPLAYNAME & " ( " & c.PRIMARY_ROLE & " )"
        Me.Update()
    End Sub


End Class
