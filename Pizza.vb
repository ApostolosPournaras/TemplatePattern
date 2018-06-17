Public MustInherit Class Pizza

    Protected name As String = "Pizza"

    Public Sub preparePizza()

        Console.WriteLine("Preparing " & Me.name)

        addDough()

        If wantSauce() Then
            addSauce()
        End If

        If wantCheese() Then
            addCheese()
        End If

        If wantMeatProducts() Then
            addMeatProducts()
        End If

        If wantVagitables() Then
            addVegitables()
        End If

        If wantSpices() Then
            addSpices()
        End If

        bake()

    End Sub

    Protected Sub addDough()
        Console.WriteLine("Dough added")
    End Sub

    Protected Sub bake()
        Console.WriteLine("pizza is in the oven")
    End Sub

    Protected MustOverride Sub addSauce()
    Protected MustOverride Sub addMeatProducts()
    Protected MustOverride Sub addCheese()
    Protected MustOverride Sub addVegitables()
    Protected MustOverride Sub addSpices()

    Protected Overridable Function wantSauce() As Boolean
        Return True
    End Function

    Protected Overridable Function wantMeatProducts() As Boolean
        Return True
    End Function

    Protected Overridable Function wantCheese() As Boolean
        Return True
    End Function

    Protected Overridable Function wantVagitables() As Boolean
        Return True
    End Function

    Protected Overridable Function wantSpices() As Boolean
        Return True
    End Function

End Class
