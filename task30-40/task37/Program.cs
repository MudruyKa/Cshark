
/*37. Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/
//Console.Clear();
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
int[] MultyArray(int[] array)
{
    int[] newarray = new int[(array.Length+1) / 2];
    for (int i = 0; i < array.Length; i++)
    {
        newarray[i] = array[i] * array[array.Length - i - 1];
    }
    return newarray;
}
int[] userArray = GetRandomArray(arrayLength, min, max);
PrintArray(userArray);
Console.WriteLine();
int[] newArray = MultyArray(userArray);
PrintArray(newArray);

