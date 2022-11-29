// Задайте значения M и N. Напишите программу, которая найдёт
//  сумму натуральных элементов в промежутке от M до N.

int GetSum(int n, int m)
{
    Console.WriteLine($"{n}");
    var sum = 0;
    if (n != m)
        sum += n + GetSum(n + 1, m);
    else sum += n;
    return sum;
}

Console.WriteLine("Введите n: ");
var n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите m: ");
var m = int.Parse(Console.ReadLine());
var sum = GetSum(n, m);
Console.WriteLine($"Сумма: {sum}");