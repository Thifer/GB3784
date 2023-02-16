int acc(int n, int m)
{
    while (n!=0)
    {
        if (m == 0)
        {
            m = 1;
        }
        else
        {
            m = acc(n, m - 1);
        }

        n -= 1;
    }

    return m + 1;
}


int numN = int.Parse(Console.ReadLine());
int numM = int.Parse(Console.ReadLine());
Console.WriteLine($"{acc(numN,numM)}");


