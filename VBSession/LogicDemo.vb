Module LogicDemo
    Public newname As String
    'Logic
    '   Functions
    '       Return a value
    '   Subroutines
    '       Do not return a value
    'Lifecycle
    '   Declaration
    '   Implementation ( Body of the function/ sub)
    '   Call from another logic block
    '   Test

    Function MyFunc() As Boolean
        'body
        Console.WriteLine("We are inside a function")
        Console.ReadLine()
        Return True
    End Function

    Sub MySub()
        'body
        Console.WriteLine("We are inside the MySub")
        Dim rtr As Boolean = MyFunc()
        Console.WriteLine(rtr)
        Console.ReadLine()
        Calculation(10, "Ruchira", 55.8)
    End Sub

    'Function Signature
    '   Name of the function
    '   No. of Parameters
    '   (Data / object )Type of parameters
    '   Sequence of parameters
    '   Return type
    '   Security
    Function Calculation(age As Integer, name As String, weight As Single) As String
        newname = "abc"
        If age > 25 Then
            'Do something
            Console.WriteLine("Age is as expected")
        ElseIf age < 25 And weight >= 55 Then
            'do something
        Else
            'Do this
            Console.WriteLine("Runs when all the above statements are false!")
        End If

        'nested if
        If name = "Ruchira" Then
            If age >= 25 Then
                'do something
            ElseIf age < 25 Then
                'Do something else
            End If
        End If

        'Select
        Select Case age
            Case 25

            Case 26

            Case 40, 45, 17

            Case Else
                'Do this if above conditions are false
        End Select
        Return "Hi"
    End Function

    Public Function Calculation(text As String, flag As Boolean) As Boolean
        Console.WriteLine("We are inside second calculation function")
        Dim index As Integer

        For index = 1 To 10 Step 2
            Console.WriteLine("Students in the class are:" & index)
        Next
        Console.ReadLine()

        For counter = 10 To 1 Step -1
            Console.WriteLine("Students in the class are:" & counter)
        Next
        Console.ReadLine()

        Dim coll1 As New Collection
        For items = 1 To 10
            coll1.Add(items)
        Next

        For Each value In coll1
            Console.WriteLine(value)
        Next
        Console.ReadLine()

        'While
        Dim index1 As Integer = 1
        While index1 >= 1
            Console.WriteLine(index1)
            index1 = index1 - 1
        End While

        'Do while
        Do
            Console.WriteLine(index1)
            index1 = index1 - 1
        Loop While index1 >= 1
        Return True
    End Function

    Function DoThis() As Boolean
        Dim number As Integer
        newname = "xyz"
        Return True
    End Function


End Module
