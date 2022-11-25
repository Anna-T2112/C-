//  Задайте двумерный массив.
//  Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int[,] GetOutArray(int[,] inArray)
{
    var rows = inArray.GetLength(0);
    var cols = inArray.GetLength(1);
    var outArray = new int[rows, cols];
    for (var i = 0; i < rows; i++)
    {
        int[] toSort = new int[cols];
        for (var j = 0; j < cols; j++)
            toSort[j] = inArray[i, j];

        var sorted = Sort(toSort);
        for (var k = 0; k < sorted.Length; k++)
            outArray[i, k] = sorted[k];
    }
    return outArray;
}

int[] Sort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j] < array[j + 1])
            {
                int z = array[j];
                array[j] = array[j + 1];
                array[j + 1] = z;
            }
        }
    }
    return array;
}

var inArray = GetArray();
ShowArray(inArray);
var outArray = GetOutArray(inArray);
Console.WriteLine("Итоговый массив");
ShowArray(outArray);