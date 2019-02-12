Public Class Vehicule
    Private _chassis As String
    Private _moteur As String
    Private _carosserie As String

    Public Property LeMoteur As String
        Get
            Return _moteur
        End Get
        Set(value As String)
            _moteur = value
        End Set
    End Property

    Public Property LaCarosserie As String
        Get
            Return _carosserie
        End Get
        Set(value As String)
            _carosserie = value
        End Set
    End Property

    Public Property LeChassis As String
        Get
            Return _chassis
        End Get
        Set(value As String)
            _chassis = value
        End Set
    End Property

    ' Overrides
    '   Public Overrides Function ToString() As String
    '    Return "Description : " & _chassis & " -> " & _moteur & " -> " & _carosserie
    '    End Function
End Class
