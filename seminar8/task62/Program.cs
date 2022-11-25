// Напишите программу, которая заполнит спирально массив 4 на 4. 

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

int[,] GetSpire(int n)
{
    int[,] matrix = new int[n, n];

    int row = 0;
    int col = 0;
    int dx = 1;
    int dy = 0;
    int dirChanges = 0;
    int visits = n;
    for (int i = 0; i < matrix.Length; i++)
    {
        matrix[row, col] = i + 1;
        if (--visits == 0)
        {
            visits = n * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }

        col += dx;
        row += dy;
    }
    return matrix;
}


var result = GetSpire(4);
ShowArray(result);