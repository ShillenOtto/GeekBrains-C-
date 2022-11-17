/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным. */

Console.WriteLine("Введите цифру обозначающую день недели: ");
string number = Console.ReadLine();
int num = Convert.ToInt32(number);

if (num == 6 || num == 7)
{
    Console.WriteLine("Да");
}
else if (num > 7)
{
    Console.WriteLine("Такого дня недели нет");
}
else
{
    Console.WriteLine("Нет");
}
