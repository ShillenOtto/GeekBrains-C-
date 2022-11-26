/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Без использования функции Math.Pow. */

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень числа: ");
int degree = Convert.ToInt32(Console.ReadLine());
int degree_for_answer = degree;
int result = 1;

while(degree > 0)
{
    result = result * number;
    degree --;
}

Console.WriteLine($"Результат: {number} в степерни {degree_for_answer} равен {result}.");