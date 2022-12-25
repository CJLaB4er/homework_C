// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] newarr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newarr[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return newarr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine("");
    }
}

Console.WriteLine("Введите количесто срок...");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количесто колонок...");
int columns = int.Parse(Console.ReadLine()!);

PrintArray(GetArray(rows, columns, -10, 11));





// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4



