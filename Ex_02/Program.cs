// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] RandomMas()
{
    int[] mas = new int[6];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(-1000, 1001);
    }
    return mas;
}

int SumOdd(int[] randmas)
{
    int count = 0;
    for (int i = 1; i < randmas.Length; i = i + 2)
    {
        count = count + randmas[i];
    }
    return count;
}

void PrintRandomMas(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.Write($"{mas[i]} ");
    }
}

int[] desiredArray = RandomMas();
PrintRandomMas(desiredArray);
Console.WriteLine();
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях = {SumOdd(desiredArray)}");