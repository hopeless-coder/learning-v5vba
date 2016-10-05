Imports INFITF
Imports MECMOD
Imports PARTITF
Imports HybridShapeTypeLib
Public Class Form1
    Private pApplication As Application
    Private pDocument As Document
    Private pPartDocument As PartDocument
    Private pPart As Part
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pApplication = GetObject(, "CATIA.Application")
        If pApplication Is Nothing Then
            MsgBox("We could not connect to catia appplication")
        End If
        ' MsgBox("We have connected to CATIA")
        pDocument = pApplication.Documents.Item(1) 'in the memory &HFF08
        'MsgBox(pDocument.Name)
        'pDocument(&HFF08) -->  : Part1.CATPart
        pPartDocument = pDocument
        'pPartDocument =pDocument
        'pPartDocument(&HFF08) --> Part1.CATPart
        pPart = pPartDocument.Part

        'Dim pBody As Body
        'pBody = pPart.Bodies.Item(1)
        'pBody.Name = "This name has been changed"
        'here I would like to add a body onto the part
        'Dim newBody As Body
        'newBody = pPart.Bodies.Add()
        'newBody.Name = "This is the fresh body added"
        'pPart.Update()
        'CreateTenBodies()
        'CreatePadFromSketch()
        CreatePointOnCurve()
    End Sub

    Public Sub CreateTenBodies()
        Dim pThisBody As Body
        For index = 1 To 10
            pThisBody = pPart.Bodies.Add()
            pThisBody.Name = "Body-" + index.ToString()
        Next
        pPart.Update()
    End Sub

    Public Sub CreatePadFromSketch()
        Dim pPartBody As Body
        pPartBody = pPart.Bodies.Item(1)
        'pPartBody = pPart.MainBody 
        Dim pSketch As Sketch
        pSketch = pPartBody.Sketches.Item(1)

        Dim pShapeFac As ShapeFactory ' handle to the shape factory 
        pShapeFac = pPart.ShapeFactory
        ' this is defining the domain of the shape facotry


        Dim pPad As Pad
        pPad = pShapeFac.AddNewPad(pSketch, 20.0)

        pPart.Update()
    End Sub

    Public Sub UsingTheSelection()
        Dim pSelection As Selection
        pSelection = pPartDocument.Selection
        pSelection.Clear()

        Dim pBody As Body
        pBody = pPart.Bodies.Item(4)

        pSelection.Add(pBody)
        pSelection.Delete()

        pPart.Update()
    End Sub

    Public Sub AddDeleteBodies()
        'first add 10 bodies
        'then delete all the bodies added.
        Dim pBody As Body
        For index = 1 To 10
            pBody = pPart.Bodies.Add()
        Next
        Dim pSelection As Selection
        pSelection = pPartDocument.Selection
        pSelection.Clear()
        For index = 11 To 2 Step -1
            pSelection.Add(pPart.Bodies.Item(index))
            pSelection.Delete()
        Next

        pPart.Update()
    End Sub

    Public Sub CreateRedPad()
        Dim pSelection As Selection

        pSelection = pPartDocument.Selection
        pSelection.Clear()

        Dim pSketch As Sketch
        pSketch = pPart.MainBody.Sketches.Item(1)

        Dim pShapeFac As ShapeFactory
        pShapeFac = pPart.ShapeFactory

        Dim pPad As Pad
        pPad = pShapeFac.AddNewPad(pSketch, 100.0)

        pSelection.Add(pPad)
        pSelection.VisProperties.SetRealColor(255, 0, 0, 0)
        pPart.Update()
    End Sub

    Public Function CreateHB(name As String) As HybridBody
        Dim pHB As HybridBody
        pHB = pPart.HybridBodies.Add()
        pHB.Name = name
        Return pHB
    End Function
    Public Function SearchHBByName(name As String) As HybridBody
        Dim pHB As HybridBody
        For Each hb In pPart.HybridBodies
            If hb.Name = name Then
                pHB = hb
                Exit For
            End If
        Next
        Return pHB
    End Function
    Public Function CreatePoint(x As Double, y As Double, z As Double) As HybridShapePointCoord
        Dim pHB As HybridBody
        pHB = SearchHBByName("Construction")
        If pHB Is Nothing Then
            pHB = CreateHB("Construction")
        End If

        Dim pFac As HybridShapeFactory
        pFac = pPart.HybridShapeFactory

        Dim pPoint As HybridShapePointCoord
        pPoint = pFac.AddNewPointCoord(x, y, z)
        pHB.AppendHybridShape(pPoint)

        pPart.Update()
        Return pPoint
    End Function

    Public Function CreateLineBtwPoints() As HybridShapeLinePtPt

        Dim pFac As HybridShapeFactory
        pFac = pPart.HybridShapeFactory

        Dim pt1, pt2 As HybridShapePointCoord
        pt1 = CreatePoint(0, 0, 0)
        pt2 = CreatePoint(0, 0, 100.0)

        Dim pConstrHb As HybridBody
        pConstrHb = SearchHBByName("Construction")
        Dim pt1Ref, pt2Ref As Reference
        pt1Ref = pPart.CreateReferenceFromObject(pt1)
        pt2Ref = pPart.CreateReferenceFromObject(pt2)

        Dim pLine As HybridShapeLinePtPt
        pLine = pFac.AddNewLinePtPt(pt1Ref, pt2Ref)

        pConstrHb.AppendHybridShape(pLine)
        pPart.Update()
        Return pLine
    End Function

    Public Sub CreatePointOnCurve()
        Dim pFac As HybridShapeFactory
        pFac = pPart.HybridShapeFactory
        Dim pHB As HybridBody


        Dim pLineRef As Reference
        pLineRef = pPart.CreateReferenceFromObject(CreateLineBtwPoints())
        pHB = SearchHBByName("Construction")
        Dim pPtOnCurve As HybridShapePointOnCurve
        pPtOnCurve = pFac.AddNewPointOnCurveFromPercent(pLineRef, 0.5, False)
        pHB.AppendHybridShape(pPtOnCurve)

        pPart.Update()
    End Sub


End Class
