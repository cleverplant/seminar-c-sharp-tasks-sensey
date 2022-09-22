/*
задача 9. 
Напишите программу, 
которая выводит случайное число из отрезка [10, 99] 
и показывает наибольшую цифру числа.
*/
zadacha9();
void zadacha9()
{
    Random random = new Random();   // по условию нам нужен интервал от 10 до 99
    int number = random.Next(10, 100);// но задать нужно так, 100 не включительно, 
    Console.WriteLine(number);
    int tens = number / 10;
    int ones = number % 10;
    //Console.WriteLine(tens);
    //Console.WriteLine(ones);

    if (tens > ones)
    {
        Console.WriteLine("значения не равны !");
        Console.WriteLine(tens + " больше " + ones);
    }
    else if (ones > tens)
    {
        Console.WriteLine("значения не равны !");
        Console.WriteLine(ones + " больше " + tens);
    }
    else
    {
        Console.WriteLine("значения равны !");
        Console.WriteLine(ones + " равно " + tens);
    }

}














