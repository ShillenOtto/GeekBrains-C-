/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/



int rows = ReadInt("Введите кол-во строк: ");
int columns = ReadInt("Введите кол-во столбцов: ");
int[,] numbers = new int[rows, columns];
FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers);

double sum = 0;

Console.Write("Среднее арифметическое каждого столбца: ");
for(int i = 0; i < numbers.GetLength(1); i++)
{
    for(int j = 0; j < numbers.GetLength(0); j++)
    {
        sum += numbers[j,i];
    }
    Console.Write(" " + Math.Round(sum / numbers.GetLength(0), 1) + ";");
    sum = 0;
}



void FillMatrixRandomNumbers(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1,10);
        }
    }
}

void WriteMatrix(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

