// Задача 25: Напишите цикл,
// который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Clear();

double PowNumber(double A, double B)
{
    return Math.Pow(A, B);
}

Console.WriteLine("Введите число А...");

double numbA = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число В...");

double numbB = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Число {numbA} в степени {numbB} равно: {PowNumber(numbA, numbB)}");


