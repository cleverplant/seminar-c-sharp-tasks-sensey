/*
Задача 59: Задайтедвумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент 1, на выходе получим
следующий массив:
9 2 3
42 4
267
*/


void z59()
{
Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] numbers = new int[rows, columns];
    Console.WriteLine($"Строк:{rows}, Столбцов:{columns}");


    FillArray(numbers);
    PrintArray(numbers);

void FillArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i += 2)
        {
            for (int j = 0; j < matr.GetLength(1); j += 2)
            {
                matr[i, j] = new Random().Next(1, 10);// 
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
                Console.Write($"{matr[i, j] + " "}");// 
            }
            Console.WriteLine();
        }
    }







}
z59();




