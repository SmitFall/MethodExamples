Option Explicit On

Module MethodExamples

    Sub Main()
        Dim result As Integer

        'Call Sub
        AddTwoNumbers()
        Console.WriteLine("In main")
        Console.WriteLine(result)
        Sumof(4, 6)

        SayAMessage()

        Console.ReadLine()
    End Sub

    Sub AddTwoNumbers()
        Dim result As Integer
        result = 2 + 2
        Console.WriteLine("In sub")
        Console.WriteLine(result)
    End Sub

    Sub Sumof(firstnumber As Integer, secondnumber As Integer)

    End Sub

    Sub SayAMessage()
        Console.WriteLine("Say what again")

    End Sub

End Module
