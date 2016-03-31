Module LogicBlocks
    ' Logic Blocks
    '  Functions
    '   they return a value
    '  Subroutines
    '   do not return a value

    'Lifecycle of logic blocks
    '   Declare
    '   Implementation/ body
    '   Call

    'Subroutines Declaration
    '   Keyword
    '   name
    Sub MySub()
        'body\
        Console.WriteLine("We are inside mySub sub!")

        Dim rtr As String
        rtr = MyFunc()
        Console.WriteLine(rtr)
    End Sub

    'Function Declaration
    Function MyFunc() As String
        'body
        Console.WriteLine("We are inside myFunc function!")
        'DoThis()
        Return "Done"
    End Function

    Sub DoThis()
        Console.WriteLine("We are inside DoThis sub!")
    End Sub
End Module
