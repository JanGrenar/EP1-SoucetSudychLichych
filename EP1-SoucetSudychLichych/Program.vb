Imports System

Module Program
  Sub Main(args As String())


        Dim suda As Integer
        Dim licha As Integer
        Dim cislo As Integer
        Dim pocetCisel As Integer
        Dim soucetsuda As Integer
        Dim soucetlicha As Integer

        Do
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
                    soucetsuda += cislo
                Else
                    licha += 1
                    soucetlicha += cislo
                End If
            Next

            Console.WriteLine($"Souèet sudých je {soucetsuda}, souèet lichých je {soucetlicha}")
            Console.WriteLine($"Poèet sudých je {suda}, poèet lichých je {licha}")
            Console.WriteLine()
        Loop

    End Sub
End Module
