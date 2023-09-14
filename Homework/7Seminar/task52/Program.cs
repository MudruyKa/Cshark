/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = random.Next(-deviation, deviation);
        }
    }
    return result;
}

void Print2DArray(int[,] arrayToPrint)
{
    Console.Write("[ ]\t");
    for (int c = 0; c < arrayToPrint.GetLength(1); c++)
    {
        Console.Write($"[{c}]\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

double[] CalculateColumnAverages(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    double[] columnAverages = new double[columns];

    for (int j = 0; j < columns; j++)
    {
        int sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += array[i, j];
        }
        columnAverages[j] = (double)sum / rows;
        columnAverages[j] = Math.Round(columnAverages[j], 2);//округлил до двух знаков
    }

    return columnAverages;
}

void PrintColumnAverages(double[] columnAverages)
{

    //Console.WriteLine("Среднее арифметическое каждого столбца:");
    Console.Write($"[{columnAverages.GetLength(0)}]");
    for (int j = 0; j < columnAverages.GetLength(0); j++)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"    {columnAverages[j]}");

    }

}

int[,] randomArray = GetRandom2DArray(m, n, deviation);
Print2DArray(randomArray);
double[] columnAverages = CalculateColumnAverages(randomArray);
PrintColumnAverages(columnAverages);
Console.ForegroundColor = ConsoleColor.White;



/*
void PrintColumnAverages(double[] columnAverages)
{
    {
        Console.WriteLine("Среднее арифметическое каждого столбца:");
        for (int j = 0; j < columnAverages.Length; j++)
        {
            Console.WriteLine($"Столбец {j}: {columnAverages[j]}");
        }
    }
}
*/