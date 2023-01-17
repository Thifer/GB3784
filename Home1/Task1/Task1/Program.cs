/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

using static System.Int32;

Console.Write("input first number:");
int a = Parse(Console.ReadLine());
Console.Write("input second number:");
int b = Parse(Console.ReadLine());

Console.WriteLine($"min: {a},max: {b}",Math.Min(a,b),Math.Max(a,b));

