/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
Console.Write("Введите число: ");
int userlenght = Convert.ToInt32(Console.ReadLine());
int[] GetRandomArray()
{
    Console.Write("Введите минимальное значение массива: ");
    int minposition = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение массива: ");
    int maxposition = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[userlenght];
    for (int i = 0; i < array.Length; i++)
    {

        array[i] = new Random().Next(minposition, maxposition);
    }
    return array;
}

int[] userArray = GetRandomArray();

void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write($" {arrayToPrint[i]} ");

    }
    Console.Write("]");
}
PrintArray(userArray);