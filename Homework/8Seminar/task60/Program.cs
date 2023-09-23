/*
Задача 60.
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

Console.Clear();
Console.Write("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int[,,] GetRandom2DArray(int a, int b, int c)
{
     int randomNumber = 0;
    int[,,] result = new int[a, b, c];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int m = 0; m < c; m++)
            {
                result[i, j, m] = new Random().Next(10, 100);
                if (result[i, j, m]== randomNumber)
                {
                    result[i, j, m] = new Random().Next(10, 100);
                }
                randomNumber= result[i,j,m];
            }

        }
    }
    return result;
}
void Print2DArray(int[,,] arrayToPrint)
{
    

    Console.WriteLine();
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int x = 0; x < c; x++)
            {

                Console.Write($"{arrayToPrint[i, j, x]} ({i},{j},{x}); ");
            }
        }
        Console.WriteLine();
    }
}
int[,,] randomArray = GetRandom2DArray(a, b, c);
Print2DArray(randomArray);
