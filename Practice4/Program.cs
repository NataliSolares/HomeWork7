// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
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



for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        for (int n = 0; n < array.GetLength(0) - j - 1; n++)
        {
            if (array[i, j] < array[i, j + 1])
            {
                int x = array[i, j];
                array[i, j] = array[i, j + 1];
                array[i, j + 1] = x;
            }
        }
        Console.Write($" {array[i, j]} ");
    }
    Console.WriteLine();
}
