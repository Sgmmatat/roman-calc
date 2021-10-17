
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
        answer_roman = "Roman:"

        Console.WriteLine("Please enter a number: ")
        num_1 = Console.ReadLine()
        Do While num_1 > 0
            If num_1 >= 1000 Then
                num_1 = (num_1 - 1000)
                answer_roman = answer_roman & "M"


            ElseIf num_1 >= 500 Then
                num_1 = (num_1 - 500)
                answer_roman = answer_roman & "D"

            ElseIf num_1 >= 100 Then
                num_1 = (num_1 - 100)
                answer_roman = answer_roman & "C"

            ElseIf num_1 >= 50 Then
                num_1 = (num_1 - 50)
                answer_roman = answer_roman & "L"

            ElseIf num_1 >= 10 Then
                num_1 = (num_1 - 10)
                answer_roman = answer_roman & "X"

            ElseIf num_1 >= 5 Then
                num_1 = (num_1 - 5)
                answer_roman = answer_roman & "V"

            ElseIf num_1 >= 1 Then
                num_1 = (num_1 - 1)
                answer_roman = answer_roman & "I"
            End If

            Console.WriteLine(answer_roman)

        Loop




    End Sub
End Module

