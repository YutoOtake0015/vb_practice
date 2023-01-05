Imports System

Module Program
    Sub Main(args As String())
        Dim animal1 As New Animal()
        Dim animal2 As New Animal()

        animal1.age = 20
        animal2.age = 33

        Console.WriteLine($"{NameOf(animal1)}の年齢は{animal1.age}歳です")
        Console.WriteLine($"{NameOf(animal2)}の年齢は{animal2.age}歳です")

        Console.WriteLine($"{NameOf(animal1)}の5年後の年齢は{animal1.ageAgterFiveYear()}歳です")

        Console.ReadLine()
    End Sub
End Module
