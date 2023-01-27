/*Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/

void Fill(int[] ints,int min,int max)
{
    Random rnd = new Random();
    for (int i = 0; i < ints.Length; i++)
    {
        ints[i] = rnd.Next(min, max+1);
    }
}
int[] PairNum(int[] ints)
{
    int len = (ints.Length + ints.Length % 2) / 2;
    int[] result = new int[len];
    for (int i = 0; i < len; i++)
    {
        result[i] += ints[i] * ints[^(i+1)];
    }
    if (ints.Length % 2 == 1) result[^1] = ints[len - 1];
    return result;
}

int[] array = new int[7];

Fill(array,0,100);
Console.WriteLine(String.Join(" ",array));
Console.WriteLine(String.Join(" ",PairNum(array)));

