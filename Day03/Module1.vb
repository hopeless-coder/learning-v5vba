Module Module1

    Sub Main()
        'this is the handle to the application interface
        Dim pApplication As INFITF.Application
        'this is when we request the handle on catia application to windows
        pApplication = GetObject(, "CATIA.Application")
        If pApplication Is Nothing Then
            'no catia application running on the machine
            Console.WriteLine("we have not found the application running on your machine")
            Exit Sub
        End If
        'good we have connected to catia

        Dim pDocuments As INFITF.Documents
        pDocuments = pApplication.Documents 'getting the documents collection
        Dim nameOfTheDoc = "Part2.CATPart"
        Dim pDocument As INFITF.Document

        For index = 1 To pDocuments.Count
            If pDocuments.Item(index).Name = nameOfTheDoc Then
                pDocument = pDocuments.Item(index)
                Exit For
            End If
        Next
        'start working on the document here

        Dim pPartDoc As MECMOD.PartDocument
        pPartDoc = pDocument 'this is what is called as the downcasting

        Dim pPart As MECMOD.Part 'this is just the handle to the part
        pPart = pPartDoc.Part 'this is getting the part

        Dim pBodies As MECMOD.Bodies
        pBodies = pPart.Bodies

        Dim pPartBody As MECMOD.Body
        pPartBody = pBodies.Item(1)

        pPartBody.Name = "Changed body name"

        'now here i woudl want to add a new body to the part
        Dim pNewBody As MECMOD.Body

        pNewBody = pPart.Bodies.Add()
        pNewBody.Name = "New body added"

        'now an exercise for you to help stretch your muscles(finger)
        'add 10 bodies to part, 
        'each body being added has a naming convention
        ' first body has the name : Body_1
        ' second body has the name : Body_2
        ' ... so on.. 
        ' cn you do this ?

        ' for those of you with supernatural capabilities to finish the above already!
        ' here is another assignment
        ' insert 10 bodies
        ' all the 10 have naming convention
        ' odd bodies have the names : 1_body, 3_body ...
        ' even bodies have the names : body_2, body_4 ...

        'i guess you dont need the solution from me ? - smart enough to get the 2 done

        ' now here we are assuming that there is a skecth in CATIA part already
        ' on your machines before you write any code, you can draw a simple sketch in Partbody

        Dim pSketch As MECMOD.Sketch
        pSketch = pPartBody.Sketches.Item(1)

        Dim pShapeFactory As PARTITF.ShapeFactory
        pShapeFactory = pPart.ShapeFactory

        Dim pPad As PARTITF.Pad
        pPad =pShapeFactory.AddNewPad(pSketch, 10.0)
        pPart.Update()

    End Sub

End Module
