/*
Напишите программу, которая принимает на вход число(А) и выдает сумму  чисел от 1 до А.
*/


Console.WriteLine($"(SumOfNumber(userNumber");
System.Console.WriteLine("Введи число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int SumOfNumber(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}
    Console.WriteLine($"сумма Цифр в числе {userNumber} равна {SumOfNumber(userNumber)}");