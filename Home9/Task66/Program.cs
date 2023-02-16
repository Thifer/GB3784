void printSum(int numA, int numB,int sum)
{
    sum += numA;
    if (numA < numB) printSum(numA + 1, numB, sum);
    else Console.WriteLine($"{sum}");
}


int numA = int.Parse(Console.ReadLine());
int numB = int.Parse(Console.ReadLine());
printSum(numA,numB,0);