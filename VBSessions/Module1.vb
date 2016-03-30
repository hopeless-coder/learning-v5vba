Module Module1

    Sub Main()
        'LogicBlocks.MySub()
        'Exercise.ex()
        Logic.CalculateAge("Jon", 40.0, 110.0)
        Logic.MySub()
        'This is a comment
        ' What is a program?
        ' Set of instructions
        ' Data + Logic <--> Bidirectional
        ' Data
        '   Native variables/ Value type
        '      They are fixed in size
        '      They are stored on Stack (Memory management)
        '      They are faster
        '      Dispose on their own
        '   Object Type Variables / Reference variables
        '       They have varying sizes
        '       They are stored on Heap
        '       They are slower
        '       Dispose explicitly

        'Constants
        ' Const name As Single = 3.14

        ' Lifecycle of variables
        '   Declare
        '   Assign / use 
        '   Dispose

        'Dim keyword -- Dimension
        ' Name of the variable
        ' data type 

        'Declared
        Dim num As Integer ' 4 bytes
        Dim flag As Boolean ' 2 bytes
        Dim sing As Single ' 4 bytes
        Dim dbl As Double ' 8 bytes
        Dim prec As Decimal ' 16 bytes -- scientific/ financial
        Dim name As String ' depending on the size of string

        num = 10
        flag = True
        sing = 213213.37452154
        dbl = 5778.6748214
        prec = 23721636.218362831
        name = "VB Session Day 1"

        Console.WriteLine(flag)
        Console.WriteLine("The number value is " & num)
        Console.WriteLine("The value of variables are {0}, {1}, {2}", name, flag, sing)
        Console.ReadLine()

        'Dim userValue As String
        'userValue = Console.ReadLine()

        'Operations
        Dim num1 As Integer = 10
        Dim num2 As Integer
        num2 = 20

        Dim addNum As Integer
        addNum = num1 + num2

        Dim subNum As Integer
        subNum = num2 - num1

        Dim prodNum As Integer
        prodNum = num1 * num2

        Dim result As Integer
        result = num2 / num1
        ' Console.WriteLine(result)

        Dim divResult As Integer
        Dim quotient As Integer
        quotient = Math.DivRem(num2, num1, divResult)
        ' Console.WriteLine(quotient)

        'Concatenation of strings
        Dim name1 As String
        name1 = "Day 1 of VB"
        Dim name2 As String
        name2 = " and we are confident of learning well!"
        Dim strResult As String
        strResult = name1 & name2 ' always make use of this for concatenation
        'strResult = name1 + name2 ' avoid this!
        Console.WriteLine(strResult)

        Dim leftPortion As String
        Dim rightPortion As String

        leftPortion = Left(strResult, 10)
        Console.WriteLine("The left portion is :" & leftPortion)
        Console.ReadLine()

        rightPortion = Right(strResult, 20)
        Console.WriteLine("The right portion is :" & rightPortion)
        Console.ReadLine()

        Dim position As Integer
        position = InStr(strResult.ToLower(), "vb")
        Console.WriteLine(strResult.ToLower())
        Console.WriteLine(position)
        Console.ReadLine()
        'InstrRev

        'conversions
        Dim num3 As Integer
        num3 = 40

        Dim numToStr As String
        numToStr = CStr(num3)
        numToStr = num3.ToString()

        Dim str As String
        str = "50"

        Dim strAsNum As Integer
        strAsNum = CInt(str)
        'CDbl , CSng

        Dim number As Integer = 10
        Dim strAnother As String = "I am a string "
        Console.WriteLine(strAnother & number)
        Console.ReadLine()

        'Object Type variables
        ' Lifecycle of variables
        '   Declare -- Use New Keyword
        '   Assign / use 
        '   Dispose

        Dim pColl As New Collection
        pColl.Add("Hi")
        pColl.Add(90)
        pColl.Add("Some more")
        pColl.Add(100, "Number")
        'pColl.Add(20, , 3, 1) ' as good as adding an item at index 2
        'Console.WriteLine(pColl)
        Console.WriteLine("Retreieving the values using keys in collection:" & pColl.Item("Number"))
        Console.WriteLine("The first item of collection is:" & pColl.Item(1))
        Console.ReadLine()

        'Dim noOfItems As Integer = pColl.Count
        'pColl.Remove(noOfItems)
        'pColl.Add("another", "Number")
        'Console.WriteLine(pColl.Item("Number"))
        pColl.Remove(1)
        pColl.Remove("Number")

        'Console.WriteLine("Retreieving the values using keys in collection:" & pColl.Item("Number"))
        Console.WriteLine("The first item of collection is:" & pColl.Item(1))
        ' Console.WriteLine("The last item of collection is:" & pColl.Item(4))
        Console.ReadLine()

    End Sub

End Module

