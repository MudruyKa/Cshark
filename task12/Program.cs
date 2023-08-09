/* Напишите программу, которая будет принимать на вход два числа и выводить, являеться ли второе число кратным первому. Если второе число некратно первому, то программа выводит остаток от деления.
34, 5 -> некратно, остаток 4
16, 4 -> кратно
*/

Console.WriteLine("Напишите число два числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int remains = 0;
if (number2 % number1 == 0)
{
    Console.WriteLine("кратно");
}
else
{
    remains = number2 % number1;
    Console.WriteLine($"Втрое число не кратно второму, остаток: {remains}");
}