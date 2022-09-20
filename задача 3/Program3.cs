/*    ВЕТВЛЕНИЕ


3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница

 */
/* ! НО ЭТО РЕШЕНИЕ ПЛОХОЕ - программа при выполнении первого условия 
- продолжит сравнение - т.е. ответ уже есть, а программа продолжает выпоняться 
чтобы этого избежать - правильно будет связать все в одну конструкцию 
- через else if - разницу в конструкциях видно на блок-схеме  
"НО ЭТО РЕШЕНИЕ ПЛОХОЕ - НИЖЕ ПРИМЕР С ПРАВИЛЬНЫМ РЕШЕНИЕМ"
*/
Console.WriteLine("========================================================");

Console.Write("Введите номер дня: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1)
{Console.WriteLine("понедельник");}
if (day == 2)
{Console.WriteLine("вторник");}
if (day == 3)
{Console.WriteLine("среда");}
if (day == 4)
{Console.WriteLine("четверг");}
if (day == 5)
{Console.WriteLine("пятница");}
if (day == 7)
{Console.WriteLine("суббота");}
if (day == 8)
{Console.WriteLine("воскресенье");}

//"ЭТО РЕШЕНИЕ ХОРОШЕЕ"
Console.WriteLine("========================================================");

Console.Write("Введите номер дня недели: ");
int days = Convert.ToInt32(Console.ReadLine());

if (days == 1)
{Console.Write("понедельник");}
else if (days == 2)
{Console.Write("вторник");}
else if (days == 3)
{Console.Write("среда");}
else if (days == 4)
{Console.Write("четверг");}
else if (days == 5)
{Console.Write("пятница");}
else if (days == 7)
{Console.Write("суббота");}
else if (days == 8)
{Console.Write("воскресенье");}
else 
{Console.WriteLine("неверный ввод");} // это дефолтный элемент 
// - если вся конструкция не сработала тогда - исключение
//-  такой элемент только в этой конструкции
Console.WriteLine("========================================================");

/* дополнительно от учителя */

/* ВЕТВЛЕНИЕ */

int rain = 1; // дождь идет - 1 <===> дождь не идет - 0
if (rain == 0)
{
    Console.WriteLine("Бери билет в Дубаи ");
}
else 
{
    Console.WriteLine("Бери пиво и иди на пляж ");
}
Console.WriteLine("==============================");

int time = 11; // сейчас 11 часов

while (time < 22)  // 22 - поздно <= это условие выхода из цикла
{
     time++ ; // или так time = time + 1
     Console.WriteLine(" гуляй Вася время " + time);
} 
Console.WriteLine(" Васяяяя...дАмой.... ");
Console.WriteLine(" Bремя " + time + " часa");
