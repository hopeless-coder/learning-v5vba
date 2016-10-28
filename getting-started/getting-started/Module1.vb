Module Module1
    Dim pApplication As INFITF.Application
    Dim pDocument As INFITF.Document
    Dim pPartDoc As MECMOD.PartDocument

    Sub Main()
        Connect()
    End Sub

    Sub Connect()
        On Error Resume Next
        pApplication = GetObject(, "CATIA.Application")
        On Error GoTo 0
        If pApplication Is Nothing Then
            Console.WriteLine("failed to connect to catia application")
            Exit Sub
        End If
        pDocument = pApplication.Documents.Item(1)
        pPartDoc = pDocument
        Console.WriteLine(pPartDoc.Name)
        Console.ReadLine()
    End Sub

End Module
