// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// Доп условие семинара - выводить только четные числа

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

Console.WriteLine("Введите значение N...");

int n = int.Parse(Console.ReadLine()!);

Console.Clear();

Console.WriteLine($"Вывод всех чисел от N до 1...");

Console.Write($"N = {n} -> ");

void WriteNumb(int n)
{
    if (n == 1)
    {
        Console.Write("1");
    }
    else
    {
        Console.Write($"{n} ");
        WriteNumb(n - 1);
    }

}

Console.Write($"N = {n} -> ");

void WriteEvenNumb(int n)
{
    if (n == 2)
    {
        Console.Write("2");
    }
    else
    {
        if (n % 2 != 0)
        {
            WriteEvenNumb(n - 1);
        }
        else
        {
            Console.Write($"{n} ");
            WriteEvenNumb(n - 2);
        }

    }

}

WriteNumb(n);

Console.WriteLine();

Console.WriteLine($"Вывод всех чётных чисел от N до 2...");

Console.Write($"N = {n} -> ");

WriteEvenNumb(n);