int[] array = new int[8];
Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(1, 100);
}

Console.WriteLine(String.Join(", ",array));
