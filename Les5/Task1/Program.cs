using System.Data;

void Fill(int[] ints,int min,int max)
{
    Random rnd = new Random();
    for (int i = 0; i < ints.Length; i++)
    {
        ints[i] = rnd.Next(min, max+1);
    }
}

int SumNum(int[] ints,bool flag)
{
    int sumNum = 0;
    for (int i = 0; i < ints.Length; i++)
    {
         if (ints[i] > 0 & flag) sumNum += ints[i]; 
         if (ints[i] < 0 & !flag) sumNum += ints[i]; 
    }
    return sumNum;
}


int[] array = new int[12];


Fill(array,-9,9);
Console.WriteLine(String.Join(" ",array));
Console.WriteLine($"Сумма положительных чисел = {SumNum(array,true)}");
Console.WriteLine($"Сумма отрицательных чисел = {SumNum(array,false)}");


