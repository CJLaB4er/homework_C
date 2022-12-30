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
    int m = -1;
    int n = -1;

    while (m == n)
    {
        Console.WriteLine("Создаем массив размерностью m x n...");
        Console.WriteLine("Введите число строк массива...");
        m = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите число столбцов массива...");
        n = int.Parse(Console.ReadLine()!);
        if (m == n)
        {
            Console.Clear();
            Console.WriteLine("Недопустимый ввод, m не должно быть равно n!");
        }
        else Console.Clear();
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

void CheckRowInArray(int[,] array)
{
    int index = -1;
    int sum = 1000;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int tempsum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempsum += array[i, j];
            
        }
        if (tempsum < sum)
            {
                sum = tempsum;
                index = i;
            }


    }
    Console.WriteLine($"Наименьшая сумма элементов у строки под номером {index + 1} - {sum}.");
}

int[,] arr = CreateArrayMN();
PrintArray(arr);
CheckRowInArray(arr);