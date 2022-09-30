/*Задача 28: Напишите программу, которая принимает на вход число N 
и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120 */
void zadacha28()
{
    Console.WriteLine(" \n \t zadacha");
    int num = 7;
    int factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        factorial = factorial * i;
    }
    Console.WriteLine($"{num} => {factorial}");
}
zadacha28();
