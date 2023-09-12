/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
Console.Clear();
Console.WriteLine("Введите число: ");
int[] a = Convert.ToInt32(Console.ReadLine());
string Delenie(int[] a)
{
    string result = string.Empty;
    int temp = 0;
    for (int i = a; i > a.Length; i /= 2)
    { 
        temp = i % 2;
        result = temp + result;
    }
    return result;
}
string b = Delenie(a);
Console.WriteLine(b);