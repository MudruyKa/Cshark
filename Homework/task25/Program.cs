/*
Задача 25: Нпишите цикл, который принимает на вхоад два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.Write("Введите число: ");
int usernumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральную степень числа: ");
int usernumberB = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 0; i < usernumberB; i++)
    {
        result *= usernumberA;
    }
Console.WriteLine(result);
/*
int DegreeNumberA(int numberA, int numberB)
{
    int result = 1;
    for (int i = 0; i < numberB; i++)
    {
        result *= numberA;
    }
    return result;
}

Console.WriteLine(DegreeNumberA(usernumberA));
*/