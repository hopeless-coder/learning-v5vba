Public Class Cat ' This is the derived/ child/ sub class / Specific
    Inherits Animal ' This is the parent/ super/ Generic / Base
    'is a type of animal
    Private _breed As String
    Public Property Breed() As String
        Get
            Return _breed
        End Get
        Set(ByVal value As String)
            _breed = value
        End Set
    End Property

    Sub MakesNoise()

    End Sub

    Sub DrinksMilk()

    End Sub

    Sub New()
        Console.WriteLine("We are inside the child class constructor")
    End Sub
End Class
