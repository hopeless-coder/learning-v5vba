Imports INFITF
Imports MECMOD
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pApplication As Application
        pApplication = GetObject(, "CATIA.Application")
        If pApplication Is Nothing Then
            MsgBox("We could not connect to catia appplication")
        End If
        MsgBox("We have connected to CATIA")

        Dim pDocument As Document
        pDocument = pApplication.Documents.Item(1) 'in the memory &HFF08
        MsgBox(pDocument.Name)

        'pDocument(&HFF08) -->  : Part1.CATPart

        Dim pPartDocument As PartDocument
        pPartDocument = pDocument

        'pPartDocument =pDocument
        'pPartDocument(&HFF08) --> Part1.CATPart

        Dim pPart As Part
        pPart = pPartDocument.Part

        Dim pBody As Body
        pBody = pPart.Bodies.Item(2)

        pBody.Name = "This name has been changed"

        'here I would like to add a body onto the part
        Dim newBody As Body
        newBody = pPart.Bodies.Add()
        newBody.Name = "This is the fresh body added"

        pPart.Update()
    End Sub
End Class
