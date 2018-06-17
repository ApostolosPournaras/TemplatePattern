Module Module1

    Sub Main()

        Dim margaritta As New MargaritaPizza()
        margaritta.preparePizza()

        Console.WriteLine("------------")

        Dim fourcheese As New FourCheezePizza()
        fourcheese.preparePizza()

        Console.WriteLine("------------")

        Dim vezuvius As New VezuviusPizza()
        vezuvius.preparePizza()

        Console.WriteLine("------------")

        Do Until (Console.ReadKey.Key = ConsoleKey.Escape)
            System.Threading.Thread.Sleep(1000)
        Loop

    End Sub

End Module
