//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите 1е число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите 2е число: ");
int b = int.Parse(Console.ReadLine()!);

if (a > b)
{
    Console.WriteLine($"Число {a} больше чем {b}");
}
else
{
    Console.WriteLine($"Число {b} больше чем {a}");
}