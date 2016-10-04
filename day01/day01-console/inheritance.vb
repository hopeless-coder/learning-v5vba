Module inheritance
    Sub Main()
        Dim userPlane As Plane

        Dim planes As New Collection
        planes.Add(New UserPlane)
        planes.Add(New PrincipalPlane)
        planes.Add(New UserPlane)
        planes.Add(New Plane)

        For Each pl In planes
            userPlane = pl
            userPlane.Draw()
        Next

    End Sub
End Module
