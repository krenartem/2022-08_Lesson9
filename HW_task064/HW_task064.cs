// Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
int ShowNaturalNumbers(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else
    {
        Console.Write(m + ", ");
        return ShowNaturalNumbers(m + 1, n);
    }
}

Console.Clear();
Console.Write("Введите минимальное значение M: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение N: ");
int max = int.Parse(Console.ReadLine());
Console.WriteLine("Натуральные числа в промежутке от M до N:");
Console.WriteLine($"{ShowNaturalNumbers(min,max)}");