﻿// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
int a = new Random().Next(100, 1000);
int result = ((a % 100) / 10);

Console.WriteLine($"{a},{result}");