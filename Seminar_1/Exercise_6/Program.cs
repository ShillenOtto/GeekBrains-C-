Console.WriteLine("Введите число для проверки: ");
string number = Console.ReadLine();
int num = Convert.ToInt32(number);

int result = num % 2;

if (result == 0)
{
    Console.Write(num + " " + "<- Да, четное число");
}
else
{
    Console.Write(num + " " + "<- Нет, нечетное число");
}