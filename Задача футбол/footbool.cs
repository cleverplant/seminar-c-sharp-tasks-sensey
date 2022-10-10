/*
// rows - строки
// columns -столбцы

ЧТО-ТО НЕ ТАК - НЕ РАСПЕЧАТЫВАЕТ ДВЕ СТРОКИ - НО ЗАВИС - ВРЕМЯ ИДЕТ - ДЗ НЕТ - ПОТОМ ДОПИЛЮ

*/

void PrintRandomArray()
{

    int rows = 2;
    int columns = 5;

    int[,] numbers = new int[rows, columns];

    Console.WriteLine();
    Console.WriteLine($"{numbers.GetLength(0)} <- размер массива строк");
    Console.WriteLine($"{numbers.GetLength(1)} <- размер массива столбцов");
    Console.WriteLine();

    PrintArray(numbers);
    FillArrayCustom(numbers, 0, 10);
    PrintArray(numbers);
    PtintArrayCustom(numbers);
    PrintArray(numbers);
    // ---------------------------------------------------------------------------

    void PtintArrayCustom(int[,] numbers)
    {
        int lose = 0;
        int win = 0;
        int draw = 0;

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                if (numbers[0, i] > numbers[1, i])

                {
                    win++;
                    Console.Write($" win {numbers[0, i]} : {numbers[1, i]}");
                }
                if (numbers[0, i] < numbers[1, i])
                {
                    lose++;
                    Console.Write($" lose {numbers[0, i]} : {numbers[1, i]}");
                }

                if (numbers[0, i] == numbers[1, i])
                {
                    draw++;
                    Console.Write($" draw {numbers[0, i]} : {numbers[1, i]}");
                }
                Console.WriteLine($" количество побед : {win} : ");
                Console.WriteLine($" количество поражений : {lose} : ");
                Console.WriteLine($" количество ничья : {draw} : ");
            }
        }
        Console.WriteLine();
    }

    void FillArrayCustom(int[,] numbers, int minBalls = 0, int maxBalls = 0)
    {
        maxBalls++;
        Random random = new Random();
        int rows = numbers.GetLength(0);
        int columns = numbers.GetLength(1);

        for (int i = 0; i < rows; i++)// rows - строки
        {
            for (int j = 0; j < columns; j++)// columns -столбцы
            {
                numbers[i, j] = random.Next(minBalls, maxBalls);
            }
            Console.WriteLine();
        }
    }


    void PrintArray(int[,] numbers)
    {
        for (int i = 0; i < numbers.GetLength(0); i++)// rows - строки
        {
            for (int j = 0; j < numbers.GetLength(1); j++)// columns -столбцы
            {
                Console.Write($"{numbers[i, j] + " "}");// 
            }

        }
        Console.WriteLine();
    }


}
PrintRandomArray();

