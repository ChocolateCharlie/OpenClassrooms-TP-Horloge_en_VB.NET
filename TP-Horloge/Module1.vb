Module Module1

    Sub Main()

        ' ATTENTION Boucle infinie !
        While True
            ' Console.WriteLine("~.~.~ HORLOGE ~.~.~")
            Console.WriteLine("--- " & Date.Now.ToLongTimeString & " ---")
            System.Threading.Thread.Sleep(1000)
            Console.Clear()
        End While

    End Sub

End Module
