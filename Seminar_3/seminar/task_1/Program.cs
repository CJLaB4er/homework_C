// // Задача №17. Напишите программу,
// которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
// в которой находится эта точка.

Console.WriteLine("Введите координату 'X'");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату 'Y'");
int y = int.Parse(Console.ReadLine()!);
if (x > 0)
{
    if (y > 0) Console.WriteLine("Первая четверть!");
    else Console.WriteLine("Четвёртая четверть!");
}
else
{
    if (y > 0) Console.WriteLine("Вторая четверть!");
    else Console.WriteLine("Третья четверть!");
}
