// Задача 18
// Напишите программу, 
// которая по заданному номеру четверти, 
// показывает диапазон возможных координат 
// точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти от 1 до 4");
int numb = int.Parse(Console.ReadLine()!);
if (numb == 1) Console.WriteLine("x>0; y>0");
if (numb == 2) Console.WriteLine("x<1; y>1");
if (numb == 3) Console.WriteLine("x<1; y<1");
if (numb == 4) Console.WriteLine("x>1; y<1");