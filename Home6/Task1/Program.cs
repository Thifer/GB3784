int Result()
{
    Int32[] int32s;
    Int32 int32;
    for (int i = 0; i < int32s.Length; i++)
    {
        if (int32s[i] > 0) int32++;
    }

    return int32;
}

void FillArr(int a)
{
    array = new int[a]
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
}

void ShowArr(int[] arr)
{
    Console.WriteLine(String.Join(", ",arr));
}


int[] array;
int result = 0;


Console.WriteLine("Введите кол-во чисел в массиве");
FillArr(int.Parse(Console.ReadLine()));
result = Result();

ShowArr(array);
Console.WriteLine($"Чисел больше 0: {result}");

