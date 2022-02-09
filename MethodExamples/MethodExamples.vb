Option Explicit On
Option Strict On
Option Compare Text
Module MethodExamples

    Sub Main()
        Dim someNumber As Integer

        someNumber = 5
        Console.WriteLine($"in main before call :{someNumber}")
        ChangeANumber(someNumber)
        Console.WriteLine($"in main after call :{someNumber}")
        Console.ReadLine()
    End Sub

    Sub ChangeANumber(ByRef firstNumber As Integer)
        firstNumber = 7
        Console.WriteLine($"in ChangeANumber after call :{firstNumber}")
    End Sub

    Sub Runningtotal()
        Dim userInput As String
        Dim userNumber As Integer
        Do

            Console.WriteLine("Type a number")
            userInput = Console.ReadLine
            Try
                userNumber = CInt(userInput)

            Catch ex As Exception
                Select Case userInput
                    Case "Q"
                    Case "C"
                        Runningtotal(0, True)
                    Case "s"
                        Runningtotal(0, False)
                        Console.WriteLine($"The curent total is {Runningtotal(0, False)}")

                    Case Else
                        Console.WriteLine("Oops")

                End Select
                userNumber = 0
            End Try

            Runningtotal(userNumber, False)

        Loop While userInput <> "Q"
        Console.WriteLine($"The total is :{Runningtotal(0, False)} ")


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
    Function Runningtotal(value As Integer, clear As Boolean) As Integer
        Static total As Integer
        If clear = False Then
            total += value
        Else
            total = 0
        End If
        Return total


    End Function


    Function count(Optional clear As Boolean = False) As Integer
        Static runningcount As Integer

        If clear Then
            runningcount = 0
        Else
            runningcount += 1
        End If

        Return runningcount
    End Function
End Module
