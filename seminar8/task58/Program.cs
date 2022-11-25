//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] GetArray()
{
    Console.WriteLine($"Введите количество строк массива: ");
    var rows = int.Parse(Console.ReadLine());
    Console.WriteLine($"Введите количество столбцов массива: ");
    var cols = int.Parse(Console.ReadLine());
    var result = new int[rows, cols];
    for (var i = 0; i < rows; i++)
        for (var j = 0; j < cols; j++)
            result[i, j] = new Random().Next(1, 10);
    return result;
}
void ShowArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        string row = string.Empty;
        for (var j = 0; j < array.GetLength(1); j++)
            row += j < array.GetLength(1) - 1 ? $"{array[i, j]}, " : $"{array[i, j]}";
        Console.WriteLine(row);
    }
}

int[,] Multiplication(int[,] a, int[,] b)
{
    int[,] r = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                r[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return r;
}

var firstArray = GetArray();
ShowArray(firstArray);
var secondArray = GetArray();
ShowArray(secondArray);
var result = Multiplication(firstArray, secondArray);
ShowArray(result);
