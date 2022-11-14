Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int num = Convert.ToInt32(number);

int a = 2;

while (a < (num + 1))
{
    Console.Write(a + ", ");
    a += 2;
}