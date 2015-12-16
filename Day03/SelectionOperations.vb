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
