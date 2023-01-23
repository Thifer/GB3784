/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.

домашнее задание к третьему семинару:

опровергнуть гипотезу эйлера для формулы a^5 + b^5 + c^5 + d^5 = e^5
Найдите пять первых чисел соответствующих формуле.
задача считается не выполненной если программа работает более 5 секунд.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4*/

void Pow(int num)
{
    string temp = string.Empty;
    for (int i = 1; i <= num; i++)
    {
        temp += i * i+", ";
    }
    Console.Write(temp.Remove(temp.Length-2));
}

int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

int num = GetNum("Введите число:");



Pow(num);