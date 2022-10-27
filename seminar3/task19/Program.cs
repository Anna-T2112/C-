// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

static bool IsPalindrome(int x)
{
    if (x < 0 || (x % 10 == 0 && x != 0))
        return false;

    int revertedNumber = 0;
    while (x > revertedNumber)
    {
        revertedNumber = revertedNumber * 10 + x % 10;
        x /= 10;
    }
    return x == revertedNumber || x == revertedNumber / 10;
}

Console.WriteLine("Введите пятизначное число:");
int x = int.Parse(Console.ReadLine());
var result = IsPalindrome(x);
Console.WriteLine($"{(result ? "Число является палиндромом" : "Число не является палиндромом")}");
