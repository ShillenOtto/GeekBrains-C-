// Напишите программу, которая задаёт массив из N элементов и выводит их на экран. 
//Вывод сделать отдельным методом.

Console.WriteLine("Введите длинну массива: ");
int leght = Convert.ToInt32(Console.ReadLine());

int[] array = new int[leght];
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 1000);
}

void Print_array(int[] array)
{
    Console.Write("Ваш массив: ");
    var str = string.Join(" ", array);
    Console.WriteLine(str);
}

Print_array(array);

