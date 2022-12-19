// Задача 34: Задайте массив заполненный
// случайными положительными трёхзначными
// числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();

int[] GetArray()
{
    int[] newArray = new int[3];
    Console.Write($"Массив [");
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().Next(1, 100);
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