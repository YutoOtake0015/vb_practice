Imports System

Module Program
    Sub Main(args As String())
        Dim animal1 As New Animal()
        Dim animal2 As New Animal()

        animal1.age = 20
        animal2.age = 33

        Console.WriteLine($"{NameOf(animal1)}‚Ì”N—î‚Í{animal1.age}‚Å‚·")
        Console.WriteLine($"{NameOf(animal2)}‚Ì”N—î‚Í{animal2.age}‚Å‚·")


        Console.ReadLine()
    End Sub
End Module
