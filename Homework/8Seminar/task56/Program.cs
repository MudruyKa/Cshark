/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Clear();
Console.Write("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размах(мин и мах): ");
int deviation = Convert.ToInt32(Console.ReadLine());

int[,] GetRandom2DArray(int m, int n, int deviation)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(-deviation, deviation);
        }
    }
    return result;
}

void Print2DArray(int[,] arrayToPrint)
{
    System.Console.Write($"[ ]\t");
    for (int c = 0; c < arrayToPrint.GetLength(1); c++)
    {
        Console.Write($"[{c}]\t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            System.Console.Write(arrayToPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[] SumInRows(int[,] arrayForCountOfSum)
{
    int[] arraySum = new int[arrayForCountOfSum.GetLength(0)];
    for (int i = 0; i < arrayForCountOfSum.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForCountOfSum.GetLength(1); j++)
        {
            arraySum[i] += arrayForCountOfSum[i, j];
        }
    }
    return arraySum;
}

void MinValue(int[] array)
{
    int min = array[0];
    int numberMinRow =1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            numberMinRow = i+1;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {numberMinRow} строка - сумма: {min}.");
}

int[,] randomArray = GetRandom2DArray(m, n, deviation);
Print2DArray(randomArray);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
int[] sum = SumInRows(randomArray);
Console.WriteLine();
MinValue(sum);
Console.ForegroundColor = ConsoleColor.White;