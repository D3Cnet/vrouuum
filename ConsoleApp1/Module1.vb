Option Explicit On
Option Strict On

''' <summary>
''' Module principale de l'application
''' </summary>

Module Module1

    Dim maKuga As New Voiture
    Dim monTrajet As New Trajet()

    Function NbreArgument() As Integer
        Dim nbre As Integer = 0
        Dim argument As String

        For Each argument In My.Application.CommandLineArgs
            nbre += 1
        Next

        Return nbre

    End Function

    Function aide() As Boolean
        Dim argument As String
        Dim demandeAide As Boolean = False

        For Each argument In My.Application.CommandLineArgs
            If argument = "--help" Or argument = "-help" Or argument = "/?" Then
                System.Console.WriteLine("Ceci est une aide personnalisée de l'application")
                demandeAide = True
            End If
        Next

        Return demandeAide

    End Function


    Sub Main()

        If NbreArgument() <> 0 Then
            If aide() Then
                Exit Sub
            End If
        End If

        maKuga.LaCarosserie = "Grosse"
        maKuga.LeChassis = "Epais"
        maKuga.LeMoteur = "Enorme"
        maKuga.LesRoues = "4X4"

        System.Console.WriteLine(maKuga)
        System.Console.ReadKey()

        System.Console.WriteLine(maKuga.getMoteur)
        System.Console.ReadKey()


    End Sub


End Module
