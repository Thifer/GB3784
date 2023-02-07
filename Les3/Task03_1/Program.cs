//Напишите программу, которая принимает на вход координаты точки(X и Y)
//причем X != 0 и Y != 0 и выдает номер четверти плоскости, в которой находится эта точка.

int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

string CheckQuater(int x, int y) => x > 0 & y > 0 ? "1 четверть" :
    x < 0 & y > 0 ? "2 четверть" :
    x < 0 & y < 0 ? "3 четверть" : "4 четверть";

int pointX = GetNum("Введите значение X:");
int pointY = GetNum("Введите значение Y:");


Console.WriteLine(CheckQuater(pointX,pointY));
 