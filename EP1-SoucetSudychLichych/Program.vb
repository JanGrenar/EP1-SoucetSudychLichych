Imports System

Module Program
  Sub Main(args As String())


        Dim suda As Integer
        Dim licha As Integer
        Dim cislo As Integer
        Dim pocetCisel As Integer

        Console.WriteLine("Zadejte celkov� po�et ��sel, kter� bude aplikace cht�t od u�ivatele zadat:")
        pocetCisel = Integer.Parse(Console.ReadLine())

        Console.WriteLine($"Zadejte {pocetCisel} libovoln�ch ��sel a poka�d� odra�kujte enterem")
        Console.WriteLine("Program vyp�e kolik jich je sud�ch a kolik lich�ch")

        For i As Integer = 1 To pocetCisel
            cislo = Integer.Parse(Console.ReadLine())

            If cislo Mod 2 = 0 Then
                suda += 1
            Else
                licha += 1
            End If
        Next

        Console.WriteLine($"Sud�ch je {suda} , lich�ch je {licha}")
        Console.ReadLine()

    End Sub
End Module
