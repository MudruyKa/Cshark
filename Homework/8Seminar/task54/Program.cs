/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

int[,] FilterFromMaxToMin(int[,] arrayForFilter)
{
    int rows = arrayForFilter.GetLength(0);
    int cols = arrayForFilter.GetLength(1);

    int[,] filteredArray = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        int[] tempArray = new int[cols];
        for (int j = 0; j < cols; j++)
        {
            tempArray[j] = arrayForFilter[i, j];
        }

        for (int j = 0; j < cols - 1; j++)
        {
            for (int k = j + 1; k < cols; k++)
            {
                if (tempArray[j] < tempArray[k])
                {
                    int temp = tempArray[j];
                    tempArray[j] = tempArray[k];
                    tempArray[k] = temp;
                }
            }
        }
        for (int j = 0; j < cols; j++)
        {
            filteredArray[i, j] = tempArray[j];
        }
    }

    return filteredArray;
}

int[,] randomArray = GetRandom2DArray(m, n, deviation);
Print2DArray(randomArray);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Print2DArray(FilterFromMaxToMin(randomArray));
Console.ForegroundColor = ConsoleColor.White;