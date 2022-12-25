// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] GetArray(int m, int n, int 
void PrintArray(int[,] inArray)
void ChangeArray(int[,] array)
{
    int count = 0;
    Console.Write("Сумма элементов главной диагонали: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
От Вячеслав всем 09:37 PM
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, colums, 1, 10);
PrintArray(array);
Console.WriteLine();
ChangeArray(array);
