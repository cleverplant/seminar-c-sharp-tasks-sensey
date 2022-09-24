/*
задача 22: 

Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу квадратов чисел от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
8 мин
*/

Console.WriteLine("введите число N ");
int N = Convert.ToInt32(Console.ReadLine());
int p;
int i = 1;
while (i < N)
{
    p = i * i;
    Console.Write(" 1) -> " + p);
    Console.Write(" 2) -> " + Math.Pow(i, 2));
    i = i + 1;
}


