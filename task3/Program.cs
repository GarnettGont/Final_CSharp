// Задайте произвольный массив. Выведите его элементы начиная с конца.

using System;
using System.Globalization;
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] array, int i)
{
    if (i < array.Length)
    {
        Console.Write(array[i] + " ");
        PrintArray(array, i + 1);
    }
}

void PrintReverseArray(int[] array, int i)
{
    if (i >= 0)
    {
        Console.Write(array[i] + " ");
        PrintReverseArray(array, i - 1);
    }
}


Console.Write("Write minimum limit: ");
int numMin = Convert.ToInt32(Console.ReadLine()); ;
Console.Write("Write maximum limit: ");
int numMax = Convert.ToInt32(Console.ReadLine());
Console.Write("Write array size: ");
int arrSize = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArrayRndInt(arrSize, numMin, numMax);
Console.Write("Your not reverce array: ");
PrintArray(arr, 0);
Console.WriteLine("");
Console.Write("New reverce array:\t");
PrintReverseArray(arr, arrSize - 1);