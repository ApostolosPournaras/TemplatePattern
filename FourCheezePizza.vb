Public Class FourCheezePizza
    Inherits Pizza

    Dim cheese() As String = {"Mozzarella", "Feta", "Parmezana", "Pecorino"}
    Dim sauce() As String = {"tomato sauce"}
    Dim spices() As String = {"rigani", "thimari"}
    Dim vegitables() As String = {"shweet pepers", "onions", "mashrooms"}

    Sub New()
        Me.name = "Four cheese"
    End Sub

    Protected Overrides Sub addCheese()
        Console.Write("Adding cheeze: ")
        For Each ch In cheese
            Console.Write(ch & " ")
        Next
        Console.WriteLine()
    End Sub

    Protected Overrides Sub addMeatProducts()
    End Sub

    Protected Overrides Sub addSauce()
        Console.Write("Adding sauce: ")
        For Each sc In sauce
            Console.Write(sc & " ")
        Next
        Console.WriteLine()
    End Sub

    Protected Overrides Sub addSpices()
        Console.Write("Adding spices: ")
        For Each sp In spices
            Console.Write(sp & " ")
        Next
        Console.WriteLine()
    End Sub

    Protected Overrides Sub addVegitables()
        Console.Write("Adding vegitables: ")
        For Each vg In vegitables
            Console.Write(vg & " ")
        Next
        Console.WriteLine()
    End Sub

    Protected Overrides Function wantMeatProducts() As Boolean
        Return False
    End Function
End Class
