/*Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]  (с 1 ч 18 м очень подробно про массивы !) */
void zadacha30()
{
    Random vasya = new Random(); /* массив создан */
    int sise = vasya.Next(1, 9);
    int[] numbers = new int[sise];/* массив создан */
    Console.WriteLine($"{sise} <- такой размер массива сейчас");

    FillArray(numbers); // строка 99. метод FillArray(); надо вызывать здесь -> 
                        // где в контексте есть вызываемый массив - numbers !!!
    PrintArray(numbers);
    //-------------------------------------------------------------------------------------

    void FillArray(int[] num) /* ЭТО МАССИВ НА ЗАПОЛНЕНИЕ */
    {
        Random vasya = new Random();
        for (int i = 0; i < num.Length; i++) //num.Length -длина массива = size 
        {
            num[i] = vasya.Next(0, 2);
        }
    }

    void PrintArray(int[] numb)
    {
        for (int i = 0; i < numb.Length; i++)     /* это мы научились печатать наш массив */
        {                                  /* ЭТО МАССИВ НА ВЫВОД */
            Console.Write(numb[i] + ", "); /* это мы научились печатать наш массив */
        }
        Console.WriteLine();
    }

   
}

zadacha30();
