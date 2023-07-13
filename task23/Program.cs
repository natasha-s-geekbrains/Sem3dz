﻿// Задача 23: Напишите программу, которая принимает на 
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27. 
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int N = Prompt("Введите число: ");
int sum = 1;

while (sum <= N)
{
    if (sum == N)
    {
        Console.Write($"{Math.Pow(sum, 3)}");
    }
    else
    {
        Console.Write($"{Math.Pow(sum, 3) + ", "}");
    }
    sum++;
}
