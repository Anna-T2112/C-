// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void GetPoint()
{
    Console.WriteLine("Введите b1: ");
    var b1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите k1: ");
    var k1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите b2: ");
    var b2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите k2: ");
    var k2 = int.Parse(Console.ReadLine());
    double x = (double)(b2 - b1) / (k1 - k2);
    double y = (double)(k1 * b2 - k2 * b1) / (k1 - k2);
    Console.WriteLine($"({x},{y})");
}

GetPoint();