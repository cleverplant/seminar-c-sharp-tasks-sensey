/*
[Задача 48:]()

Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: A = m+n. 
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

void PrintRandomArray()

{
    Random random = new Random();
    int rows = random.Next(3, 5);
    int columns = random.Next(4, 8);

    int[,] matrix = new int[rows, columns];

    Console.WriteLine();
    Console.WriteLine($"{rows} <- размер массива строк");
    Console.WriteLine($"{columns} <- размер массива столбцов");
    Console.WriteLine();

    //PrintArray(matrix);
    FillArray(matrix);
    PrintArray(matrix);

    // ---------------------------------------------------------------------------
    void FillArray(int[,] matr)

    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matr[i, j] = i + j;//  
            }
        }
        Console.WriteLine();
    }

    void PrintArray(int[,] matr)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{matr[i, j]} \t");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}
PrintRandomArray();







