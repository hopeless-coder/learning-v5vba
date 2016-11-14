Imports VBSession

Public Class Dragon
    Inherits Animal
    Implements ICanFly

    Public Sub Fly() Implements ICanFly.Fly
        Console.WriteLine("This is the dragon's behaviour of flying!")
        Console.ReadLine()
    End Sub

    Overrides Sub Walk()
        Console.WriteLine("This is the Dragon walking!")
        Console.ReadLine()
    End Sub
End Class
