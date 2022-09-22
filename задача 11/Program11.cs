/*
задача 11. 
Напишите программу, которая выводит случайное трёхзначное число 
и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/
zadacha9();
void zadacha9()
{
    Random random = new Random();   // по условию нам нужен интервал от 10 до 99
    int number = random.Next(10, 1000);// но задать нужно так, 100 не включительно, 
    Console.WriteLine(number);
    int tens = number / 100;
    int ones = number % 100;
    int thre = ones % 10;
    Console.WriteLine(tens);
    //Console.WriteLine(ones);
    Console.WriteLine(thre);
    
    Console.WriteLine(tens * 10 + thre); // этот способ математический и он ПРАВИЛЬНЫЙ
    // Console.WriteLine("" + tens + thre);
    // Console.WriteLine($"{tens}{thre}");
    // Console.WriteLine("" + tens + thre);
    // Console.Write(tens); // |
    // Console.Write(thre); // | а эти две команды просто выведут две переменные в строку
}

