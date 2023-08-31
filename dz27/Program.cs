﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



int SumDigit(int number)
{
    int sum = 0;
    while (number >0)
    {
        sum += number % 10;
        number /= 10;
    }

    return sum;
}

Console.WriteLine("Введите число");
int input = Convert.ToInt32(Console.ReadLine());

int sumdigit= SumDigit(input);

Console.WriteLine($"Сумма цифр числа {input} = {sumdigit}");