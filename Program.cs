﻿// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц

int[,] GetInt2dArray(int rows, int columns)
{
    int[,] Random2dArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Random2dArray[i, j] = new Random().Next(1, 6);
        }
    }
    return Random2dArray;
}

void Print2dArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplyMatrix(int[,] firstArray, int[,] secondArray)
{
    int[,] resultArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
    if (firstArray.GetLength(0) != secondArray.GetLength(1))
    {
        Console.WriteLine("Эти матрицы нельзя перемножить");
        return new int[0, 0]; 
    }
    for (int row = 0; row < resultArray.GetLength(0); row++)
    {
        for (int column = 0; column < resultArray.GetLength(1); column++)
        {
            int sum = 0;
            for (int i = 0; i < firstArray.GetLength(1); i++)
            {
                sum += firstArray[row, i] * secondArray[i, column];
            }
            resultArray[row, column] = sum;
        }
    }
    Console.WriteLine("Результат:");
    return resultArray;
}


Console.Clear();
Console.Write("Введите количество строк в первом массиве: ");
int rows1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в первом массиве: ");
int columns1 = int.Parse(Console.ReadLine()!);
int[,] firstArray = GetInt2dArray(rows1, columns1);
Console.Write("Введите количество строк во втором массиве: ");
int rows2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов во втором массиве: ");
int columns2 = int.Parse(Console.ReadLine()!);
int[,] secondArray = GetInt2dArray(rows2, columns2);

Print2dArray(firstArray);
Console.WriteLine();
Print2dArray(secondArray);

Console.WriteLine();
Print2dArray(MultiplyMatrix(firstArray, secondArray));