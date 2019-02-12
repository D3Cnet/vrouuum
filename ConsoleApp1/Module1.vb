Module Module1
    Dim maKuga As New Voiture

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
