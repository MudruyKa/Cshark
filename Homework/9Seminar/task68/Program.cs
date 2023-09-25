/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
Console.Clear();
Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
int Ack(int n, int m)
{
   if(n == 0)
   return m + 1;
   else if (m == 0)
     return Ack (n - 1, 1);
   else
     return Ack(n - 1, Ack (n, m - 1));
}
int result= Ack(m,n);
Console.WriteLine(result);
