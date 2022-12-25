// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
Console.Clear();

void CountNumberMoreZero()
{
    int count = 0;
    Console.WriteLine("Введите количество чисел для проверки...");
    int cycleLimit = int.Parse(Console.ReadLine()!);
    for (int i = 0; i < cycleLimit; i++)
    {
        Console.WriteLine("Введите число...");
        if (int.Parse(Console.ReadLine()!) > 0) count++;
    }
    Console.WriteLine($"Из введённых вами чисел, {count} являются больше нуля.");
}
CountNumberMoreZero();