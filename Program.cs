/*  10. Принимает трехзначное число и показывает вторую цифру числа
    15. Принимает цифру, обозначающ. деньнедели, проверяет являетя ли
    это выходной или нет */

/* Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    number = number / 10;
    Console.WriteLine(number % 10);
}
else
{
    Console.WriteLine("Число не трехзначное");
} */


/* 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет является ли этот день выходным*/

/* Console.WriteLine("Введите число");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber == 6 || dayNumber == 7)
{
    Console.WriteLine("Выходной");
}
else if (dayNumber >= 1 && dayNumber <= 5)
{
    Console.WriteLine("Рабочий");
}
else if (dayNumber <= 0 || dayNumber >= 8)
{
    Console.WriteLine("Введите заново");
} */

/* 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет */

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
   Console.WriteLine("Третьей цифры нет");
}
else if (number > 99 && number < 1000)
{
    Console.WriteLine(number = number % 10);
}
else
{
    while (number > 999)
    {
        number = number / 10;
    }
    Console.WriteLine(number = number % 10);
    
}
