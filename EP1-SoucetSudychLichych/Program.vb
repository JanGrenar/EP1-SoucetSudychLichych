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
            Console.WriteLine("Zadejte celkov� po�et ��sel, kter� bude aplikace cht�t od u�ivatele zadat:")
            pocetCisel = Integer.Parse(Console.ReadLine())

            Console.WriteLine($"Zadejte {pocetCisel} libovoln�ch ��sel a poka�d� odra�kujte enterem")
            Console.WriteLine("Program vyp�e kolik jich je sud�ch a kolik lich�ch")

            For i As Integer = 1 To pocetCisel

                While Not Integer.TryParse(Console.ReadLine(), cislo) OrElse cislo < 0
                    Console.WriteLine("Neplatn� vstup. Zadejte pros�m cel� kladn� ��slo:")
                End While

                If cislo Mod 2 = 0 Then
                    suda += 1
                    soucetsuda += cislo
                Else
                    licha += 1
                    soucetlicha += cislo
                End If
            Next

            Console.WriteLine($"Sou�et sud�ch je {soucetsuda}, sou�et lich�ch je {soucetlicha}")
            Console.WriteLine($"Po�et sud�ch je {suda}, po�et lich�ch je {licha}")
            Console.WriteLine()
        Loop

    End Sub
End Module
