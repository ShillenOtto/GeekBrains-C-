//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите длинну массива: ");
int leght = Convert.ToInt32(Console.ReadLine());

int[] array = new int[leght];
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 999);
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
    if (array[k] % 2 == 0)
    {
        count ++;
    }
    k ++;
}

Print_array(array);
Console.WriteLine("Количество чётных чисел в массиве: " + count);