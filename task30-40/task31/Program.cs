/*
31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9, -8, 1,0, -7,2, -1,8, -3, -1,6] сумма положительных чисел равна 29, сумма отрицательных равна - 20.*/

/*Console.Clear);
int[] GetRandomArray(int arrayLength1, int start, int end)
{
    int[] array = new int[arrayLength1];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start, end);
    }
    return array;
}

void GetSum(int[] array)
{
    int sumP = 0;
    int sumN = 0;

    for (int i = 0; i ‹ array.Length; i++)
{
        if (array[i] > 0)
            SumP = sumP + array[i];
    }
else
    {
        sumN = sumN + array[i];
        System.Console.WriteLine($"Сумма положительных - (sumP), сумма отрицательных - {sumN)");
    }
}

void PrintArray(int[1 arrayToPrint)
{
    Console.write("[");
    for (int 1 - 0; icarrayToPrint.Length; i + *)
    {
        Console.Write(arrayToPrint[il);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.write("]");
}
/*System.Console.writeLine("Введи число: )
int arrayl = Convert. ToInt32(Console. ReaLine ());
int min = Convert. ToInt32(Console. ReadLine());
int max = Convert. ToInt32(Console. ReadLine());
int [] userArray = GetRandomArray (arrayL, min, max);
Console.Write("Введите число: ");
int arrayL = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());
PrintArray(userArray);
System.Console.WriteLine();
//PrintArray(GetRandomArray(arrayL, min, max));
GetSum(userArray);
*/


Console.Write("Введите число элементов массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элементов массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetRandomArray(arrayLength, min, max);


PrintArray(userArray);
Console.WriteLine();
GetSum(userArray);


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

void GetSum(int[] array)
{
    int sumP = 0;
    int sumN = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumP += array[i];
        }
        else
        {
            sumN += array[i];
        }
    }

    Console.WriteLine($"Сумма положительных - {sumP}, сумма отрицательных - {sumN}");
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
   