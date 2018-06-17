Public Class VezuviusPizza
    Inherits Pizza

    Dim cheese() As String = {"Mozzarella", "Parmezana"}
    Dim meatProducts() As String = {"sousage", "mortadella"}
    Dim sauce() As String = {"tomato sauce", "milk cream"}
    Dim spices() As String = {"rigani", "bukovo"}
    Dim vegitables() As String = {"shweet pepers", "onions", "mashrooms"}

    Sub New()
        Me.name = "Vezuvius"
    End Sub

    Protected Overrides Sub addCheese()
        Console.Write("Adding cheeze: ")
        For Each ch In cheese
            Console.Write(ch & " ")
        Next
        Console.WriteLine()
    End Sub

    Protected Overrides Sub addMeatProducts()
        Console.Write("Adding meat products: ")
        For Each mt In meatProducts
            Console.Write(mt & " ")
        Next
        Console.WriteLine()
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
        Return True
    End Function
End Class
