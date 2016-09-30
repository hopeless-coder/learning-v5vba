Public Class Employee
    Private Empno As Integer
    Public Property EmpNumber() As Integer
        Get
            Return Empno
        End Get
        Set(ByVal value As Integer)
            Empno = value
        End Set
    End Property
    Private Email As String
    Public Property EmployeeeEmail() As String
        Get
            Return Email
        End Get
        Set(ByVal value As String)
            Email = value
        End Set
    End Property
End Class
