Module nativevars_funcs

    Function DoThisAsWell(msg As String, lengthFromLeft As Integer) As String
        Dim result As String
        result = msg.Substring(0, lengthFromLeft)
        Return result
    End Function
    'DRY principle 
    Sub DoThis(msg As String, lengthFromLeft As Integer)
        Dim result As String
        result = msg.Substring(0, lengthFromLeft)
    End Sub
    Sub Main()
        'the compiler should ignore this.
        'this Is another line that i want the compiler to ignore
        'fdsfudshfjksfpp
        '40% of the coding lines
        ' what is a program ?
        ' Logic <--> Data
        ' data - constants , variables
        'variables 
        'declare
        'name, type
        'use
        'dispose 
        Dim employee As String
        employee = "Niranjan"
        Dim count As Integer
        count = 10
        Dim accuracy As Single '4 bytes 
        accuracy = 0.78
        employee = "Niranjan Awati"
        count = 19
        accuracy = 0.76
        Dim result As Integer '2ytes
        result = count + 190
        result = count - 190
        Dim multiplicationResult As Integer
        multiplicationResult = result * 190
        Dim divisionResult As Single
        divisionResult = 6 / 10
        ' this has a precsion of 12 digits after decimal
        Dim precision As Double ' 4 bytes
        Dim empNo As String
        empNo = "41993"
        result = CInt(empNo) + 90
        Dim firstName As String
        firstName = "Niranjan"
        Dim empId As Integer
        empId = 41993
        Dim emailId As String
        emailId = firstName + empId.ToString()
        'emailId = "Niranjan41993"
        'string is not a simple one but a complex one with some behaviour attached to it
        Dim messageOfTheDay As String
        messageOfTheDay = "fortune favours the brave, but we have just started with VB"
        Dim messageOfTheDayHighlight As String
        messageOfTheDayHighlight = messageOfTheDay.ToUpper()

        Dim subMessageOfTheDay As String
        subMessageOfTheDay = messageOfTheDay.Substring(0, 20)

        Dim rtrResult As String

        rtrResult = DoThisAsWell("Pass any message of your liking", 10)
        DoThis("Yet this is another message here", 30)

    End Sub


End Module
