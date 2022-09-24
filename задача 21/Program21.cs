/*
задача 21: 

Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

zadacha21();
void zadacha21()
{
    Console.WriteLine("введите координаты точки А");

    Console.WriteLine("Х: ");
    int ax = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("У: ");
    int ay = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("введите координаты точки В");

    Console.WriteLine("Х: ");
    int bx = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("У: ");
    int by = Convert.ToInt32(Console.ReadLine());

    int k = bx - ax;
    int m = by - ay;
    double length = Math.Sqrt(k * k + m * m);
    Console.WriteLine(" -> " + length);
    length = Math.Round(length, 2);
    Console.WriteLine("длина -> " + length);







}

