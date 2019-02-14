''' <summary>
''' Classe de gestion de la distance
''' </summary>
Public Class Distance

    Private _distance As Integer = 0

    Public Property LaDistance As Integer
        Get
            Return _distance
        End Get
        Set(value As Integer)
            _distance = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(laDistance As Integer)
        _distance = laDistance
    End Sub

End Class
