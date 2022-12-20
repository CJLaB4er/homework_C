// Задача 33: Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное
//  число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


Console.Clear(); // Очистка консоли

Console.Write($"Введите число для проверки..."); 

int num = int.Parse(Console.ReadLine()!); // Вводим переменную num - число для проверки
int answ = 0; // эта переменная понадобится в методе проверки ниже

Console.Write($"Введите размер массива...");

int[] array = new int[int.Parse(Console.ReadLine()!)]; // Вводим число элементов массива

int[] FillArray(int[] arr) // метод заполнения массива случайными числами
{
        for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9, 10);
    }
    return arr;
}

void PrintArray(int[] arr) // Метод вывода элементов массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] CheckArray(int[] arr) // метод проверки входит ли число num  в наш массив
{
    
    for (int i = 0; i < arr.Length; i++)
    {
        
        if (arr[i] == num) // если элемент в массиве равен числу num, то переменную answ делаем 1 и завершаем цикл
        {
            answ = 1;
            break;
        }
    }
        if (answ == 1) // если переменная answ=1 то число входит в массив, если иначе то нет
        {
          Console.Write($"Число {num} содержится в массиве ");
        }
        else
        {
        Console.WriteLine($"Число {num} не содержится в массиве ");
        }
    PrintArray(arr); // здесь допечатываем элементы массива для наглядности
    return arr;
}

CheckArray(FillArray(array));
