Module objectvars
    Sub Main()
        ' redefine the boudaries , data has some behaviour attached to it
        Dim pNames As New Collection 'Object type, complex type
        'Array : is like the native types, limited in the functionality
        'pNames = New Collection 'instantiation

        pNames.Add("Mysore")
        pNames.Add("Bangalore")
        pNames.Add("Pune")
        pNames.Add("Chandigarh")

        Dim flag As Boolean
        flag = True

        If pNames.Count > 4 Then
            Console.WriteLine("The collection has more than 4 elements")

        ElseIf pNames.Count < 4 Then
            Console.WriteLine("The collection has less than  4 elements")
        Else
            Console.WriteLine("The collection has exactly 4 elements")
            If flag = True Then
                Console.WriteLine("and the flag value is true as well")
            End If
        End If

        For index = 1 To pNames.Count
            Console.WriteLine(pNames.Item(index))
        Next


        pNames = Nothing
        Console.ReadLine()
    End Sub
End Module
