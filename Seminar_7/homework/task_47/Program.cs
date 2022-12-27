// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.Clear();

double[,] CreateArrayMN()
{
    Console.WriteLine("Создаем массив размерностью m x n...");
    Console.WriteLine("Введите число строк массива...");
    int m = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите число столбцов массива...");
    int n = int.Parse(Console.ReadLine()!);
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            // В строчке ниже весь смысл задания - 
            // метод NextDouble возвращает псевдослучайное число от 0,0 до 1,0
            // поэтому домножаем его на псевдослучайное число от -10 до 10
            // и округляем результат до двух знаков после запятой.
            array[i, j] = Math.Round(new Random().NextDouble() * new Random().Next(-10,11), 2);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > 0) Console.Write($" {array[i, j]} ");
            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
PrintArray(CreateArrayMN());


