// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] numbers = new int[8];
Console.WriteLine("Введите восемь цифр:");
var array = new long[8];
for (var i = 0; i < 8; i++)
{
    array[i] = long.Parse(Console.ReadLine());
}
Console.WriteLine($"[{string.Join(",", array)}]");
