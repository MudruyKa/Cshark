/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int start = 0;
int start1 = 0;
int end = 0;
int end1 = 0;

if (number > 9999 && number < 100000)
{
    start = number / 10000;
    start1 = (number / 1000) % 10;
    end = (number / 10) % 10;
    end1 = number % 10;

    if ((start == end1 && start1 == end) || (start == end && start1 == end1))
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("Число не пятизначное");
}
