int[] array = new int[4];
int result = 0;

Console.WriteLine("Введите 4 числа");

for (int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) result++;
}

Console.WriteLine(String.Join(", ",array));
Console.WriteLine($"Чисел больше 0: {result}");
