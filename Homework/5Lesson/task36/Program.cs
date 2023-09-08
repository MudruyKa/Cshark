/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элементов массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] GetRandomArray(int arrayLength, int start, int end)
{
    int[] array = new int[arrayLength];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(start, end + 1);
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

int[] userArray = GetRandomArray(arrayLength, min, max);
PrintArray(userArray);

int SumOddNumbers(int[] array)
{
    int sumOddNumbers = 0;
    for (int i = 1; i < array.Length; i += 2) // Увеличиваем i на 2, чтобы работать только с нечётными позициями.
    {
        sumOddNumbers += array[i];
    }
    return sumOddNumbers;
}
Console.WriteLine();
int sumOddNumb = SumOddNumbers(userArray);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sumOddNumb}");
