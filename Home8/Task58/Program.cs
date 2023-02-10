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

int[,] Mularr(int[,] array1, int[,] array2)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array1[i, j] *= array2[i, j];
        }
    }

    return array1;
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



int m,n = 0;
int[,] arr1;
int[,] arr2;
Random rnd = new Random();


m = Readint("Введите число m");
n = Readint("Введите число n");
arr1 = FillArr(m,n,rnd);
PrintArr(arr1);
Console.WriteLine();
arr2 = FillArr(m,n,rnd);
PrintArr(arr2);
Console.WriteLine();
PrintArr(Mularr(arr1,arr2));