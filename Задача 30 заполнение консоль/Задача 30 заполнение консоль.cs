void zadacha30()
{
    // все задачи под №30 перенести в мой практикум - 
    // существующие библиотеки снести нехрен, в другую папку -
    // оставить только самые частые и интересные!

    Random vasya = new Random(); /* массив создан */
    int sise = vasya.Next(4, 9); // здесь можно\нужно жестко прописать размер массива
    int[] numbers = new int[sise];/* массив создан */
    Console.WriteLine($"{sise} <- это размер массива ");

    ConsoleArray(numbers);
    PrintArray(numbers); // метод PrintArray(); надо вызывать здесь -> где в контексте есть вызываемый массив - numbers !!!

    void ConsoleArray(int[] numbe)
    {
        for (int i = 0; i < numbe.Length; i++) //num.Length -длина массива = size 
        {
            Console.WriteLine($"введите {i + 1}-й элемент массива: ");
            numbe[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
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

