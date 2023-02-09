int Readint(string text){
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine());
}

int[,] FillArr(int m, int n, Random random)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(0,10);
        }
    }

    return array;
}

void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+"\t");
        }
        Console.WriteLine();
    }
}

void PrintArrMid(int[,] array)
{
    float midnumsum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            midnumsum += array[j, i];
        }
        Console.WriteLine("Среднее в стобце {0} = {1:f}",i,midnumsum/array.GetLength(0));
        midnumsum = 0;
    }
}

int m,n = 0;
int[,] arr;
Random rnd = new Random();


m = Readint("Введите число m");
n = Readint("Введите число n");
arr = FillArr(m,n,rnd);
PrintArr(arr);
Console.WriteLine();
PrintArrMid(arr);