/*Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты*/

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

int[,] DoubleEven2DArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int[,] result = new int[rows, cols];
    for (int i = 0; i < rows; i ++)
    {
        for (int j = 0; j < cols; j ++)
        {
            if (i % 2 == 0 && j % 2 == 0) result[i, j] = array[i, j] * array[i, j];
            else result[i, j] = array[i, j];
        }
    }
return result;
}


int[,] randomArray = GetRandom2DArray(m, n, deviation);
Print2DArray(randomArray);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
int[,] doubleEven = DoubleEven2DArray(randomArray);
Print2DArray(doubleEven);
Console.ForegroundColor = ConsoleColor.White;