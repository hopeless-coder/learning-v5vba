Module Module1
    'I have pulled out all the variables at the module level
    Dim pApplication As INFITF.Application
    Dim pDocument As INFITF.Document
    Dim pPartDoc As MECMOD.PartDocument

    Sub Main()
        'the main function here can Connect() and call the function
        'the functions then are to perform modular small tasks
        Connect()
    End Sub

    Sub Connect()
        On Error Resume Next 'so that the application silently takes in the errors
        pApplication = GetObject(, "CATIA.Application")
        If pApplication Is Nothing Then
            Console.WriteLine("failed to connect to catia application")
            Exit Sub
        End If
        pDocument = pApplication.Documents.Item(1)
        pPartDoc = pDocument
        Console.WriteLine(pPartDoc.Name)
        Console.ReadLine()
        'so that the application stops at the errors again
        On Error GoTo 0
    End Sub

End Module
