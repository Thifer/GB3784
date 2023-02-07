int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

string CheckQuarter(int x) => x == 1  ? "Х > 0,Y > 0" :
    x == 2 ? "X < 0, Y > 0" :
    x == 3 ? "X < 0, Y < 0" : x == 4 ? "X > 0, Y < 0" : "Что-то пошло не так";

int quarter = GetNum("Введите номер четверти:");


Console.WriteLine(CheckQuarter(quarter));