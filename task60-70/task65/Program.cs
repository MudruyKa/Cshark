
/* 65. Задайте значения М и N. Напишите программу, которая выведет все натуральные числа в промежутке от М до N.
*/
void NuturalNum(int m, int n)
{
    if (m < n)
    {
        System.Console.write(m + ",");
        NuturalNum(m + 1, n);
    }
}
NuturalNum(1, 5);