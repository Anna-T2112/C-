// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели: ");
int n = int.Parse(Console.ReadLine()!);
if (n == 6 || n == 7)
    Console.WriteLine("Это выходной!");
else Console.WriteLine("Это будний день");