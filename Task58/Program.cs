// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int m = Prompt("Введите количество строк: ");
int n = Prompt("Введите количество столбцов: ");
Console.WriteLine("матрица 1:");
int[,] array = new int[m, n];
int[,] secondArray = new int[m, n];
int[,] resultArray = new int[m, n];

FillArrayRandom(array);
PrintArray2d(array);

Console.WriteLine("матрица 2:");

FillArrayRandom(secondArray);
PrintArray2d(secondArray);

Console.WriteLine("результат:");

if (array.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}

PrintArray2d(resultArray);


int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandom(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            array2d[i, j] = new Random().Next(1, 4);
        }
    }
}

void PrintArray2d(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write($"{array2d[i, j]}" + "|");
        }
        Console.WriteLine();
    }
}