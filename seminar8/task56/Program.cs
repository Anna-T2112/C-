// Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.

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

int GetLowRow(int[,] array)
{
    var rows = array.GetLength(0);
    var cols = array.GetLength(1);
    var globalSum = 0;
    var result = 0;
    for (var i = 0; i < rows; i++)
    {
        var sum = 0;
        for (var j = 0; j < cols; j++)
        {
            sum += array[i, j];
        }
        if (i == 0)
        {
            globalSum = sum;
            continue;
        }
        if (globalSum > sum)
        {
            globalSum = sum;
            result = i;
        }
    }
    return result;
}


var inArray = GetArray();
ShowArray(inArray);
var min = GetLowRow(inArray);
Console.WriteLine($"Строка с наименьшей сумой элементов {min}");