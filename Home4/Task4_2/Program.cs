int numA = 0;
int result = 0;

Console.Write("Введите число: ");
numA  = int.Parse(Console.ReadLine());


int dignum = (int)Math.Log10(numA) + 1;


for (int i = 0; i < dignum; i++)
{
    result += numA % 10;
    numA = numA / 10;
}

Console.WriteLine($"Сумма чисел = {result}");