Module collection_join
    Sub Main()
        Dim pCities As New Collection
        Dim pSmartCities As New Collection
        Dim pResult As New Collection

        pCities.Add("Delhi")
        pCities.Add("Jaipur")
        pCities.Add("Mumbai")
        pCities.Add("Pune")
        pCities.Add("Mysore")
        pCities.Add("Bangalore")
        pCities.Add("Agra")

        pSmartCities.Add("Pune")
        pSmartCities.Add("Mysore")
        pSmartCities.Add("Mumbai")
        pSmartCities.Add("Jabalpur")
        pSmartCities.Add("Panji")

        'can you write logic to get all the smart cities only listed in the cities collection ?
        For index = 1 To pCities.Count
            For innerIndex = 1 To pSmartCities.Count
                If pCities.Item(index) = pSmartCities.Item(innerIndex) Then
                    pResult.Add(pSmartCities.Item(innerIndex))
                End If
            Next
        Next
        For index = 1 To pResult.Count
            Console.WriteLine(pResult.Item(index))
        Next

        ''this for loop jumps the index by4
        'For index = 2 To 10 Step 4

        'Next

        Dim flag As Boolean
        flag = True
        Dim counter As Integer
        counter = 10
        While flag = True And counter > 0
            Console.WriteLine("the flag is true")
            counter = counter - 1
        End While

        'this is the case when the loop runs for one extra time
        counter = 0
        Do
            Console.WriteLine("this is from inside the do while loop")
            counter = counter - 1
        Loop While counter > 0

        Console.ReadLine()
    End Sub
End Module
