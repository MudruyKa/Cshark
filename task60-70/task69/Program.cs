﻿/* 69. Напишите программу, которая на вход принимает два числа А и В, и возводит число А в целую степень в с помощью рекурсии.
*/
int result = ProdNumber(5,2);
int ProdNumber (int n, int m)
{
if(m==1)
return n;
else
return n*ProdNumber (n,m-1);
}
Console.WriteLine(result);