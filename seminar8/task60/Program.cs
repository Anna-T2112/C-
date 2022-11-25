// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] GetArray()
{
    Console.WriteLine($"Введите x: ");
    var x = int.Parse(Console.ReadLine());
    Console.WriteLine($"Введите y: ");
    var y = int.Parse(Console.ReadLine());
    Console.WriteLine($"Введите z: ");
    var z = int.Parse(Console.ReadLine());
    var array = new int[x, y, z];
    for (var i = 0; i < x; i++)
        for (var j = 0; j < y; j++)
            for (var k = 0; k < z; k++)
            {
                var value = new Random().Next(10, 100);
                while (hasValue(array, value))
                {
                    value = new Random().Next(10, 100);
                }
                array[i, j, k] = value;
            }
    return array;
}

void Showrray(int[,,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
        for (var j = 0; j < array.GetLength(1); j++)
            for (var k = 0; k < array.GetLength(2); k++)
                Console.WriteLine($"{array[i, j, k]} ({i},{j},{k})");
}

bool hasValue(int[,,] array, int value)
{
    for (var i = 0; i < array.GetLength(0); i++)
        for (var j = 0; j < array.GetLength(1); j++)
            for (var k = 0; k < array.GetLength(2); k++)
                if (array[i, j, k] == value)
                    return true;

    return false;
}

var array = GetArray();
Showrray(array);