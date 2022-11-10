// Задача “со звездочкой”: Напишите функцию, которая принимает 
// одно число - высоту елочки и рисует ее в консоли звездочками.

Console.WriteLine("Введите высоту:");
var a = int.Parse(Console.ReadLine());
int spaces = a;
int cnt = 1;
for (int i = 0; i < a; i++)
{
    var sp = string.Join(string.Empty, Enumerable.Repeat(" ", spaces));
    Console.Write(sp);

    var stars = string.Join(string.Empty, Enumerable.Repeat("* ", cnt));
    Console.Write(stars);
    Console.WriteLine();
    cnt++;
    spaces--;
}
