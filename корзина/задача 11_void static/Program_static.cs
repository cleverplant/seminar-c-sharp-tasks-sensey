/*
задача 11. 
Напишите программу, которая выводит случайное трёхзначное число 
и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

//namespace zadacha9_new
//{
    class Program
    {

        static void Main(string[] args)
        {

            int number = new Random().Next(10, 1000);
            Console.WriteLine("--> " + number);
            int ten = number / 100;
            int thr = number % 10;
            string c = Convert.ToString(ten) + Convert.ToString(thr);
            Console.WriteLine("--> " + c);

        }
    }
//}
