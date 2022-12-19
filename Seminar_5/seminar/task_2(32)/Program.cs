// Задача 32: Напишите программу замена элементов массива:
// положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

Console.Clear();
Console.WriteLine("Введите количество элементов массива...");

int[] array = new int[int.Parse(Console.ReadLine()!)];

int[] FillArray(int[] arr)
{
    Console.Write($"Исходный массив выглядит так: ");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9, 10);
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
    return arr;
}

int[] ReverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write($"После смены знаков массив выглядит так: ");

    for (int i = 0; i< arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
array = FillArray(array);
array = ReverseArray(array);
PrintArray(array);