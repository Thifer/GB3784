int[] array = new int[4];
int sumOdd = 0;
Random rnd = new Random();


for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(100, 1000);
}

for (int i = 1; i < array.Length; i+=2)
{
    sumOdd += array[i];
}

Console.Write(String.Join(", ",array));
Console.WriteLine();
Console.Write($"Сумма чисел на нечетных позициях = {sumOdd}");