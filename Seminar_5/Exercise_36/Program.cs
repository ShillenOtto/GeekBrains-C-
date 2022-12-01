//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.WriteLine("Введите длинну массива: ");
int leght = Convert.ToInt32(Console.ReadLine());

int[] array = new int[leght];
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
}

void Print_array(int[] array)
{
    Console.Write("Ваш массив: ");
    var str = string.Join(" ", array);
    Console.WriteLine(str);
}

int k = 0;
int count = 0;
while(k < leght)
{
    if (k % 2 != 0)
    {
        count = count + array[k];
    }
    k ++;
}

Print_array(array);
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + count);