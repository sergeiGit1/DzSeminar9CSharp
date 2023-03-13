// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());

int GetSum(int numM, int numN)
{
    if (numM > numN) return 0;
    return (numM + GetSum(numM + 1, numN));
}
Console.WriteLine("Сумма элементов от  M до N: " + GetSum(numberM, numberN));