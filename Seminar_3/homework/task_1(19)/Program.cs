// Задача 19
// Напишите программу,
// которая принимает на вход 
// пятизначное число и проверяет,
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число...");
int numb = int.Parse(Console.ReadLine()!);
if (numb / 10000 == 0)
{
    while (numb / 1000 == 0)
    {
        Console.WriteLine($"Число {numb} не является пятизначным, введите пятизначное число...");
        numb = int.Parse(Console.ReadLine()!);
    }
        
}

if ((numb / 10000 == numb % 10) && (numb / 1000 % 10 == numb / 1000 % 10))
{
    Console.WriteLine($"Число {numb} является палиндромом");
}
else
{
    Console.WriteLine($"Число {numb} не является палиндромом");
}

