Imports System

Module Program
  Sub Main(args As String())


        Dim suda As Integer
        Dim licha As Integer
        Dim cislo As Integer
        Dim pocetCisel As Integer

        Console.WriteLine("Zadejte celkový poèet èísel, který bude aplikace chtít od uživatele zadat:")
        pocetCisel = Integer.Parse(Console.ReadLine())

        Console.WriteLine($"Zadejte {pocetCisel} libovolných èísel a pokaždé odraïkujte enterem")
        Console.WriteLine("Program vypíše kolik jich je sudých a kolik lichých")

        For i As Integer = 1 To pocetCisel

            While Not Integer.TryParse(Console.ReadLine(), cislo) OrElse cislo < 0
                Console.WriteLine("Neplatný vstup. Zadejte prosím celé kladné èíslo:")
            End While

            If cislo Mod 2 = 0 Then
                suda += 1
            Else
                licha += 1
            End If
        Next

        Console.WriteLine($"Sudých je {suda} , lichých je {licha}")
        Console.ReadLine()

    End Sub
End Module
