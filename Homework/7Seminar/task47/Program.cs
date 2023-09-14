/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.Clear();
Console.Write("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размах(мин и мах): ");
int maxdeviation = Convert.ToInt32(Console.ReadLine());
int mindeviation = - maxdeviation;
double[,] GetRandom2DArray(int m, int n, int maxdeviation, int mindeviation)
{
    double[,] result = new double[m, n];
     Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            
            double randomValue = Math.Round (random.NextDouble() * (maxdeviation - mindeviation) + mindeviation, 3); //Math.Round(..., 3) - округление (на 3)
            result[i, j] = randomValue;
        }
    }
    return result;
}



void Print2DArray(double[,] arrayToPrint)
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

double[,] randomArray = GetRandom2DArray(m, n, maxdeviation, mindeviation);
Print2DArray(randomArray);
 