﻿/*
1. Напишите программу, которая на вход принимает два числа и проверяет, 
является ли первое число квадратом второго.
a = 5; b = 25 -> да
a = 2 b = 10 -> нет
a = 9; b = -3 -> нет
a = -3 b = 9 -> да
*/
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b == a * a)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}

