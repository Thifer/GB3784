int Readint(string text){
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine());
}

int[,,] FillArr(int m, int n,int k,Random random)
{
    int[,,] array = new int[m, n,k];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int l = 0; l < k; l++)
            {
                array[i,j,l] = random.Next(0,100);    
            }
            
        }
    }

    return array;
}


void PrintArr(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                Console.Write($"{array[j,l,i]}({j},{l},{i})\t");
            }
            Console.WriteLine();
        }
  
    }
}



int m,n,k = 0;
int[,,] arr;
Random rnd = new Random();


m = Readint("Введите число m");
n = Readint("Введите число n");
k = Readint("Введите число k");
arr = FillArr(m,n,k,rnd);
PrintArr(arr);
Console.WriteLine();
