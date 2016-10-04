Public Class UserPlane
    Inherits Plane

    Public Sub DoThis()

    End Sub

    Public Overrides Sub Draw()
        MsgBox("We are inside  the draw function of UserPlane")
    End Sub

    Public Overrides Sub UnDraw()
        MsgBox("We are inside  the undraw function of UserPlane")
    End Sub
End Class
