/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
Console.Clear();
Console.Write("Введите число элементов массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());

int[] Array(int arrayLength)
{
    int[] array = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        Console.Write("Введите элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
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
int CountOfZero(int[] arrayCount)
{
    int countOfZero = 0;
    for (int i = 0; i < arrayCount.Length; i++)
    {
        if (arrayCount[i] > 0) countOfZero++;
    }
    return countOfZero;
}
int[] userArray = Array(arrayLength);
PrintArray(userArray);
Console.ForegroundColor = ConsoleColor.Green;
int countOfZero = CountOfZero(userArray);
Console.WriteLine();
Console.WriteLine($"Количество чисел больше нуля: {countOfZero}.");
Console.ForegroundColor = ConsoleColor.White;