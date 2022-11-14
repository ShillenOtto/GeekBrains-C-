//Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.Write("Введите первое число: ");
string input_a = Console.ReadLine();
int a = Convert.ToInt32(input_a);

Console.Write("Введите второе число: ");
string input_b = Console.ReadLine();
int b = Convert.ToInt32(input_b);

Console.Write("Введите третье число: ");
string input_c = Console.ReadLine();
int c = Convert.ToInt32(input_c);

int max = 0;

if (a > b)
{
    max = a;
}
else
{
    max = b;
}

if (c > max)
{
    max = c;
}
else
{
    max = max;
}

Console.WriteLine("Самое большое число: " + max);