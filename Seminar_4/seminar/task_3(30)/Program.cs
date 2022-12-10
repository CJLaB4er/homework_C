// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Clear();
int[] array = new int[8];

void WriteArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != arr.Length-1)
        {
            Console.Write($"{arr[i]}, ");
        }
        else
        {
            Console.Write($"{arr[i]}");
        }    
    }
    Console.Write("]");
}

int[] RandomArray(int[] arr)
{
    int i = 0;
    while (i < arr.Length)
    {
        arr[i] = new Random().Next(0, 2);
        i++;
    }
    return arr;
}

// WriteArray(array);

int[] fullArray = RandomArray(array);

Console.WriteLine();

WriteArray(fullArray);