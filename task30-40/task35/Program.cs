/*
35. Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов 
массив
Пример для массива из 5, а не 123 элементов. В своем решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/
Console.Clear();
Console.Write("Введите число элементов массива: ");
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
int QuantityNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            count += 1;
        }
    }
    return count;
}
int[] userArray = GetRandomArray(arrayLength, min, max);
PrintArray(userArray);
int count = QuantityNumber(userArray);
Console.WriteLine();
Console.WriteLine($"Количество чисел в промежутке [10;99]: {count}.");