/* Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу кубов чисел от 1 до N. */

Console.WriteLine("Введите любое число: ");
string number = Console.ReadLine();
int num = Convert.ToInt32(number);

for (int i = 1; i <= num; i++)
{
    Console.Write(i * i * i + " ");
}