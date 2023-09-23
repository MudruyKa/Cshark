/* Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5923
8424
В итоге получается вот такой массив:
8 4 2 4
5923
1 4 72 
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

int[,] ResultArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int temp = 0;
    for (int i = 0; i < cols; i++)
    {
        temp = array[0, i];
        array[0, i] = array[rows - 1, i];
        array[rows - 1, i] = temp;
    }
    return array;
}
int[,] randomArray = GetRandom2DArray(m, n, deviation);
Print2DArray(randomArray);
Console.WriteLine("Новый двухмерный массив: ");
Console.ForegroundColor = ConsoleColor.Green;
Print2DArray(ResultArray(randomArray));
Console.ForegroundColor = ConsoleColor.White;