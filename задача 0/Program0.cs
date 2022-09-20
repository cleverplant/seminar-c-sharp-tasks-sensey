// Сonsole.WriteLine(); - выводим данные в консоль
// Console.WriteLine(); - выводит текст в наш терминал и переводит курсор на новую строку
// Console.ReadLine(); - считывание данных из консоли
// Convert.ToInt32(); - конвертация типов 

Console.WriteLine("Holla! task0 demo");
Console.WriteLine("-----------------");

/*Напишите программу, которая на вход принимает число и выдаёт его квадрат 
(число умноженное на само себя). */

Console.Write("Введите число и сделаем квадрат: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a * a;
Console.WriteLine("Квадрат = " + b + " <= конкатенация"); // <= конкатенация 
Console.WriteLine($"{"Квадрат = "}{b}{" <= интерполяция"}"); // <= интерполяция




