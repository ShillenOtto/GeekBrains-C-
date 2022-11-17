/* Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа. */

Console.WriteLine("Введите техзначное число: ");
string number = Console.ReadLine();
int num = Convert.ToInt32(number);

if (99 < num && num < 1000)
{
    Console.WriteLine(num % 100 / 10);
}
else
{
    Console.WriteLine("Вы ввели не неверное число");
}
