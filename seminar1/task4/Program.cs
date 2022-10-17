// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите 1е число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите 2е число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите 3е число: ");
int c = int.Parse(Console.ReadLine()!);

int max = a;
if (b > max) max = b;
if (c > max) max = c;

{
    Console.WriteLine($"Число {max} наибольшее ");
}