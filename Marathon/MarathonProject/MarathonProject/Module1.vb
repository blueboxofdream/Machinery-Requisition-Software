Module Module1
    Public cnMainData As New ADODB.Connection
    Public Sub connect()
        With Module1.cnMainData
            .Provider = "Microsoft.Jet.OLEDB.4.0"
            .Properties("Persist Security Info").Value = False
            .ConnectionString = "G:\Marathon\reqpp.mdb"
            .Open()
        End With
    End Sub
End Module
