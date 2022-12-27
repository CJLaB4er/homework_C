// Задача 50. Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

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
            array[i, j] = new Random().Next(-9, 10);
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

void CheckNumberInArray(int[,] array)
{
    Console.WriteLine("Введите номер необходимого числа...");
    int findNumb = int.Parse(Console.ReadLine()!);
    int count = 1;
    bool flag = false;
    if (findNumb > array.GetLength(0) * array.GetLength(1) || findNumb <= 0)
    {
        Console.WriteLine($"В массиве нет элемента под номером {findNumb}!");
    }
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (flag == true) break;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (count == findNumb)
                {
                    Console.WriteLine($"Число №{findNumb} : {array[i,j]}");
                    flag = true;
                    break;
                }
                count++;
            }
        }
    }

}
int[,] newArr = CreateArrayMN();
PrintArray(newArr);
CheckNumberInArray(newArr);
