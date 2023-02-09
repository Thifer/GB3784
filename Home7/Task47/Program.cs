int Readint(string text){
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine());
}

float[,] FillArr(int m, int n, Random random)
{
    float[,] array = new float[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = (float)random.NextDouble() * 10;
        }
    }

    return array;
}

void PrintArr(float[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0:F}\t",array[i,j]);
        }
        Console.WriteLine();
    }
}

int m,n = 0;
float[,] arr;
Random rnd = new Random();


m = Readint("Введите число m");
n = Readint("Введите число n");
arr = FillArr(m,n,rnd);
PrintArr(arr);