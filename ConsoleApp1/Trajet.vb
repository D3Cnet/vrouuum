''' <summary>
''' Classe décrivant les trajets effectués
''' </summary>
Public Class Trajet

    Private _depart As String
    Private _arrivee As String

    Private _distance As Distance

    Public Sub saisir()
        System.Console.Write(My.Resources.r_depart)
        _depart = System.Console.ReadLine()
        System.Console.Write(My.Resources.r_arrivee)
        _arrivee = System.Console.ReadLine()
    End Sub

End Class
