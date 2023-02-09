//удалить строку и столбец на пересечении которых находится наименьший элемент массива

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
            array[i, j] = random.Next(1,10);
        }
    }

    return array;
}

int[,] findanddelete(int[,] arr,int m,int n)
{
    int min = arr[0, 0];
    int[,] array = new int[m-1, n-1];
    int indI = 0;
    int indJ = 0;
    int ii = 0;
    int jj = 0;
    for (int i = 1; i < m; i++)
    {
        for (int j = 1; j < n; j++)
        {
            if (min > arr[i, j]) min = arr[i, j];
        }
    }

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (arr[i,j] == min)
            {
                indI = i;
                indJ = j;
                break;
            }
        }
    }

    for (int i = 0; i < array.GetLength(0); i++)                                                         
    {

        jj = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            if (indJ == jj) jj++;
            array[i, j] = arr[ii, jj];
            jj++;
        }
        if (indI == ii) ii++;
        ii++;
    }

    return array;
}

void PrintArr(int[,] array)
{
    Console.WriteLine();
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
int[,] arr;
Dictionary<int, int> freqDict = new Dictionary<int, int>();
Random rnd = new Random();


m = Readint("Введите число m");
n = Readint("Введите число n");
arr = FillArr(m,n,rnd);

PrintArr(arr);
Console.WriteLine();
PrintArr(findanddelete(arr,m,n));
