//Написать программу, которая обменивает элементы первой строки и последней строки
Console.Clear();
int[,] array = new int[3, 3];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($" {array[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();

int s = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    s = array[array.GetLength(0) - 1, i];
    array[array.GetLength(0) - 1, i] = array[0, i];
    array[0, i] = s;
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($" {array[i, j]} ");
    }
    Console.WriteLine();
}