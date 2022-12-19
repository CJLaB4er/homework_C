// Задача 34: Задайте массив заполненный
// случайными положительными трёхзначными
// числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();

Console.WriteLine("Введите количество элементов массива...");

int size = int.Parse(Console.ReadLine()!);

int[] GetArray()
{
    int[] newArray = new int[size];
    Console.Write($"Массив [");
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().Next(100, 1000);
        if (i != newArray.Length-1) Console.Write($"{newArray[i]}, ");
        else Console.Write($"{newArray[i]}");
    }
    Console.Write($"]");
    return newArray;
}

void checkArray(int[] arr)
{
    int count = 0;
    
    foreach (int el in arr)
    {
        if (el % 2 == 0) count++;
    }
    Console.Write($" имеет количество чётных чисел равное {count}");
}

checkArray(GetArray());