int[] array = new int[10];
int evenCount = 0;
Random rnd = new Random();


for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(100, 1000);
}

Console.Write(String.Join(", ",array));

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) evenCount++;
}

Console.Write($" => из них четных чисел: {evenCount}");