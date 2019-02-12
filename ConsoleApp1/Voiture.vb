Public Class Voiture
    Inherits Vehicule

    Private _roues As String

    Public Property LesRoues As String
        Get
            Return _roues
        End Get
        Set(value As String)
            _roues = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return MyBase.ToString
    End Function

    Public Function getMoteur() As String
        Return LeMoteur
    End Function

End Class
