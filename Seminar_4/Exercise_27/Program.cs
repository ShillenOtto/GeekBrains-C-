// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите любое число: ");

string number = Console.ReadLine();
int sum = 0;

for(int i = 0; i < number.Length; i++)
{
    string digit = Convert.ToString(number[i]);
    sum += Convert.ToInt32(digit);
}

Console.WriteLine(sum);