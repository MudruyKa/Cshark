/*
Напишите программу, которая выводит массив из 8 элементов,
заполненый нулями и единицами в случайном порядке
*/

int[] GetRandomArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
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