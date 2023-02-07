/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

using static System.Int32;

int Maxcheck(int numberA,int numberB)
{
    return numberA >= numberB ? numberA : numberB;
}

int a = 0;

Console.Write("input first number:");
a = Parse(Console.ReadLine());
Console.Write("input second number:");
a = Maxcheck(a,Parse(Console.ReadLine()));
Console.Write("input third number:");
a = Maxcheck(a,Parse(Console.ReadLine()));

Console.WriteLine($"max: {a}",a);
