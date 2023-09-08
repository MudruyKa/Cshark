/* Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

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

int[] ChangeSignArray(int [] firstarray)
{
    for (int i = 0; i < firstarray.Length; i++)
    {
        firstarray[i]*= (-1);
    }
    return (firstarray);
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
Console.WriteLine();
PrintArray(ChangeSignArray(userArray));
/*PrintArray(userArray);
Console.WriteLine();
ChangeSignArray(userArray);
*/