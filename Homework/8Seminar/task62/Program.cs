/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

Console.Clear();
Console.Write("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());

int[,] FillArray(int a)
{
    int[,] array = new int[a, a];
    int value = 1;
    int minRow = 0, maxRow = a - 1, minCol = 0, maxCol = a - 1;

    while (value <= a * a)
    {
        // Заполняем верхнюю строку слева направо
        for (int i = minCol; i <= maxCol; i++)
        {
            array[minRow, i] = value++;
        }
        minRow++;

        // Заполняем правый столбец сверху вниз
        for (int i = minRow; i <= maxRow; i++)
        {
            array[i, maxCol] = value++;
        }
        maxCol--;

        // Заполняем нижнюю строку справа налево
        for (int i = maxCol; i >= minCol; i--)
        {
            array[maxRow, i] = value++;
        }
        maxRow--;

        // Заполняем левый столбец снизу вверх
        for (int i = maxRow; i >= minRow; i--)
        {
            array[i, minCol] = value++;
        }
        minCol++;
    }

    return array;
}

void Print2DArray(int[,] arrayToPrint)
{
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            System.Console.Write($" {arrayToPrint[i, j]}\t ");
        }
        System.Console.WriteLine();
    }
}

int[,] randomArray = FillArray(a);
Print2DArray(randomArray);
