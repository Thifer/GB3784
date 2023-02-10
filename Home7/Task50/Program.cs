//в задаче не понятно что именно нужно найти - позицию заданного числа или число по заданной позиции - сделал и то и то

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

void Findbypos(int[,] array,int num)
{
    int maxposvalue = array.GetLength(0) * array.GetLength(1);
    if (num > maxposvalue)
    {
        Console.WriteLine("Слишком большая позиция");
        return;
    }
    int i = 0;
    while (num>array.GetLength(1))
    {
        num-=array.GetLength(1);
        i++;
    }

    Console.WriteLine(array[i,num-1]);
}

void Findbynum(int[,] array, int num)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j]==num) {
                Console.WriteLine("строка = {0}, столбец = {1}",i+1,j+1);
                return;
            }
        }
    }
    Console.WriteLine("Такого числа нет");
}

void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0}\t",array[i,j]);
        }
        Console.WriteLine();
    }
}


int m,n = 0;
int askedNum = 6;
int[,] arr;
Random rnd = new Random();


m = Readint("Введите число m");
n = Readint("Введите число n");

arr = FillArr(m,n,rnd);
PrintArr(arr);
Console.WriteLine();
Findbypos(arr,askedNum);
Console.WriteLine();
Findbynum(arr,askedNum);



