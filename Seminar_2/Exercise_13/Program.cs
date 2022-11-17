 /* Напишите программу, которая выводит третью цифру заданного числа 
 или сообщает, что третьей цифры нет. */

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int num = Convert.ToInt32(number);

if (num <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else if (num >= 100 && num <=999)
{
    Console.WriteLine(num % 10);
}
else if (num >= 1000 && num <=9999)
{
    Console.WriteLine(num % 100 / 10);
}
else if (num >= 10000 && num <=99999)
{
    Console.WriteLine(num % 1000 / 100);
}