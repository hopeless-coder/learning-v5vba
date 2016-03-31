Module Logic
    Dim x As Integer
    'Functions Declaration
    ' Name
    ' return type
    ' no. of parameters
    ' type of parameters
    ' sequence of parameters
    ' security
    Function CalculateAge(name As String, weight As Single, height As Single) As Integer
        ' Conditions 
        If name = "John" Then
            Console.WriteLine("Now I can provide the age!")
        ElseIf weight >= 40.0 And weight <> 100 Then
            'Do something else
        ElseIf height <= 100.0 Then

        Else
            Console.WriteLine("Inside Else")
            'If none of the above conditions are true, this will be executed
        End If

        'Nested
        If name = "Ruchi" Then
            If height > 150.0 Then
            ElseIf height < 150.0 Then

            End If
        ElseIf name = "John" Then
            'Do something else
        End If

        'Select
        Select Case weight
            Case 40.0

            Case 20.0, 45.0

            Case Is > 42.0

            Case Else

        End Select

        Dim age As Integer
        Select Case age
            Case Is < 18
                Console.WriteLine("Don't serve beer!")
            Case Is >= 60
                Console.WriteLine("Serve Juice!")
            Case Else
                Console.WriteLine("Serve Water")
        End Select

        'Looping Statements
        For index = 1 To 5 Step 1
            Console.WriteLine(index)
        Next

        For index = 1 To 10 Step 2
            Console.WriteLine(index)
        Next

        For index = 5 To 1 Step -1
            Console.WriteLine(index)
        Next

        For index = 1 To 4 Step 0.5
            Console.WriteLine(index)
        Next

        Dim pColl As New Collection
        For index = 1 To 10
            pColl.Add(index)
        Next
        For Each item In pColl
            Console.WriteLine(item)
        Next

        ' While
        While weight > 0
            'Do something
            Console.WriteLine(weight)
            weight = weight - 1
        End While

        ' Do While 
        weight = 38.0
        Do
            Console.WriteLine("Will execute at least once")
            weight += 1
        Loop While weight = 40.0

        Return 0
    End Function


    Function CalculateAge(name As String) As Boolean
        x = 100
        Return True
    End Function

    'Won't work as the function differs only bt return type
    'Function CalculateAge(native As String) As String
    '    Return "Done"
    'End Function

    'function overloading
    Sub MySub()
        CalculateAge("Ruchira")
        x = 10
    End Sub

End Module
