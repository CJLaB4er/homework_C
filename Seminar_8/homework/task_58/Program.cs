// Задача 58: Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void MultiplicationArray(int[,] arr1, int[,] arr2)
{
    if (arr1.GetLength(1) != arr2.GetLength(0))
    {
        Console.WriteLine("Количество столбцов матрицы один не равно количеству строк матрицы два. Произведение недопустимо!");
    }
    else
    {
        int[,] tempArray = new int[arr1.GetLength(0), arr2.GetLength(1)];
        for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    for (int k = 0; k < arr2.GetLength(0); k++)
                    {
                        tempArray[i,j] += arr1[i,k] * arr2[k,j];
                    }
                }
            }
            PrintArray(tempArray);
    }
    
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
Console.Clear();
int [,] matrix_1 = CreateArrayMN();
int [,] matrix_2 = CreateArrayMN();
PrintArray(matrix_1);
Console.WriteLine();
PrintArray(matrix_2);
Console.WriteLine();
MultiplicationArray(matrix_1, matrix_2);