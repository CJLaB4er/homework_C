// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();


Console.WriteLine("Введите количество элементов массива...");

int size = int.Parse(Console.ReadLine()!);

int minValue = 100;
int maxValue = 0;

void GetCheckArray()
{
    int[] newArray = new int[size];
    Console.Write($"В массиве [");
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(1, 100);
        if (newArray[i] > maxValue) maxValue = newArray[i];
        if (newArray[i] < minValue) minValue = newArray[i];
        if (i != newArray.Length - 1) Console.Write($"{newArray[i]}, ");
        else Console.Write($"{newArray[i]}");
    }
    Console.Write($"], разность между максимальным элементо {maxValue} и минимальным элементом {minValue}, составляет {maxValue - minValue}.");

}
GetCheckArray();