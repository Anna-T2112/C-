// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

void NumbersMoreThanZero()
{
    Console.WriteLine("Введите количество чисел:");
    int n = int.Parse(Console.ReadLine());
    int cnt = 0;
    for (var i = 0; i < n; i++)
    {
        Console.WriteLine($"Введите число {i + 1}:");
        var value = int.Parse(Console.ReadLine());
        if (value > 0)
            cnt++;
    }
    Console.WriteLine($"Количество чисел больше нуля: {cnt}");

}
NumbersMoreThanZero();
