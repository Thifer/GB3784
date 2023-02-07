int[] array = new int[4];
Random rnd = new Random();


for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(100, 1000);
}

Array.Sort(array);

Console.Write(String.Join(", ",array));
Console.WriteLine();
Console.Write($"Разница между минимальными и максимальными = {array[array.Length-1]-array[0]}");