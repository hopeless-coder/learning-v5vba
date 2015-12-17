Imports INFITF
Imports MECMOD
Imports PARTITF
Imports HybridShapeTypeLib
Imports SPATypeLib
Module SpaceAnalysis
    Public Sub Demo()
        'this is the handle to the application interface
        Dim pApplication As Application
        Try
            pApplication = GetObject(, "CATIA.Application")
        Catch ex As Exception
            'if the program ends up here then the application has failed
            Console.WriteLine("We could not get the application")
            Exit Sub
        End Try
        Dim pPartDoc As PartDocument = CType(pApplication.Documents.Item(1), PartDocument)
        Dim pPart As Part = pPartDoc.Part
        Dim pBody As Body = pPart.MainBody

        Dim spa As SPAWorkbench = pPartDoc.GetWorkbench("SPAWorkbench")
        Dim measurable As Measurable = spa.GetMeasurable(pBody)
        Console.WriteLine(measurable.Volume)
        spa.Inertias.Item(1) 'this needs some research and shall get back to you
    End Sub
End Module
