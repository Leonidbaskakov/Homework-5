// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях (индексах).
int[] arr = FillMas(4, 0, 100);
PrintMas(arr);

int[] FillMas(int n, int min, int max)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

void PrintMas(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + " ");
    }
    Console.Write($"{array[array.Length - 1]}]");
}

int UnEvenNum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum += array[i];
    }
    return sum;
}

int sumuneven = UnEvenNum(arr);
Console.WriteLine();
Console.WriteLine($"{sumuneven} сумма элементов, стоящих на нечётных позициях.");