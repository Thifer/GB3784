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

void Arraysort(int[,] array)
{
    int[] sumarr = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumarr[i] += array[i, j];
        }
    }

    int minsum = sumarr[0];
    int pos = 0;
    for (int i = 0; i < sumarr.Length; i++)
    {
        if (sumarr[i] < minsum)
        {
            pos = i;
            minsum = sumarr[i];
        } 
    }
    Console.WriteLine(pos);
}

int m,n = 0;
int[,] arr;
Random rnd = new Random();


m = Readint("Введите число m");
n = Readint("Введите число n");
arr = FillArr(m,n,rnd);
PrintArr(arr);
Console.WriteLine();
Arraysort(arr);