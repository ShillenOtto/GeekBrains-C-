/* Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом. */

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
int num = Convert.ToInt32(number);

if((num / 10000 == num % 10) && (num / 1000 % 10 == ((num % 100) - num % 100 % 10) / 10))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}