/*
[Задача 46:]()

Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1

*/

void PrintRandomArray()
{
    int[,] matrix = new int[3, 4];

    Console.WriteLine();
    Console.WriteLine($"{matrix.GetLength(0)} <- размер массива строк");
    Console.WriteLine($"{matrix.GetLength(1)} <- размер массива столбцов");
    Console.WriteLine();

    PrintArray(matrix);
    FillArray(matrix);
    PrintArray(matrix);

    // ---------------------------------------------------------------------------
    void FillArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i+=2)
        {
            for (int j = 0; j < matr.GetLength(1); j+=2)
            {
                matr[i, j] = new Random().Next(10, 50);// [1; 10)
            }
            //Console.WriteLine();
        }
        Console.WriteLine();
    }

    void PrintArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)// rows - строки
        {
            for (int j = 0; j < matr.GetLength(1); j++)// columns -столбцы
            {
                Console.Write($"{matr[i, j]} ");// 
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}
PrintRandomArray();











