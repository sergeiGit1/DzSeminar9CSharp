// Задача 64: Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите значение N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int numberOne = 1;

string GetArray(int start, int one)
{
    if (start == 1) return one.ToString();
    return (start + "," + GetArray(start - 1, one));
}

Console.WriteLine("Натуральные числа в промежутке от N до 1:");
Console.WriteLine(GetArray(numberN, numberOne));