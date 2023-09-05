/*
Напишите программу, которая принимает на вход два числа и проверяет, явлеться ли одно квадрат другого.

12; 13
5, 25-> да
-4, 16 -> да
25, 5-> да
8, 9-> нет

*/

Console.WriteLine("Напишите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2 || number2 == number1 * number1)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
    /* Мой код:
    if (number2 == number1 * number1)
     {
         Console.WriteLine("Да");
     }
     else
     {
         Console.WriteLine("Нет");
     }
     */
}