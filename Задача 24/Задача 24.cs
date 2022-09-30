/* Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36 */
Console.WriteLine();

void zadacha24()
{
    int number = 5;
    int sum = 0;
    for (int i = 0; i <= number; i++)
    {
        //Console.Write($"{i} + ");
        sum = sum + i; // sum += i;
    }
    Console.WriteLine($"{sum} ");
}
//zadacha24();
/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */
void zadacha26()
{
    int number = 456;
    int i = 0;
    while (i < number)
    {
        number /= 10;
        i++;
    }
    Console.Write($"{i} !");
}
//zadacha26();
void zadacha26_v()
{
    int number = 456;
    int sum = 0;
    for (int i = 0; i < number; i++)
    {
        number /= 10;
        sum = i;
        Console.WriteLine($"{i} + ");
        Console.WriteLine($"{sum} + ");
    }
    //Console.WriteLine($"{i} + "); // за пределами  i не определена - ошибка
    Console.Write($"{sum} !");
}
// zadacha26_v(); // дает на 1 меньше
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
//zadacha28();
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
//-----------------------------------------------------------------------------------



void proba()
{
    //-----------------------------------------------------------------------------
    void test()
    {
        int x = 6;
        test2(x); // что бы воспользлваться надо делать ретурн
        Console.WriteLine("1- " + x);
        Console.WriteLine("x -> " + test2(x));
        Console.WriteLine("y -> " + test2());
    }
    // test();

    //void test2(int y = 16) // !!! ЗНАЧЕНИЯ ПРЕМЕННЫХ И ЗНАЧЕНИЕ МАССИВ - РАБОТАЮТ ПО РАЗНОМУ !!!
    int test2(int y = 16) // !!! МАССИВ - ЭТО ССЫЛОЧНЫЙ ТИП - ОН НЕ ПЕРЕДАЕТ ЗНАЧЕНИЕ, А ТОЛЬКО ССЫЛАЕТСЯ НА ОБЪЕКТ
    {
        //  // что бы воспользлваться надо делать ретурн
        return y;         //Console.WriteLine("2- " + y);
    }
}
//proba();
//-----------------------------------------------------------------------------------
void RUN()
{
    Random vasya = new Random(); /* массив создан */
    int sise = vasya.Next(1, 9);
    int[] numbers = new int[sise];/* массив создан */
    Console.WriteLine($"{sise} <- такой размер массива сейчас");

    for (int i = 0; i < sise; i++)
    {                                   /* ЭТО МАССИВ НА ЗАПОЛНЕНИЕ */
        numbers[i] = vasya.Next(0, 2);  /* это мы научились заполнять наш массив */
    }
    //--------------------------------------------------------------------------------


    for (int i = 0; i < sise; i++)     /* это мы научились печатать наш массив */
    {                                  /* ЭТО МАССИВ НА ВЫВОД */
        Console.Write(numbers[i] + ", "); /* это мы научились печатать наш массив */
    }
    Console.WriteLine();
}
// RUN();




