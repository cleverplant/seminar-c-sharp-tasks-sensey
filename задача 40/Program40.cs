﻿/*
Задача 40: 
Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник со сторонами такой длины.
Теорема о неравенстве треугольника: 
каждая сторона треугольника меньше суммы двух других сторон.
*/


void zadacha40()
{

int a = 5;
int b = 4;
int c = 3;
if (a + b > c && a + c> b && b + c > a )

Console.Write(" треугольник  ");

else 

Console.Write(" НЕ треугольник " );

}

zadacha40();