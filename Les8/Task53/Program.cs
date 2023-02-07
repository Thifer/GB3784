/* найти сумму элементов на главной диагонали двумерного массива*/

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

int[,] SwapArrLines(int[,] arr)
{
    int[,] swapedArray = arr;
    int len = swapedArray.GetLength(0);
    for (int i = 0; i < swapedArray.GetLength(1); i++)
    {
        (swapedArray[len - 1, i], swapedArray[0, i]) = (swapedArray[0, 1], swapedArray[len - 1, i]);
    }

    return swapedArray;
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
Random rnd = new Random();


m = Readint("Введите число m");
n = Readint("Введите число n");
arr = FillArr(m,n,rnd);

PrintArr(arr);
Console.WriteLine();
PrintArr(SwapArrLines(arr));