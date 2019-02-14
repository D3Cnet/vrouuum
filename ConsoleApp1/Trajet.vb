''' <summary>
''' Classe décrivant les trajets effectués
''' </summary>
Public Class Trajet

    Private _depart As String = ""
    Private _arrivee As String = ""
    Private _distance As Distance

    Private Property LaDistance As Integer
        Get
            If Not _distance Is Nothing Then
                Return _distance.LaDistance
            Else
                Return -1
            End If

        End Get

        Set(value As Integer)
            If _distance Is Nothing Then
                _distance = New Distance(value)
            Else
                _distance.LaDistance = value
            End If
        End Set

    End Property


    Public Sub SaisirTrajet()
        System.Console.Write(My.Resources.r_depart)
        _depart = System.Console.ReadLine()
        System.Console.Write(My.Resources.r_arrivee)
        _arrivee = System.Console.ReadLine()
        System.Console.Write(My.Resources.r_distance)
        _distance = New Distance(CInt(System.Console.ReadLine()))
    End Sub

    Public Sub New(villeDepart As String, villeArrivee As String, distanceEntreVilles As Integer)
        _depart = villeDepart
        _arrivee = villeArrivee
        _distance = New Distance(distanceEntreVilles)
    End Sub

    Public Sub New()
        MyBase.New()
    End Sub

End Class
