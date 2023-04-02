// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int OutPutNumber(int number1, int number2)
{
    if (number1 == number2)
        return number1;
    int Summa = 0;
    for(int i = number1; i <= number2; i++)
        Summa += i; 
    return Summa;
}

Console.Write("Введите 2 числа : ");
int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.Write(OutPutNumber(numbers[0], numbers[1]));