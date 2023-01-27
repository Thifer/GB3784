/*Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/

void Fill(int[] ints,int min,int max)
{
    Random rnd = new Random();
    for (int i = 0; i < ints.Length; i++)
    {
        ints[i] = rnd.Next(min, max+1);
    }
}

void ReversNum(int[] ints)
{
    for (int i = 0; i < ints.Length; i++)
    {
        ints[i] *= -1;
    }
}


int[] array = new int[12];


Fill(array,-9,9);
Console.WriteLine(String.Join(" ", array));
ReversNum(array);
Console.WriteLine(String.Join(" ",array));