/*Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/


void Fill(int[] ints,int min,int max)
{
    Random rnd = new Random();
    for (int i = 0; i < ints.Length; i++)
    {
        ints[i] = rnd.Next(min, max+1);
    }
}

int CountNum(int[] ints)
{
    int result = 0;
    for (int i = 0; i < ints.Length; i++)
    {
        if (ints[i] > 9 & ints[i] < 100) result ++;
    }

    return result;
}


int[] array = new int[123];

Fill(array,0,200);
Console.WriteLine(String.Join(" ",array));
Console.WriteLine(CountNum(array));