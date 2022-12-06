
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.Clear();
// Console.WriteLine("Введите число N: ");
// int N = int.Parse(Console.ReadLine()!);
// int i = 1;
// while (i <= N)
// {
//     Console.Write($"{i * i}, ");
//     i++;
// }
// Console.Write("Расчет окончен");

Console.Clear();
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
int[] array = new int[N];
int i = 0;
while (i < N)
{
    array[i] = new Random().Next(1, 10);
    Console.Write($"{array[i]}^2 = ");
    Console.WriteLine($"{array[i] * array[i]}, ");
    i++;
}

// Console.WriteLine (size);
// Console.Write (array[4]);