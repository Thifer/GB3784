using static System.Console;

Write("Введите номер дня: ");
int numA = Int32.Parse(ReadLine());
WriteLine(numA>7?"Это не номер дня недели":numA<6?"это не выходной":"Это выходной");