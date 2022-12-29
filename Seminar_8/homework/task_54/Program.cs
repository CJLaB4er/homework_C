// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

int[,] CreateArrayMN()
{
    Console.WriteLine("Создаем массив размерностью m x n...");
    Console.WriteLine("Введите число строк массива...");
    int m = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите число столбцов массива...");
    int n = int.Parse(Console.ReadLine()!);
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

int[,] SortArray(int[,] array)
{
    int tempnumb = 0; // временная переменная для перестановки элементов массива
    
    // Цикл для прохода по строкам массива
    for (int row = 0; row < array.GetLength(0); row++)
    {

        // Цикл для прохождения по элементам строки столько раз,
        // сколько в нем элементов минус один.
        for (int i = 0; i < array.GetLength(1) - 1; i++)
        {

            // Сортировка пузырьком.
            for (int column = 0; column < array.GetLength(1) - 1; column++)
            {
                if (array[row, column] < array[row, column + 1])
                {
                    tempnumb = array[row, column];
                    array[row, column] = array[row, column + 1];
                    array[row, column + 1] = tempnumb;
                }
            }
        }
    }
    return array;
}

int[,] arr = CreateArrayMN();
Console.WriteLine("Случайно сгенерированный двумерный массив выглядит так:");
PrintArray(arr);
Console.WriteLine();
Console.WriteLine("А вот так он выглядит после сортировки строк по убыванию:");
arr = SortArray(arr);
PrintArray(arr);

