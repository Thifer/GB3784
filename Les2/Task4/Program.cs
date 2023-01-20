Console.Write("Введите первое число: ");
int numA = Int32.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numB = Int32.Parse(Console.ReadLine());
if(numA*numA==numB) Console.WriteLine($"Число {numB} является квадратом числа {numA}");
else if(numB*numB==numA) Console.WriteLine($"Число {numA} является квадратом числа {numB}");
else Console.WriteLine("Ни одно число не является квадратом другого");