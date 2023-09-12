/*
Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] - > [6 3 7 6]
Комментарий: эту задачу можно решить 2 способами:
1) менять числа местами в исходном массиве;
2) создать новый массив и в него записать перевёрнутый исходный массив по элементам.
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

int[] TurnArray(int[] arrayForTurn)
{
    int temp = 0;
    for (int i = 0; i < arrayForTurn.Length / 2; i++)
    {
        temp = arrayForTurn[i];
        arrayForTurn[i] = arrayForTurn[arrayForTurn.Length - 1 - i];
        arrayForTurn[arrayForTurn.Length - 1 - i] = temp;
    }
    return arrayForTurn;
}

Console.ForegroundColor = ConsoleColor.Blue;
PrintArray(userArray);
int[] turnArray = TurnArray(userArray);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
PrintArray(turnArray);