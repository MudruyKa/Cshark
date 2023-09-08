/*
33. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

Console.Write("Введите число элементов массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элементов массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов массива: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число, которое надо найти в массиве: ");
int findNumber = Convert.ToInt32(Console.ReadLine());

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
bool FindNumber(int[] array, int number)
{
    bool number1 = false;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] == number) number1 = true;
    }
     return number1;
}

FindNumber(findNumber, arrayLength);
bool findedNumber = FindNumber(findNumber, arrayLength);
Console.WriteLine();
Console.WriteLine(findedNumber);
