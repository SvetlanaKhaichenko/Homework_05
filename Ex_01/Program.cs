// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] RandomMas()
{
    int[] mas = new int[6];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(100, 1000);
    }
    return mas;
}

int EvenNumbers(int[] randmas)
{
    int res = 0;
    for (int i = 0; i < randmas.Length; i++)
    {
        if (randmas[i] % 2 == 0)
            res = res + 1;
    }
    return res;
}

void PrintRandomMas (int []mas)
{
    for(int i = 0; i<mas.Length; i++)
    {
        Console.Write($"{mas[i]} ");
    }
}

int [] randm = RandomMas();
PrintRandomMas (randm);
Console.WriteLine();
Console.WriteLine(EvenNumbers(randm));