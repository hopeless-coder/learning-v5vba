Module Module1

    Sub Main()
        'this is the handle to the application interface
        Dim pApplication As INFITF.Application
        'this is when we request the handle on catia application to windows
        pApplication = GetObject(, "CATIA.Application")
        If pApplication Is Nothing Then
            'no catia application running on the machine
            Console.WriteLine("we have not found the application running on your machine")
            Exit Sub
        End If
        'good we have connected to catia

        Dim pDocuments As INFITF.Documents
        pDocuments = pApplication.Documents 'getting the documents collection

        Dim pDocument As INFITF.Document
        pDocument = pDocuments.Item(1) 'getting the first document

        Console.WriteLine("the name of the document is {0}", pDocument.Name)


    End Sub

End Module
