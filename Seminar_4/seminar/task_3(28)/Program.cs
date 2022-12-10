// Задача 28: Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.Clear();
Console.Write("Введите число N: ");
int num = int.Parse(Console.ReadLine());

int FactNumbers(int N)
{
    int fact = 1;

    for (int i = 1; i <= N; i++)
    {
        fact *= i;
    }
    return fact;
}
Console.WriteLine($"Произведение чисел от 1 до N: {FactNumbers(num)}");
