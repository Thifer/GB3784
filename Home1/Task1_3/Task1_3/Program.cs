/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

using static System.Int32;

Console.Write("input number:");
int a = Parse(Console.ReadLine());
Console.WriteLine(a%2==0?"number is even":"number is odd");