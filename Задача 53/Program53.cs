/*
Задача 53: 
Задайте двумерный массив.
Напишите программу, которая поменяет местами первую и последнюю строку массива.
*/

void Zadacha53()
{
    Random random = new Random();
    int rows = random.Next(2, 10);
    int columns = random.Next(2, 10);
    int[,] numbers = new int[rows, columns];

    FillArray(numbers);
    PrintArray(numbers);
    Changer(numbers, rows);
    Console.WriteLine("Перевернули строки массива...");
    PrintArray(numbers);
}

void FillArray(int[,] numbers)
{
    Random random = new Random();
    for(int i = 0; i < numbers.GetLength(0); i++)
    {
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
        numbers[i,j] = random.Next(-9, 10);
        }
    }
}   
void PrintArray(int[,] numbers)
{
    Random random = new Random();
    for(int i = 0; i < numbers.GetLength(0); i++)
    {
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
        Console.Write(numbers[i,j]+ "\t");
        }
    Console.WriteLine();
    }
}   

void Changer(int[,] numbers, int rows)
{
    int maxIndex = rows - 1;
    int maxColumns = numbers.GetLength(1);
    for(int j = 0; j < maxColumns; j++)
    {
        (numbers[0,j], numbers[maxIndex, j]) = (numbers[maxIndex, j], numbers[0, j]);
        
    }
}

Zadacha53();







