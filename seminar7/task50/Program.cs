// Задача 50. Напишите программу, которая на вход принимает число и ищет его в двумерном массиве.
//  Программа должна возвращать значение позиции (номер строки и столбца) этого элемента или же указание,
//  что такого элемента нет.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void FindNumber(int[,] array)
{
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine()!);
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == number)
                {
                    Console.WriteLine($"({i},{j})");
                    return;
                }
            }
        }
        Console.WriteLine("Такого числа в массиве нет");
    }
}


Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во стобцов: ");
int cols = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, cols, 0, 100);
PrintArray(array);
FindNumber(array);
