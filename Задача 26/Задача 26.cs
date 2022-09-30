/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */
void zadacha26()
{
    int number = 456;
    int i = 0;
    while (i < number)
    {
        number /= 10;
        i++;
    }
    Console.Write($"{i} !");
}
//zadacha26();
void zadacha26_v()
{
    int number = 456;
    int sum = 0;
    for (int i = 0; i < number; i++)
    {
        number /= 10;
        sum = i;
        Console.WriteLine($"{i} + ");
        Console.WriteLine($"{sum} + ");
    }
    //Console.WriteLine($"{i} + "); // за пределами  i не определена - ошибка
    Console.Write($"{sum} !");
}
// zadacha26_v(); // дает на 1 меньше
/*Задача 28: Напишите программу, которая принимает на вход число N 
и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120 */
