Imports System.IO
Imports System.Xml
Module Module1

    Sub Main()
        Dim sett As New XmlWriterSettings
        sett.Encoding = Text.Encoding.UTF8
        sett.ConformanceLevel = ConformanceLevel.Document
        sett.WriteEndDocumentOnClose = False
        Dim doc As XmlWriter = XmlWriter.Create("C:\championDB.xml", sett)
        doc.WriteStartDocument()
        doc.WriteStartElement("champions")

        Dim dir As New DirectoryInfo("C:\Users\Bloodrayne\Documents\GitHub\OBSChampionScreenCreator\ChampionScreenCreatorNextGen\ChampionScreenCreatorNextGen\data\champions\icons")
        For Each x As FileInfo In dir.GetFiles("*.png")
            Dim name As String = x.Name.Replace("_Square_0.png", "")
            doc.WriteStartElement("champion")
            Console.WriteLine("ID des Champions '" & name & "': ")
            doc.WriteAttributeString("id", Console.ReadLine())
            doc.WriteAttributeString("display_name", name)
            doc.WriteAttributeString("banner", name)
            doc.WriteAttributeString("icon", name)
            Console.WriteLine("Primär-Rolle des Champions '" & name & "': ")
            doc.WriteAttributeString("primary", Console.ReadLine)
            Console.WriteLine("Sekundär-Rolle des Champions '" & name & "': ")
            doc.WriteAttributeString("secondary", Console.ReadLine)
            doc.WriteEndElement()
        Next
        doc.WriteEndElement()
        doc.WriteEndDocument()
        doc.Close()
        doc.Dispose()

        Console.WriteLine("Dokument erstellt")
    End Sub

End Module
