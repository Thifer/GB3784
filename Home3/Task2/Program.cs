/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

    A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

float Distance(int ax, int ay,int az, int bx, int by,int bz) => (float)Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2)+Math.Pow(bz - az, 2));

int aX = GetNum("Введите координату X для первой точки:");
int aY = GetNum("Введите координату Y для первой точки:");
int aZ = GetNum("Введите координату Z для первой точки:");
int bX = GetNum("Введите координату Y для второй точки:");
int bY = GetNum("Введите координату X для второй точки:");
int bZ = GetNum("Введите координату Z для второй точки:");


Console.WriteLine(Distance(aX,aY,aZ,bX,bY,bZ));