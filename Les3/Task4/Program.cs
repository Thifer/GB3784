/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.

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