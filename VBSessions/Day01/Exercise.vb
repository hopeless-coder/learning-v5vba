Module Exercise
    ' 2 Collections
    ' 1 Collection has 10 names
    ' 2nd collection is empty
    ' Transfer all the names 
    'in the second collection except
    ' your name
    Sub ex()
        Dim CollA As New Collection
        Dim CollB As New Collection
        CollA.Add("MyName")
        CollA.Add("One")
        CollA.Add("Two")
        'CollA.Add(3)
        'CollA.Add(4)
        'CollA.Add(5)
        'CollA.Add(6)
        'CollA.Add(7)
        'CollA.Add(8)
        'CollA.Add(9)

        For Each item In CollA
            If item <> "MyName" Then
                CollB.Add(item)
            End If
        Next

        For Each item In CollB
            Console.WriteLine(item)
        Next


    End Sub
End Module
