// Задача 13: Напишите программу, которая выводит третью цифру (справа налево)
// заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
var input = Console.ReadLine();
var k = int.Parse(input);
if (k < 100)
{
    Console.WriteLine("третьей цифры нет");
    Console.ReadKey();
    return;
}
int d = 0;
while (k >= 100)
{
    d = k % 10;
    k = k / 10;
}



Console.WriteLine(d);
