/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.Clear();
Console.WriteLine("Первый массив");
Console.Write("Введите размер массива: ");
int m = Convert.ToInt32(Console.ReadLine());



int[,] GetRandom2DArray(int m)
{
    int[,] result = new int[m,m];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result[i, j] = new Random().Next(0,50);// сделал ограничание до 50
        }
    }
    return result;
}
int[,] GetRandom2DArraySecond(int[,] arrayForRandom)
{

    int[,] result =  new int[arrayForRandom.GetLength(0), arrayForRandom.GetLength(1)];
    for (int i = 0; i < arrayForRandom.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForRandom.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(0,50);
        }
    }
    return result;
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

int[,] SumArray(int[,] firstArray, int[,] secondArray)
{
    int[,] sumArray = new int[firstArray.GetLength(0), firstArray.GetLength(1)];
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < firstArray.GetLength(1); j++)
        {
            sumArray[i, j] = 0; // Инициализируем элемент результата нулем
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                // Умножаем соответствующие элементы двух матриц и добавляем к сумме
                sumArray[i, j] += firstArray[i, k] * secondArray[k, j];
            }
        }
    }
    return sumArray;
}

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Первый массив");
int[,] randomArray = GetRandom2DArray(m);
Print2DArray(randomArray);

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Второй массив");
int[,] randomArraySecond = GetRandom2DArraySecond(randomArray);
Print2DArray(randomArraySecond);


Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Произведение двух матриц");
int[,] sumArray = SumArray(randomArray, randomArraySecond);
Print2DArray(sumArray);
Console.ForegroundColor = ConsoleColor.White;