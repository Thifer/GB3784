Console.Write("Введите трехзначное число: ");

int numA = Int32.Parse(Console.ReadLine());

Console.WriteLine("Второе число = " + numA / 10 % 10);