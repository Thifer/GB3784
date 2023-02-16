int Readint(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine());
}

int[,] FillArr(int m, int n)
{
    int[,] array = new int[m, n];
    int counter = 1;
    int startcol = 0;
    int startrow = 0;
    int endrow = m - 1;
    int endcol = n - 1;
    while ((startcol <= endcol) & (startrow <= endrow))
    {
        for (int i = startcol; i <= endcol; i++, counter++) array[startrow, i] = counter;

        startrow++;

        for (int i = startrow; i <= endrow; i++, counter++) array[i, endcol] = counter;

        endcol--;

        for (int i = endcol; i >= startcol; i--, counter++) array[endrow, i] = counter;

        endrow--;

        for (int i = endrow; i >= startrow; i--, counter++) array[i, startcol] = counter;

        startcol++;
    }

    return array;
}

void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Console.Write("{0:000} ", array[i, j]);

        Console.WriteLine();
    }
}


int m, n = 0;
int[,] arr;


m = Readint("Введите число m");
n = Readint("Введите число n");
arr = FillArr(m, n);
PrintArr(arr);
Console.WriteLine();