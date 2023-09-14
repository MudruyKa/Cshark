/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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

void FindElement(int[,] arrayForFind)
{ 
    Console.Write("Введите число для поиска в массиве: ");

    int findElement = Convert.ToInt32(Console.ReadLine());
    int rows = arrayForFind.GetLength(0);
    int cols = arrayForFind.GetLength(1);
     int count=0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (arrayForFind[i, j] == findElement)
            {
              count ++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Число {findElement} в массиве с индексами [{i},{j}].");
            }
        
        }
    }
    if(count == 0)
    {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Число {findElement} нет в массиве.");
    }
    Console.ForegroundColor = ConsoleColor.White;
}

int[,] randomArray = GetRandom2DArray(m, n, deviation);
Print2DArray(randomArray);
FindElement(randomArray);
