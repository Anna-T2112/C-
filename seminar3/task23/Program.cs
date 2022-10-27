// Задача 23 Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число N:");
var n = int.Parse(Console.ReadLine());
var result = Pow3(n);
Console.WriteLine(result);

static string Pow3(int n)
{
    var result = string.Empty;
    for (int i = 1; i <= n; i++)
        result += i == n ? Math.Pow(i, 3).ToString() : Math.Pow(i, 3).ToString() + ',';

    return result;
}