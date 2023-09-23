/* 55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Например, задан массив:

1472
5923
8 424
5267
В итоге получается вот такой массив:

1 5 8 5
4942
7 2 26
2347
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
int[,] ChangeStringsAndColumns(int[,] matrix)
{
    int temp = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++)
        {
            temp = matrix[i,j];
            matrix[i, j] = matrix[j, i];
            matrix[j,i] = temp;
        }
        
    }
    return matrix;
}
int[,] randomArray = GetRandom2DArray(m, n, deviation);
Print2DArray(randomArray);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Print2DArray(ChangeStringsAndColumns(randomArray));
Console.ForegroundColor = ConsoleColor.White;