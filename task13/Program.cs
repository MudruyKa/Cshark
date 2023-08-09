/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Random random = new Random();
int number = random.Next(0, 2000);
Console.WriteLine(number);

/*
*Я не понял нужен ли ввод данных в этом задание, поэтому сделал рандом до 2к*
Console.WriteLine("Напишите число");
int number = Convert.ToInt32(Console.ReadLine());
*/
if (number > 99 && number < 1000)
{

    Console.WriteLine(number % 100);
}
else
{
    Console.WriteLine("Число не трехзначное");
}