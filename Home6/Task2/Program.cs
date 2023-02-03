int b1,k1,b2,k2 = 0;


void collisionchech(int b1, int b2, int k1, int k2)
{
    if(k1==k2) Console.WriteLine("Прямые параллельны");
    else
    {
        float x = (float)(b2 - b1) / (k1 - k2);
        float y = (k1 * b2 - k2 * b1) / (float)(k1 - k2);
        Console.WriteLine($"({x};{y})");        
    }
}

int printtext(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine());
}

b1 = printtext("Введите b1");
k1 = printtext("Введите k1");
b2 = printtext("Введите b2");
k2 = printtext("Введите k2");


collisionchech(b1,b2,k1,k2);



