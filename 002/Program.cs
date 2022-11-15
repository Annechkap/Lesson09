// 2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30

int Prompt(string msg)
{
    Console.Write(msg + " > ");
    return int.Parse(Console.ReadLine());
}

int PrintNumbers(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    return n + PrintNumbers(m, n - 1);
}

int m = Prompt("Введите число m");
int n = Prompt("Введите число n");
int resault = PrintNumbers(m, n);
Console.WriteLine(resault);