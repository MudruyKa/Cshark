/*
44. Не используя рекурсию, выведите первые N чисел Фибоначчи.
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 01123
Если N = 3 -> 0 1 1
Если N = 7 ->0112358
*/
Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
void Fibonacci(int[] array, int a)
{
    array[0] = 0;
    array[1] = 1;
    Console.Write($" {a} -> {array[0]}, {array[1]}");
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
        Console.Write($", {array[i]}");
    }

}
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Fibonacci(array, a);
Console.ForegroundColor = ConsoleColor.White;