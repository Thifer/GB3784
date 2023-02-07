int num = new Random().Next(10, 100);
Console.WriteLine(num);
int numA = num / 10;
int numB = num % 10;

Console.WriteLine(Math.Max(numA, numB));