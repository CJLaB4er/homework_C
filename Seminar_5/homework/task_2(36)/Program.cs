// Задача 36: Задайте одномерный массив,
// заполненный случайными числами.
// Найдите сумму элементов,
// стоящих на нечётных позициях.

// // [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Clear();

Console.WriteLine("Введите количество элементов массива...");

int num = int.Parse(Console.ReadLine()!);

int[] GetArray(int size)
{
    int[] newArray = new int[size];
    Console.Write("В массиве [");
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(-99, 100);
        if (i != size - 1) Console.Write($"{newArray[i]}, ");
        else Console.Write($"{newArray[i]}");
    }
    Console.Write("]");
    return newArray;
}

void CheckArray(int[] arr)
{
    int count = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        count += arr[i];
    }
    Console.Write($", сумма элементов на нечётных индексах равна {count}.");
}

CheckArray(GetArray(num));