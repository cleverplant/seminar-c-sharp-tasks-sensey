/*
Задача 55: Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя. данных.
*/

void Zadacha53()
{
    var random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);

    int min_i = 0;
    int max_i = rows - 1;
    for (int j = 0; j < columns; j++)
    {
        (numbers[min_i, j], numbers[max_i, j]) =
                                (numbers[max_i, j], numbers[min_i, j]);
    }
    Console.WriteLine();
    PrintArray(numbers);

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

}
Zadacha53();
