Public Class MargaritaPizza
    Inherits Pizza

    Dim cheese() As String = {"Mozzarella"}
    Dim sauce() As String = {"tomato sauce"}

    Sub New()
        Me.name = "Margaritta"
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
    End Sub

    Protected Overrides Sub addVegitables()
    End Sub

    Protected Overrides Function wantMeatProducts() As Boolean
        Return False
    End Function

    Protected Overrides Function wantspices() As Boolean
        Return False
    End Function

    protected Overrides Function wantVagitables() As Boolean
        Return False
    End Function

End Class
