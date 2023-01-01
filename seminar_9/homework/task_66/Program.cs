// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.WriteLine("Введите значение M...");

int m = int.Parse(Console.ReadLine()!);

Console.Clear();

Console.WriteLine("Введите значение N...");

int n = int.Parse(Console.ReadLine()!);

Console.Clear();

int SumIntervalNumb(int m, int n)
{
    if (m != n)
    {
        return m + SumIntervalNumb(m + 1, n);
    }
    else
    {
        return m;
    }
}

Console.Write($"M = {m}; N = {n} -> ");

Console.WriteLine(SumIntervalNumb(m, n));
