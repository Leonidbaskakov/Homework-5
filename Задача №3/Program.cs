// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
Double[] arr = FillMas(5);
PrintMas(arr);

Double[] FillMas(int n)
{
    Double[] array = new Double[n];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (rnd.NextDouble()) * 10;
    }
    return array;
}

void PrintMas(Double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + " ");
    }
    Console.Write($"{array[array.Length - 1]}]");
}

Double[] MaxMinNum(Double[] array)
{
    Double max = array[0];
    Double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    return new Double[] {max,min};
}

Double[] MaxMinNumb = MaxMinNum(arr);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Max {Math.Round(MaxMinNumb[0],2)}");
Console.WriteLine($"Min {Math.Round(MaxMinNumb[1],2)}");



