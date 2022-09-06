// // Написать программу, которая в двумерном массиве заменяет строки на столбцы
// или сообщить, что это невозможно (в случае, если матрица не квадратная).
Console.Clear();

int[,] array = new int[5, 5];

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

for (int i = 0; i < array.GetLength(1); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[j, i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();

int[,] mass = new int[array.GetLength(0), array.GetLength(1)];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = array[j, i];
        Console.WriteLine(mass[i, j]);
    }
    Console.WriteLine();
}