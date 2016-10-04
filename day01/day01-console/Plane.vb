Public Class Plane
    Protected y_Ordinate As Single
    Protected xCooridnate As Single
    Protected z_Height As Single
    Public Property XCoordinate() As Single
        Get
            Return xCooridnate
        End Get
        Set(ByVal value As Single)
            xCooridnate = value
        End Set
    End Property

    Public Property YOrdinate() As Single
        Get
            Return YOrdinate
        End Get
        Set(ByVal value As Single)
            y_Ordinate = value
        End Set
    End Property

    Public Property ZHeight() As Single
        Get
            Return ZHeight
        End Get
        Set(ByVal value As Single)
            z_Height = value
        End Set
    End Property
    Public Overridable Sub Draw()
        MsgBox("We are inside  the draw function of Plane")
    End Sub

    Public Overridable Sub UnDraw()
        MsgBox("We are inside  the undraw function of Plane")
    End Sub
End Class

Public Class Sample

End Class
