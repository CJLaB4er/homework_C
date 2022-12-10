// Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов 
// и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

Console.WriteLine("Введите количество элементов массива...");



int[] CreateArray(int numb)
{
    int[] array = new int[numb];
    int i = 0;
    while (i < array.Length)
    {
        array[i] = new Random().Next(0, 100);
        i++;
    }
    return array;
}

void PrintArray(int[] arr)
{
    int i = 0;
    Console.Write("[");
    while (i < arr.Length)

    {
        if (i == arr.Length - 1)
        {
            Console.Write($"{arr[i]}");
        }
        else
        {
            Console.Write($"{arr[i]}, ");
        }
        i++;
    }
    Console.Write("]");
}
PrintArray(CreateArray(int.Parse(Console.ReadLine()!)));