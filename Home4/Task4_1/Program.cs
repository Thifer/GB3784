int numA = 0;
int numB = 0;
int result = 0;

Console.Write("Введите число А: ");
numA  = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
numB  = int.Parse(Console.ReadLine());
result = numA;

for (int i = 1; i < numB; i++)
{
    result *= numA;
}

Console.WriteLine($"Число {numA} в степени {numB} = {result}");