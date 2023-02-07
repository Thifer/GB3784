/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/

Console.Write("Введите 5ти значное число: ");

int number = int.Parse(Console.ReadLine());

if(number/10000==number%10&number/1000%10==number%100/10) Console.WriteLine("yes");
else Console.WriteLine("no");
 