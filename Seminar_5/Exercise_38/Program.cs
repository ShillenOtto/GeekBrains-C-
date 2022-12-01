// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите длинну массива: ");
int leght = Convert.ToInt32(Console.ReadLine());

int[] array = new int[leght];
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100);
}

void Print_array(int[] array)
{
    Console.Write("Ваш массив: ");
    var str = string.Join(" ", array);
    Console.WriteLine(str);
}

int min_number = 100;
int max_number = -100;
int k = 0;
while(k < leght)
{
    if (array[k] > max_number)
    {
        max_number = array[k];
    }
    if (array[k] < min_number)
    {
        min_number = array[k];
    }
    k ++;
}

Print_array(array);
Console.WriteLine("Разница между максимальным и минимальным элементов массива: " + (max_number - min_number));