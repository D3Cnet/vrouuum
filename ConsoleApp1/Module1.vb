Option Explicit On
Option Strict On

''' <summary>
''' Module principale de l'application
''' </summary>

Module Module1

    Dim maKuga As New Voiture
    Dim monTrajet As New Trajet()

    Sub Main()

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
