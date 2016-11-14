Module Module1
    Sub MySub()
        Dim coll1 As New Collection
        Dim coll2 As New Collection
        Dim result As New Collection
        For index = 1 To 10
            coll1.Add(Rnd())
            coll2.Add(Rnd())
        Next

        For Each item In coll1
            Console.WriteLine(item)
        Next
        Console.WriteLine("*******************************")
        For Each item In coll2
            Console.WriteLine(item)
        Next
        Console.ReadLine()
        For counter = 1 To 10
            If coll1.Item(counter) >= coll2.Item(counter) Then
                result.Add(coll1.Item(counter))
            Else
                result.Add(coll2.Item(counter))
            End If
        Next
        For Each item In result
            Console.WriteLine(item)
        Next

        Console.ReadLine()
    End Sub

    Sub Main()

        'Dim newAnimal As Animal 'handle to the base
        'newAnimal = New Dog ' object of the sub class
        'newAnimal.Walk()
        'Dim anotherDog As Dog
        'anotherDog = CType(newAnimal, Dog)
        'anotherDog.Jump()

        Dim bird As ICanFly
        bird = New Bird()
        bird.Fly()

        Dim dragon As ICanFly
        dragon = New Dragon()
        dragon.Fly()

        'This is a comment
        'What is a program?
        ' Set of instructions
        '   Data + Logic -- Bidirectional relationship
        '       Data
        '          1. Variables
        '               Change their value over time / dynamic values
        '                   Native type/ Value Type (Stored on stack on memory)
        '                       fixed in size
        '                       fast and easy to retrive
        '                       dispose or deallocate the memory is implicit
        '                       how you declare them is different from the object type
        '                   Object type/ Reference type (Stored on heap on memory)
        '                       they vary in size
        '                       relatively slower to access
        '                       dispose or deallocate the memory is explicitly
        '          2. Constants
        '               Their value remains fixed over the execution of the program/application

        'Lifecycle of variables
        '   Declare them
        '   Assign / Use them
        '   Dispose them

        'Declare some variables
        '   Dim -- Dimension
        '   Name of the variable
        '   as 
        '   data type

        'Native type variables
        Dim flag As Boolean ' 2 bytes
        Dim num As Integer ' 4 bytes
        Dim sng As Single ' 4 bytes -- 7 digit precision
        Dim dbl As Double ' 8 bytes -- 15 digits of precision
        Dim dec As Decimal ' 16 bytes -- 28 digits precision / financial calculations
        Dim name As String ' occupy the size of the value it contains

        'Use
        flag = True
        num = 10
        sng = 123.1012
        dbl = 213163.123213
        dec = 0.8039281038108
        name = "Ruchira"

        'Constants
        Const x As Integer = 3
        Const pi As Single = 3.1412

        ' display some values on the screen
        Console.WriteLine(flag)
        Console.WriteLine("This is value of num variable" & num)
        Console.WriteLine(sng)
        Console.WriteLine(dbl)
        Console.WriteLine(dec)
        Console.WriteLine(name)
        Console.ReadLine()

        'Data operations - Integer
        Dim num1 As Integer = 20
        Dim num2 As Integer = 10

        'addition
        Dim addResult As Integer
        addResult = num1 + num2

        'subtraction
        Dim subtResult As Integer
        subtResult = num1 - num2

        'multiply
        Dim prodResult As Integer
        prodResult = num1 * num2

        'division
        Dim divResult As Integer
        divResult = num1 / num2

        'divRem
        Dim quotient As Integer
        Dim remainder As Integer
        quotient = Math.DivRem(num1, num2, remainder)

        Console.WriteLine(addResult)
        Console.WriteLine(prodResult)
        Console.WriteLine(subtResult)
        Console.WriteLine(divResult)
        Console.WriteLine(quotient)
        Console.WriteLine(remainder)
        Console.ReadLine()

        'String operations
        Dim str1 As String
        Dim str2 As String
        str1 = "This is a VB session"
        str2 = " on Digital Tutor"
        Dim strResult As String
        'concatenation of strings
        strResult = str1 & str2 'recommended way for concatenation
        ' strResult = str1 + str2 ' this is best avoided
        Console.WriteLine(strResult)

        'Left Portion
        Dim leftPortion As String
        leftPortion = Left(strResult, 10)
        Console.WriteLine(leftPortion)

        Dim rightPortion As String
        rightPortion = Right(strResult, 10)
        Console.WriteLine(rightPortion)

        'position
        Dim position As Integer
        position = InStr(strResult.ToUpper(), "VB")
        Console.WriteLine(strResult.ToUpper())
        Console.WriteLine(strResult)
        Console.WriteLine(position)
        Console.ReadLine()

        'Type Conversions
        Dim number As Integer
        Dim str As String
        str = "123"
        'number = CInt(str) ' string to integer conversion
        ' str = number.ToString() ' integer to string conversion
        'Cstr

        Dim dblNum As Double
        Dim dblStr As String
        dblStr = "1223.213"
        dblNum = CDbl(dblStr) ' string to double conversion

        number = CType(str, Integer)
        Console.WriteLine(number)
        Console.ReadLine()

        'object/reference type variables
        'Lifecycle
        ' Declare
        ' Use - Added, Removed, Retrieval
        ' Dispose

        Dim myCollection As New Collection
        myCollection.Add("Ruchira")
        myCollection.Add("Niranjan")
        myCollection.Add(1)
        myCollection.Add(1.98)
        myCollection.Add(2)

        Console.WriteLine("Items in the collection are {0},{1},{2},{3},{4}", myCollection.Item(1), myCollection.Item(2), myCollection.Item(3), myCollection.Item(4), myCollection.Item(5))
        Console.ReadLine()

        myCollection.Remove(4)
        Console.WriteLine("New Items in the collection are {0},{1},{2},{3}", myCollection.Item(1), myCollection.Item(2), myCollection.Item(3), myCollection.Item(4))
        Console.ReadLine()

        myCollection = Nothing
        'Console.WriteLine("New Items in the collection are {0},{1},{2},{3}", myCollection.Item(1), myCollection.Item(2), myCollection.Item(3), myCollection.Item(4))
        'Console.ReadLine()
    End Sub
End Module
