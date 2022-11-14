//Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
string input_a = Console.ReadLine();
int a = Convert.ToInt32(input_a);

Console.Write("Введите второе число: ");
string input_b = Console.ReadLine();
int b = Convert.ToInt32(input_b);

int max = 0;

if (a > b)
{
    max = a;
    Console.WriteLine("Это число больше: " +max);

}
else
{
    max = b;
    Console.WriteLine("Это число больше: " + max);
}
