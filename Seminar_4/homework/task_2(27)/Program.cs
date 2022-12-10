// Задача 27: Напишите программу,
// которая принимает на вход число
// и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Clear();

int PrintSumNumb(int numb)
{
    int sum = 0;
    while (numb > 0)
    {
        sum += numb % 10;
        numb /= 10;
        // Console.WriteLine(numb);
    }
    return sum;
}

Console.WriteLine("Введите число...");
Console.WriteLine($"{PrintSumNumb(int.Parse(Console.ReadLine()!))}");
