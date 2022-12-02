﻿// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
Console.WriteLine("Введите число...");
int numb = int.Parse(Console.ReadLine()!); // вводим число
if (numb >= 100) // проверяем, что число имеет не меньше трёх цифр
{
    while (numb > 1000) // пока число имеет больше 3х цифр, отсекаем последнюю в цикле
    {
        numb = numb/10;
    }
    Console.WriteLine(numb%10); // выводим в консоль последнюю цифру трёхзначного числа
}
else
{
    Console.WriteLine($"Число {numb} не имеет третьей цифры.");
}