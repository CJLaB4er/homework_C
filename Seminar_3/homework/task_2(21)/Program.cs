// Задача 21

// Напишите программу,
// которая принимает на вход координаты
// двух точек и находит расстояние между
// ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.WriteLine("Введите координату X первой точки...");
int Xa = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Y первой точки...");
int Ya = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Z первой точки...");
int Za = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату X второй точки...");
int Xb = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Y второй точки...");
int Yb = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Z второй точки...");
int Zb = int.Parse(Console.ReadLine()!);

// Формула нахождения расстояния между двумя точками в трёхмерном пространстве:
// √((xb-xa)^2+(yb-ya)^2+(zb-za)^2)

double length = Math.Sqrt(Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2) + Math.Pow(Zb - Za, 2));
Console.WriteLine($"Длина между точками А и В: {Math.Round(length, 2)} единиц.");