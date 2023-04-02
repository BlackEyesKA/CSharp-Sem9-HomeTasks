// Задача 64: Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string OutputNumber(int Number)
{
    if (Number == 1) 
        return 1.ToString();
    return Number.ToString() + ", " + OutputNumber(Number - 1);
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.Write(OutputNumber(number));