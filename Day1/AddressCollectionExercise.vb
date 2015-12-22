Module AddressCollectionExercise
    '3 collections:
    'collection 1  has names
    'Collection 2 has emails 
    'Code such that collection 3 is going to be a collection of collection representing a complete address
    'e.g:
    'collection 1  ruchira, ruchi
    'collection 2  ruchira_agarwal, ruchi_abc
    'collection 3  col(ruchira, ruchira_agarwal), col(ruchi, ruchi_abc)
     Sub MySub()
        Dim cAlias As New Collection
        Dim cEmails As New Collection

        'Address is a collection of two collections
        Dim cAddr As New Collection

        'Instead of collection you can also use generic list which can contain collections
        'Represents a strongly typed list of objects that can be accessed by index
        'Dim cAddr As New List(Of Collection)

        'Declare a collection which will store an address after checking the conditions
        'This will be newly instantiated on finding a name
        Dim thisAddress As Collection
        Dim thisEmail As String

        'declare a character from where the email will be split
        Dim uscore As Char = "_ c"

        'declare a string array to store strings of an email id
        Dim emailStrings() As String

        'Add Names to collection
        cAlias.Add("Ruchira")
        cAlias.Add("Ruchi")
        cAlias.Add("Niranjan")
        cAlias.Add("Yogesh")

        'Add emails to collection
        cEmails.Add("ruchira_agarwal")
        cEmails.Add("Yogesh_xyz")
        cEmails.Add("ruchi_abc")
        cEmails.Add("Niranjan_abc")
        'In the above addition of emails, you may change the 
        'sequence and try debugging the code as well to understand the conditional test

        If Not cAlias Is Nothing Then
            For index = 1 To cAlias.Count
                'instantiate the collection
                thisAddress = New Collection
                'add name to the new instance of thisAddress
                thisAddress.Add(cAlias.Item(index))
                If Not cEmails Is Nothing Then
                    For innerIndex = 1 To cEmails.Count
                        'store the current email in a variable thisEmail
                        thisEmail = cEmails.Item(innerIndex)
                        'split the email at underscore _ and store in the array
                        emailStrings = thisEmail.Split(uscore)
                        For Each item In emailStrings
                            'Add only those items in thisaddress where emailitem = alias
                            If (item.ToLower() = cAlias.Item(index).ToLower()) Then
                                'add email in thisAddress
                                thisAddress.Add(cEmails.Item(innerIndex))
                            End If
                            'exit the loop when a match is found
                            Exit For
                        Next
                    Next
                    'Now add complete thisAddress in Address collection
                    cAddr.Add(thisAddress)
                End If
            Next
        End If

        'To display the result on console window
        For Each address In cAddr
            Console.Write("(")
            'note that address has 2 items each
            'so address.count will be 2
            For index = 1 To address.Count
                Console.Write(address(index) & " ")
            Next
            Console.Write(")" + ",")
        Next
            Console.ReadLine()
    End Sub
End Module
