Imports INFITF
Imports MECMOD
Imports PARTITF
Module SpuriousCoins
    Dim pApplication As Application
    Dim pPart As Part
    Public Sub MakeCoins()
        'just getting the application and the part
        pApplication = GetObject(, "CATIA.Application")
        pPart = CType(pApplication.Documents.Item(1), PartDocument).Part

        'getting the sketches lying underneath
        Dim pCentreSkecth As Sketch = pPart.MainBody.Sketches.Item(1)
        Dim pLeftCutSketch As Sketch = pPart.MainBody.Sketches.Item(2)
        Dim pRightCutSketch As Sketch = pPart.MainBody.Sketches.Item(3)

        'this is where i know how to use CATIA smartly.. 
        'creating separate bodies to create the pads

        Dim pOddSolidBody = pPart.Bodies.Add()
        pOddSolidBody.Name = "OddBody"

        Dim pEvenSolidBody = pPart.Bodies.Add()
        pEvenSolidBody.Name = "EvenBody"

        'loop to create 20 coins

        For index = 1 To 20
            Dim remainder As Integer
            Math.DivRem(index, 2, remainder)
            If remainder <> 0 Then
                'this is the case when you are having the odd case
                CastCoin(index, pOddSolidBody, pCentreSkecth)
            Else
                CastCoin(index, pEvenSolidBody, pCentreSkecth)
            End If
        Next
        CutCoins(pLeftCutSketch, pEvenSolidBody)
        CutCoins(pRightCutSketch, pOddSolidBody)
    End Sub
    Public Sub CastCoin(index As Integer, targetBody As Body, sk As Sketch)
        Dim coinTop As Integer = 15
        Dim coinBottom As Integer = 5

        Dim firstLimit As Double = coinTop * index
        Dim secondLimit As Double = firstLimit - 10

        ' if we are not to recreate the sketches and use the same sketch we need to play around with first and second limit
        Dim pShapeFactory As ShapeFactory = pPart.ShapeFactory
        pPart.InWorkObject = targetBody 'this is when you are clicking inwork object
        Dim pPad As Pad = pShapeFactory.AddNewPad(sk, firstLimit)
        pPad.SecondLimit.Dimension.Value = (-1) * secondLimit
        pPart.Update()
    End Sub

    Public Sub CutCoins(sk As Sketch, bd As Body)
        Dim pShapeFactory As ShapeFactory = pPart.ShapeFactory
        pPart.InWorkObject = bd 'this is when you are clicking inwork object
        Dim pPocket As Pocket = pShapeFactory.AddNewPocket(sk, 300)
        pPocket.FirstLimit.LimitMode = CatLimitMode.catUpToLastLimit
        pPart.Update()
    End Sub
End Module
