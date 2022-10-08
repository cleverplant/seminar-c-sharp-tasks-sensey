/*
[Задача 51:]()
Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
(с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/
void PrintRandomArray()
{
    int[,] matrix = new int[3, 4];

    Console.WriteLine();
    Console.WriteLine($"{matrix.GetLength(0)} <- размер массива строк");
    Console.WriteLine($"{matrix.GetLength(1)} <- размер массива столбцов");
    Console.WriteLine();

    FillArray(matrix);
    //CheckArray(matrix);
    PrintArray(matrix);
CheckArray(matrix);
    // ---------------------------------------------------------------------------
    void FillArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i += 2)
        {
            for (int j = 0; j < matr.GetLength(1); j += 2)
            {
                matr[i, j] = new Random().Next(1, 10);// 
            }
            
        }
        Console.WriteLine();
    }

    void PrintArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)// rows - строки
        {
            for (int j = 0; j < matr.GetLength(1); j++)// columns -столбцы
            {
                Console.Write($"{matr[i, j] + " "}");// 
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine("--------------------");

    void CheckArray(int[,] matr)
    {
        int sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)// rows - строки
        {
            for (int j = 0; j < matr.GetLength(1); j++)// columns -столбцы
            {
                if (i == j)
                    {
                        sum = sum + matr[i, j];
                        Console.Write(sum);// почему то без не сработало ... ладно хрен с ним ...принцип понятен
                    }
            }
        }
    }
    Console.WriteLine("--------");
}
PrintRandomArray();






