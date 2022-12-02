// Задача 4: Напишите программу,
// которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear(); // очистка консоли

Console.WriteLine("Введите первое число...");

int max_numb = int.Parse(Console.ReadLine()!); // вводим первое число и назначаем его максимальным

Console.WriteLine("Введите второе число...");

int temp_numb = int.Parse(Console.ReadLine()!); // вводим второе число

if (temp_numb > max_numb) // сравниваем temp_numb и max_numb
{
    max_numb = temp_numb; // если условие верно, то присваиваем max_numb значение temp_numb
}
Console.WriteLine("Введите третье число...");

temp_numb = int.Parse(Console.ReadLine()!);

if (temp_numb > max_numb)
{
    max_numb = temp_numb;
}
Console.WriteLine(max_numb); // вывод в консоль значение переменной max_numb
