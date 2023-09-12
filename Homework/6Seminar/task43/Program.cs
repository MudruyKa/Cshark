/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

void FounfPointOfIntersection()
{
    Console.Write("Введите точку b1: ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите точку k1: ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Введите точку b2: ");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите точку k2: ");
    double k2 = Convert.ToInt32(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.White;
    double x = 0;
    double y = 0;
    /*
    Как я вывел формулу:
    y = k1 * x + b1;//y=5x+2
    y = k2 * x + b2;//y=9x+4
    k1 * x + b1 = k2 * x + b2;//5x+2=9x+4
    (k1-k2)*x = (-b1+b2);//-4x=2
    */
    x = (-(b1) + b2) / (k1 - (k2)); //x=(-2+4)/(5-9); x=2/-4
    y = k1 * x + b1;
    if (k1 * x + b1 == k2 * x + b2)
    {
        y = k1 * x + b1;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Точка пересечения двух прямых: ({x},{y}).");
    }
    else
    {
        Console.WriteLine("Ошибка проверки");
    }
}
FounfPointOfIntersection();