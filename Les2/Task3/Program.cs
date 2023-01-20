Console.Write("Введите первое число: ");
int numA = Int32.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numB = Int32.Parse(Console.ReadLine());

if (numA % numB == 0)
{
    Console.WriteLine("Число 1 кратно числу 2");
}
else
{
    Console.WriteLine($"Остаток от деления числа {numA} на число {numB} = " + numA % numB);
}