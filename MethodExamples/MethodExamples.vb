Option Explicit On
Option Strict On
Module MethodExamples

    Sub Main()
        Dim value As Integer

        'Call Sub
        'AddTwoNumbers()
        'Console.WriteLine("In main")
        'Console.WriteLine(result)
        'Sumof(4, 6)
        'value = SumResult(7, 7)
        'value = value + 6
        'Console.WriteLine(value)

        'SayAMessage()
        ' For i = 0 To 10

        ' RandomInteger()
        'Next
        ' For i = 0 To 10
        'Console.WriteLine(RandomNumber())
        'Next

        For i = 0 To 10
            Console.WriteLine(Runningtotal(5))
        Next

        Console.ReadLine()
    End Sub

    Sub AddTwoNumbers()
        Dim result As Integer
        result = 2 + 2
        Console.WriteLine("In sub")
        Console.WriteLine(result)
    End Sub

    Sub Sumof(ByVal firstnumber As Integer, ByVal secondnumber As Integer)
        Console.WriteLine(firstnumber + secondnumber)
    End Sub

    Function SumResult(firstnumber As Integer, secondnumber As Integer) As Integer
        Dim result As Integer
        result = firstnumber + secondnumber
        Return result
    End Function

    Sub SayAMessage()
        Console.WriteLine("Say what again")

    End Sub

    Sub RandomInteger()
        Dim theRandomNumber As Integer

        Randomize()

        theRandomNumber = CInt(Rnd() * 10)

        Console.WriteLine(theRandomNumber)


    End Sub

    Function RandomNumber() As Integer
        Randomize()
        Return CInt(Rnd() * 15)

    End Function
    Function Runningtotal(value As Integer) As Integer
        Static total As Integer
        total += value
        Return Total


    End Function
End Module
