/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Console.Clear();
Console.Write("Введите количество элементов массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());


int[] GetRandomArray(int arrayLength)
{
    int[] array = new int[arrayLength];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(99,999);
    }

    return array;
}

void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

int EvenNumbers (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count++;
    }
    return count;
}
int[] userArray = GetRandomArray(arrayLength);
PrintArray(userArray);
int evenNumbers = EvenNumbers(userArray);
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел в массиве: {evenNumbers} ");

