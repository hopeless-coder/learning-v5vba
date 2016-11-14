Imports VBSession

Public Class Bird
    Implements ICanFly

    Public Sub Fly() Implements ICanFly.Fly
        Console.WriteLine("This is the Bird's behaviour of flying!")
        Console.ReadLine()
    End Sub
End Class
