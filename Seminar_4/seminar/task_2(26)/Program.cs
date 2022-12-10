// Задача 26: Напишите программу, которая принимает 
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int CountNumbers(int number)
{
    int count = 0;

    while(number>0)
    {
        count++;
        number/=10; 
    }
    return count;
}
Console.WriteLine($"Количество цифр в числе: {CountNumbers(num)}");