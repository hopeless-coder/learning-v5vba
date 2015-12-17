Imports INFITF
Imports MECMOD
Imports PARTITF
Imports HybridShapeTypeLib
Module Module1

    Sub Main()
        'this is the handle to the application interface
        Dim pApplication As Application
        Try
            pApplication = GetObject(, "CATIA.Application")
        Catch ex As Exception
            'if the program ends up here then the application has failed
            Console.WriteLine("We could not get the application")
            Exit Sub
        End Try
        Dim pPart As Part = CType(pApplication.Documents.Item(1), PartDocument).Part
        Dim pConstructionBody As HybridBody =
        WireframeSurfaces.CreateHybBody("construction body", pPart)
        Dim pPt As HybridShapePointCoord =
        WireframeSurfaces.CreatePoint(pPart, pConstructionBody, 0, 0, 0)

        Dim pPt2 As HybridShapePointCoord =
        WireframeSurfaces.CreatePoint(pPart, pConstructionBody, 0, 0, 100)

        Dim line As HybridShapeLinePtPt =
            WireframeSurfaces.PlotLinePtPt(pPart, pConstructionBody, pPt, pPt2)

        Dim plane As HybridShapePlaneNormal =
            WireframeSurfaces.PlotPlaneNormal(pPart, pConstructionBody, line, pPt)
    End Sub

End Module
