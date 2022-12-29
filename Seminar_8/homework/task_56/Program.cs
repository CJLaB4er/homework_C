// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

int[,] CreateArrayMN()
{
    Console.WriteLine("Создаем массив размерностью m x n...");
    Console.WriteLine("Введите число строк массива...");
    int m = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите число столбцов массива...");
    int n = int.Parse(Console.ReadLine()!);
    

    if (m == n) 
    {
        Console.WriteLine();
        Console.WriteLine("Массив не является прямоугольным!");
        Console.WriteLine("Попробуем снова...");
        Console.WriteLine();
        CreateArrayMN();
    }

    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}
    


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] >= 0) Console.Write($" {array[i, j]} ");
            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine("");
    }
}

PrintArray(CreateArrayMN());