/* Напишите программу, которая принимает на вход число N и выдаёт произведение
 чисел от 1 до N.
4 -> 24
5 -> 120
*/

int ProductOfNumber(int number)
{
    int product = 1;
    while (number !=0 )
    {
        product *= number;
        number--;
    }

    return product;
}
Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ProductOfNumber(userNumber));