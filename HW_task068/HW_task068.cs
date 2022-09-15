// Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
int CalculateAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return CalculateAkkerman(m - 1, 1);
    }
    else
    {
        return CalculateAkkerman(m - 1, CalculateAkkerman(m, n - 1));
    }
}

Console.Clear();
Console.Write("Введите неотрицательное значение M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите неотрицательное значение N: ");
int N = int.Parse(Console.ReadLine());
Console.Write("A(m,n) = ");
Console.WriteLine($"{CalculateAkkerman(M, N)}");