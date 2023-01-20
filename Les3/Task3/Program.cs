/*расстояние между двумя точками
 AB = √((xb - xa)2 + (yb - ya)2).*/

int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

float Distance(int ax, int ay, int bx, int by) => (float)Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));

int aX = GetNum("Введите координату X для первой точки:");
int aY = GetNum("Введите координату Y для первой точки:");
int bX = GetNum("Введите координату X для второй точки:");
int bY = GetNum("Введите координату Y для второй точки:");


Console.WriteLine(Distance(aX,aY,bX,bY));