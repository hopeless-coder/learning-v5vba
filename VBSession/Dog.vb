Public Class Dog
    Inherits Animal
    Private _breed As String
    Public Property Breed() As String
        Get
            Return _breed
        End Get
        Set(ByVal value As String)
            _breed = value
        End Set
    End Property

    Private _country As String
    Public Property Country() As String
        Get
            Return _country
        End Get
        Set(ByVal value As String)
            _country = value
        End Set
    End Property

    Sub Jump()
        Console.WriteLine("This is the Dog Jumping!")
    End Sub

    Overrides Sub Walk()
        Console.WriteLine("Here is the Dog walking!")
        Console.ReadLine()
    End Sub

    Sub New()
        Console.WriteLine("This is child class constructor")
        Console.ReadLine()
    End Sub
End Class
