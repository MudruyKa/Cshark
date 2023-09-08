/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.Write("Введите число: ");
int usernumber = Convert.ToInt32(Console.ReadLine());

int SumOfNumber(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int count= number % 10;
        number = number / 10;
        sum += count;
        //int num = i % 10;
        //i = i / 10;
        //sum = sum + num;
    }
    return sum;
}
Console.WriteLine(SumOfNumber(usernumber));