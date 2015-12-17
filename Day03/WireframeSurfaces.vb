Imports INFITF
Imports MECMOD
Imports PARTITF
Imports HybridShapeTypeLib

Module WireframeSurfaces
    Public Function CreateHybBody(name As String, prt As Part) As HybridBody
        Dim pHybBody As HybridBody = prt.HybridBodies.Add()
        pHybBody.Name = name
        Return pHybBody
    End Function
    Public Function CreatePoint(prt As Part, bd As HybridBody, x As Double, y As Double, z As Double) As HybridShapePointCoord
        Dim pHShapeFac As HybridShapeFactory = prt.HybridShapeFactory
        Dim pPt As HybridShapePointCoord = pHShapeFac.AddNewPointCoord(x, y, z)
        bd.AppendHybridShape(pPt)
        prt.Update()
        Return pPt

    End Function
    Public Function PlotLinePtPt(prt As Part, bd As HybridBody, pt1 As HybridShape, pt2 As HybridShape) As HybridShapeLinePtPt
        Dim pHShapeFac As HybridShapeFactory = prt.HybridShapeFactory
        Dim ref1 As Reference = prt.CreateReferenceFromObject(pt1)
        Dim ref2 As Reference = prt.CreateReferenceFromObject(pt2)
        Dim line As HybridShapeLinePtPt = pHShapeFac.AddNewLinePtPt(ref1, ref2)
        bd.AppendHybridShape(line)
        prt.Update()
        Return line

    End Function

    Public Function PlotPlaneNormal(prt As Part, bd As HybridBody, curve As HybridShape, endpt As HybridShape) As HybridShapePlaneNormal
        Dim pHShapeFac As HybridShapeFactory = prt.HybridShapeFactory
        Dim plane As HybridShapePlaneNormal = pHShapeFac.AddNewPlaneNormal( _
            prt.CreateReferenceFromObject(curve), prt.CreateReferenceFromObject(endpt))
        bd.AppendHybridShape(plane)
        prt.Update()
        Return plane
    End Function

End Module
