Imports System

Module Program
    Sub Main(args As String())
        Dim animal1 As New Animal()
        Dim animal2 As New Animal()

        animal1.age = 20
        animal2.age = 33

        Console.WriteLine($"{NameOf(animal1)}�̔N���{animal1.age}�΂ł�")
        Console.WriteLine($"{NameOf(animal2)}�̔N���{animal2.age}�΂ł�")

        Console.WriteLine($"{NameOf(animal1)}��5�N��̔N���{animal1.ageAgterFiveYear()}�΂ł�")

        animal1.NAME() = "�L����"
        Console.WriteLine($"{NameOf(animal1)}�̖��O��{animal1.NAME()}�ł�")

        Console.WriteLine($"{NameOf(animal2)}�̖��O��{animal2.NAME()}�ł�")

        Console.ReadLine()
    End Sub
End Module
