/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());

double[] GetRandomArray(int arrayLength, double min, double max)
{
    double[] array = new double[arrayLength];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next() * (max - min) + min;
    }

    return array;
}

void PrintArray(double[] arrayToPrint)
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

double FindDifference(double[] array)
{
    double min = array[0];
    double max = array[0];

for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    /*
    foreach (double element in array)
    {
        if (element < min)
        {
            min = element;
        }
        if (element > max)
        {
            max = element;
        }
    }
    */

    return max - min;
}

double[] userArray = GetRandomArray(arrayLength, min, max);
PrintArray(userArray);

double difference = FindDifference(userArray);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {difference}");
