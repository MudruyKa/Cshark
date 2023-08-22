/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.WriteLine("Введите координаты двух точек: ");

int numberX1 = Convert.ToInt32(Console.ReadLine());
int numberY1 = Convert.ToInt32(Console.ReadLine());
int numberZ1 = Convert.ToInt32(Console.ReadLine());
int numberX2 = Convert.ToInt32(Console.ReadLine());
int numberY2 = Convert.ToInt32(Console.ReadLine());
int numberZ2 = Convert.ToInt32(Console.ReadLine());

double numberXY = Math.Sqrt((numberX2 - numberX1)*(numberX2 - numberX1) + (numberY2-numberY1)*(numberY2-numberY1)+ (numberZ2-numberZ1)*(numberZ2-numberZ1));
double roundedNumber = Math.Round(numberXY, 3); 
Console.WriteLine(roundedNumber);
