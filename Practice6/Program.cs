﻿// В прямоугольной матрице найти строку с наименьшей суммой элементов.
void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}
void FindMinSum(int[,] numbers)
{
    int sum = 0;
int minsum = int.MaxValue;
int indexMinLine = 0;
for (int i = 0; i < numbers.GetLength(0); i++)
{
    sum = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sum = sum + numbers[i, j];
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexMinLine = i + 1;
    }
}
Console.WriteLine($"строка с наименьшей суммой элементов под номером -  {indexMinLine}");

}

int[,] matrix = new int[3, 3];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("");
FindMinSum(matrix);