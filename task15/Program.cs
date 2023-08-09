/*
 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
/*
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
    Console.Write("Понедельник");
}
else if (number == 2)
{
   Console.Write("Вторник"); 
}
else if (number == 3)
{
   Console.Write("Среда"); 
}
else if (number == 4)
{
   Console.Write("Четверг"); 
}
else if (number == 5)
{
   Console.Write("Пятница"); 
}
else if (number == 6)
{
   Console.Write("Суббота- выходной"); 
}
else if (number == 7)
{
   Console.Write("Воскресение- выходной"); 
}
else 
{
    Console.Write("Такого дня недели несуществует");
}
*/
Console.WriteLine("Напишите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 0 && number <= 6)
{
    Console.Write("Это будний день");
}
else if (number == 6)
{
    Console.Write("Суббота- выходной");
}
else if (number == 7)
{
    Console.Write("Воскресение- выходной");
}
else
{
    Console.Write("Такого дня недели несуществует");
}