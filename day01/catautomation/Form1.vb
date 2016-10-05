Imports INFITF
Imports MECMOD
Imports PARTITF
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
        CreatePadFromSketch()
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
End Class
