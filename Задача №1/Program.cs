// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] arr = FillMas(10, 100, 1000);
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

int EvenNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count += 1;
    }
    return count;
}
int countN = EvenNum(arr);
Console.WriteLine();
Console.WriteLine($"{countN} чётных чисел в массиве.");