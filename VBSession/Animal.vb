Public Class Animal
    'Fields
    Private _age As Single
    Private _color As String
    Private _name As String
    Public Property name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Public Property Age() As Single
        Get
            Return _age
        End Get
        Set(ByVal value As Single)
            _age = value
        End Set
    End Property

    Public WriteOnly Property Color() As String

        Set(ByVal value As String)
            _color = value
        End Set
    End Property


    Overridable Sub Walk()
        Console.WriteLine("Here is the animal walking!")
        Console.ReadLine()
    End Sub

    Sub New()
        Console.WriteLine("This is base class constructor")
        Console.ReadLine()
    End Sub

    Sub New(n As String)
        Console.WriteLine("This is base class constructor")
        Console.ReadLine()
    End Sub
End Class
