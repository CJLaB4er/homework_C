// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, colums, -10, 10);
PrintArray(array);
Console.WriteLine();
ChangeArray(array);
PrintArray(array);
