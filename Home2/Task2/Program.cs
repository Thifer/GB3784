Console.Write("Введите число: ");
int numA = Int32.Parse(Console.ReadLine());
if (numA<100){
    Console.WriteLine("Третьего числа нет");
}
else
{
    while (numA>999)
    {
        numA = numA/ 10;
    }
    Console.WriteLine("Третье число: "+numA%10);
}