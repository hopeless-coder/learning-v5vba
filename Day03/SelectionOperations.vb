Module SelectionOperations
    Public Sub SelectAndDelete(pd As MECMOD.PartDocument, toDelete As INFITF.AnyObject)
        Dim pSelection As INFITF.Selection
        pSelection = pd.Selection
        pSelection.Clear()

        pSelection.Add(toDelete)
        pSelection.Delete()
        pSelection.Clear()
        pd.Part.Update()
    End Sub

    Public Sub ReddenAllOversizedPads(pd As MECMOD.PartDocument, oversizeLimit As Double)
        ' can you complete this ?
        ' all what you receive as the param is the partdocument
        ' assume you have created 10 pads in PartBody 
        ' if total length of the pad is greater than the oversize limit , color the pad red
        ' if less than the limit color the pad green
        ' if equal to the limit then color blue

        'let me try my hands at the ideal solution
        ' .. you can shamelessly copy this :)

        'getting to the body that contains all the pads

        Dim pMainBody As MECMOD.Body
        pMainBody = pd.Part.Bodies.Item(1)

        'lets prep the selection object here
        Dim pSelection As INFITF.Selection
        pSelection = pd.Selection
        pSelection.Clear()
        'now lets iterate for all the shapes that are in the Body 
        For index = 1 To pMainBody.Shapes.Count
            Dim pThisPad As PARTITF.Pad
            If TypeOf pMainBody.Shapes.Item(index) Is PARTITF.Pad Then
                pThisPad = pMainBody.Shapes.Item(index)
                pSelection.Add(pThisPad)
                Dim totalHeight As Double
                totalHeight = pThisPad.FirstLimit.Dimension.Value + pThisPad.SecondLimit.Dimension.Value
                If totalHeight <> oversizeLimit Then
                    If totalHeight > oversizeLimit Then
                        'color it red here
                        pSelection.VisProperties.SetRealColor(255, 0, 0, 0)
                    Else
                        pSelection.VisProperties.SetRealColor(0, 255, 0, 0)
                    End If
                Else
                    pSelection.VisProperties.SetRealColor(0, 0, 255, 0)
                End If
                pSelection.Clear()
            End If



        Next


    End Sub

    Public Sub SelectAndTurnRed(pd As MECMOD.PartDocument, toChange As INFITF.AnyObject)
        Dim pSelection As INFITF.Selection
        pSelection = pd.Selection
        pSelection.Clear()

        pSelection.Add(toChange)
        pSelection.VisProperties.SetRealColor(255, 0, 0, 0)
        pd.Part.Update()
    End Sub

    Public Sub CopyPaste(pd As MECMOD.PartDocument, source As INFITF.AnyObject, target As INFITF.AnyObject)

    End Sub
End Module
