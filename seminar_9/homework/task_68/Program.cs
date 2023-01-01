// Задача 68: Напишите программу вычисления
// функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Clear();

Console.WriteLine("Введите значение M...");

int m = int.Parse(Console.ReadLine()!);

Console.Clear();

Console.WriteLine("Введите значение N...");

int n = int.Parse(Console.ReadLine()!);

Console.Clear();

int Accermann(int m, int n)
{
    if (m == 0) return n + 1;
    else
    {
        if (m != 0 && n == 0)
        {
            return Accermann(m - 1, 1);
        }
        else
        {
            return Accermann(m - 1, Accermann(m, n - 1));
        }
    }
}

Console.WriteLine(Accermann(m, n));