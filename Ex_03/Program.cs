// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
double[] RandomMas()
{
    double[] mas = new double[6];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(-1000, 1001);
    }
    return mas;
}

double DifferencMaxMin(double[] mas)
{
    double max = mas[0];
    double min = mas[0];
    double result = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (max < mas[i]) max = mas[i];
    }
    for (int j = 0; j < mas.Length; j++)
    {
        if (min > mas[j]) min = mas[j];
    }
    if (min < 0) min = min * (-1);

    return result = max - min;
}


void PrintRandomMas(double[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.Write($"{mas[i]} ");
    }
}

double[] mass = RandomMas();
PrintRandomMas(mass);
Console.WriteLine();
System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна = {DifferencMaxMin(mass)}");