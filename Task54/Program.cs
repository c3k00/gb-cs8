﻿// Задача 54: Задайте двумерный массив. Напишите программу,
//  которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetArray2d()
{
    int m = Prompt("Введите значение m");
    int n = Prompt("Введите значение n");
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray2d(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SortToLower(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            for (int k = 0; k < array2d.GetLength(1) - 1; k++)
            {
                if (array2d[i, k] < array2d[i, k + 1])
                {
                    int temp = array2d[i, k + 1];
                    array2d[i, k + 1] = array2d[i, k];
                    array2d[i, k] = temp;
                }
            }
        }
    }
}

int[,] array2d = GetArray2d();
PrintArray2d(array2d);
Console.WriteLine();
SortToLower(array2d);
Console.WriteLine();
PrintArray2d(array2d);