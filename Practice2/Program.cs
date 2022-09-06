//Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
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

for (int i = 0; i < array.GetLength(0); i++)
{
    double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[j, i];
       
    }
     sum = sum / array.GetLength(1);
    Console.Write("{0,6:F2}", sum);
}