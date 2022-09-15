// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
int SumNaturalNumbers(int m, int n, int sum)
{
    if (m > n)
    {
        return sum;
    }
    else
    {
        sum = sum + m;
        return SumNaturalNumbers(m + 1, n, sum);
    }
}

Console.Clear();
Console.Write("Введите минимальное значение M: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение N: ");
int max = int.Parse(Console.ReadLine());
Console.Write("Сумма натуральных чисел в промежутке от M до N: ");
Console.WriteLine($"{SumNaturalNumbers(min, max, 0)}");