
/*Задайте двумерный массив размера т на п, каждый элемент в массиве находится по формуле:
Amn= т+. Выведите полученный массив на экран.*/
Console.Clear();
int[,] GetRandom2DArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
    {
        result[i, j] = i + j;
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


Console.Write("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] randomArray = GetRandom2DArray(m,n);
Print2DArray(randomArray);