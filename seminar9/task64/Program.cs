// Задайте значение N. Напишите программу, которая выведет все
//  натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void ShowNumber(int n)
{
    string inString = n == 1 ? $"{n}" : $"{n},";
    if (n != 1)
        Console.Write($"{n},");
    else
        Console.WriteLine($"{n}");

    if (n > 1)
        ShowNumber(n - 1);
}

Console.WriteLine("Введите n: ");
var n = int.Parse(Console.ReadLine());
ShowNumber(n);