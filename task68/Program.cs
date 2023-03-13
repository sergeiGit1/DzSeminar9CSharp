// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("Введите M:");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите N:");
int numberN = Convert.ToInt32(Console.ReadLine());

int GetAkkerman(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberN == 0) return GetAkkerman(numberM - 1, 1);
    return GetAkkerman(numberM - 1, GetAkkerman(numberM, numberN - 1));
}

Console.WriteLine(GetAkkerman(numberM, numberN));