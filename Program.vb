Imports System

Module Program
    Sub Main()
        Dim I, V, X, L, C, D, M, num_1, num_2, answer_num As Integer
        Dim answer_roman, plus_or_minus As String

        I = 1
        V = 5
        X = 10
        L = 50
        C = 100
        D = 500
        M = 1000
        Console.WriteLine("Roman numeral calculator, please enter the two values you wish to add or subtract and the calculator will give you the answer as well as the answer in its numerical form .
RULES:
-NUMBERS ENTERED MUST NOT EXCEED 2499
-ONLY ENTER WHOLE NUMBERS
-ONLY ADDITION AND SUBTRACTION IS ALLOWED
-NO NEGATIVE NUMBERS OR ANSWERS EQUAL TO 0 ARE PERMITTED")
        Console.WriteLine("Please enter you first number: ")
        num_1 = Console.ReadLine()
        If num_1 > 2499 Or num_1 < 0 Then
            Console.WriteLine("The number you have selected is not permitted, please check the rules and make sure the number you have selected is allowed and try again: ")
            num_1 = Console.ReadLine()
        End If
        Console.WriteLine("+ or -: ")
        plus_or_minus = Console.ReadLine()
        Console.WriteLine("Please enter you second number: ")
        num_2 = Console.ReadLine()
        If num_2 > 2499 Or num_1 < 1 Then
            Console.WriteLine("The number you have selected is not permitted, please check the rules and make sure the number you have selected is allowed and try again: ")
            num_2 = Console.ReadLine()
        End If
        If plus_or_minus = "+" Then
            answer_num = (num_1 + num_2)
        Else
            answer_num = (num_1 - num_2)
        End If
        If answer_num < 1 Then
            Console.WriteLine("The answer is less than or equal to 0, please try different values ")
        Else
            Console.WriteLine(answer_num)
        End If




    End Sub
End Module
