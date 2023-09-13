/*
Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.|
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

void SumGeneralElements(int[,] arraySumElments)
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Сумма элементов, находящихся на главной диагонали: ");
    int sumGeneralElements = 0;
    int rows = arraySumElments.GetLength(0);
    int cols = arraySumElments.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (i == j)
            {
                 sumGeneralElements = sumGeneralElements + arraySumElments[i, j];
                if(arraySumElments[i, j] < 0) Console.Write($"({arraySumElments[i, j]}) +");
                else Console.Write($"{arraySumElments[i, j]} +");
            }
        }
    }
     Console.Write($" = {sumGeneralElements}.");

    Console.ForegroundColor = ConsoleColor.White;
}

int[,] randomArray = GetRandom2DArray(m, n, deviation);
Print2DArray(randomArray);
SumGeneralElements(randomArray);
