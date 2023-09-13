/*
46. Задайте двумерный массив размером тхп, заполненный случайными целыми числами.
*/
int[,] GetRandom2DArray(int rowNumber, int colNumber, int deviation)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
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

int[,] randomArray = GetRandom2DArray(5, 5, 10);
Print2DArray(randomArray);