/* Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве. */

// Точка А
Console.WriteLine("Введите координату X первой точки: ");
string x1_ = Console.ReadLine();
int x1 = Convert.ToInt32(x1_);
Console.WriteLine("Введите координату Y первой точки: ");
string y1_ = Console.ReadLine();
int y1 = Convert.ToInt32(y1_);
Console.WriteLine("Введите координату Z первой точки: ");
string z1_ = Console.ReadLine();
int z1 = Convert.ToInt32(z1_);
// Точка В
Console.WriteLine("Введите координату X первой точки: ");
string x2_ = Console.ReadLine();
int x2 = Convert.ToInt32(x2_);
Console.WriteLine("Введите координату Y первой точки: ");
string y2_ = Console.ReadLine();
int y2 = Convert.ToInt32(y2_);
Console.WriteLine("Введите координату Z первой точки: ");
string z2_ = Console.ReadLine();
int z2 = Convert.ToInt32(z2_);

int a = x1 - x2;
int b = y1 - y2;
int c = z1 - z2;

double result = Math.Sqrt(a*a + b*b + c*c);

Console.WriteLine(result);