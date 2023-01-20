int num = new Random().Next(100, 1000);
Console.WriteLine(num);
int numA = num / 100;
int numB = num % 10;
Console.WriteLine(numB + 10 * numA);