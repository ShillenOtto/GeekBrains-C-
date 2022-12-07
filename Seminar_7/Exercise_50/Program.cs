/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */


int rows = ReadInt("Введите кол-во строк: ");
int columns = ReadInt("Введите кол-во столбцов: ");
int num = ReadInt("Введите позицию: ");
int[,] numbers = new int[rows, columns];
FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers);

int m = rows;
int n = columns;
bool flag = false;

for (int i = 0; i < m; i++)    //m=строки
{
    for (int j = 0; j < n; j++)   //n=столбцы
    {
        if (numbers[i, j] == num)
        {
            flag = true;
        }
    }
}
if (flag == true)
{
    Console.Write("Такое число в массиве есть");
}
else
{
    Console.Write("Такого числа в массиве нет");
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

