Module SelectionOperations
    Public Sub SelectAndDelete(pd As MECMOD.PartDocument, toDelete As INFITF.AnyObject)
        Dim pSelection As INFITF.Selection
        pSelection = pd.Selection
        pSelection.Clear()

        pSelection.Add(toDelete)
        pSelection.Delete()
        pSelection.Clear()
    End Sub

    Public Sub SelectAndTurnRed(pd As MECMOD.PartDocument, toDelete As INFITF.AnyObject)

    End Sub

    Public Sub CopyPaste(pd As MECMOD.PartDocument, source As INFITF.AnyObject, target As INFITF.AnyObject)

    End Sub
End Module
