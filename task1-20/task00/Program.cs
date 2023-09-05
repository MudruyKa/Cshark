/*
Напишите программу, которая на вход принимает число и выдвет его квадрат
(умноженное на само себя)


4->16
-3->9
-7>49
*/

Console.WriteLine("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number * number;

Console.WriteLine(result);
