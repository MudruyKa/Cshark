/*
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

14 -> нет
46 -> нет
161 -> да

*/

Console.WriteLine("Напишите число число");
int number = Convert.ToInt32(Console.ReadLine());
int n7 = 7;
int n23 = 23;
if (number % (n7 * n23) == 0)
{
    Console.WriteLine($"Число {number} - кратно {n7} и {n23}");
}
else 
{
     Console.WriteLine($"Число {number} - некратно {n7} и {n23}");
}