/*
Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, 
сколько раз встречается элемент входных данных.
*/
void z57()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] numbers = new int[rows, columns];
    Console.WriteLine($"Строк:{rows}, Столбцов:{columns}");


    FillArray(numbers);
    PrintArray(numbers);

    int[] counts = new int[10];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            counts[numbers[i, j]]++;
        }
    }

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Количество {i} в  массиве равно {counts[i]}");
    }



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

}

z57();