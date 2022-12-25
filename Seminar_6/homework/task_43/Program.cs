// Задача 43: Напишите программу,
// которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

// k1* x + b1 = k2 * x + b2;
// (k1 * x) - (k2 * x) = b2 - b1;
// x(k1 - k2) = b2 - b1;
// x = (b2 - b1) / (k1 - k2);

Console.Clear();

void FindX()
{
    Console.WriteLine("Введите координату b1...");
    double b1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите координату k1...");
    double k1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите координату b2...");
    double b2 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите координату k2...");
    double k2 = int.Parse(Console.ReadLine()!);
    double x = (b2 - b1) / (k1 - k2);
    Console.WriteLine($"Две прямые, заданные уравнениями : y = k1 * x + b1, y = k2 * x + b2, пересекутся в точке ({k1 * x + b1} ; {x}).");
}
FindX();