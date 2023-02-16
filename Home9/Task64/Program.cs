void printnum(int num)
{
    Console.Write($"{num} ");
    if(num>1) printnum(num-1);
    
}

int num = int.Parse(Console.ReadLine());
printnum(num);