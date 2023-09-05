Console.WriteLine("Напишите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    Console.WriteLine(number % 10);
}
else
{
    Console.WriteLine("Число не трехзначное");
}
