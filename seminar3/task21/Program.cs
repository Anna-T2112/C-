// Задача 21 Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координаты первой точки через запятую");
var a = Console.ReadLine();
var values = a.Split(',');
var ax = int.Parse(values[0]);
var ay = int.Parse(values[1]);
var az = int.Parse(values[2]);

Console.WriteLine("Введите координаты второй точки через запятую");
var b = Console.ReadLine();
var bvalues = b.Split(',');
var bx = int.Parse(bvalues[0]);
var by = int.Parse(bvalues[1]);
var bz = int.Parse(bvalues[2]);
var length = GetLength(ax, ay, az, bx, by, bz);
Console.WriteLine($"Расстояние между точками {String.Format("{0:0.00}", length)}");

static double GetLength(int ax, int ay, int az, int bx, int by, int bz)
{
    var result = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
    return result;
}