// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
int a = int.Parse(Console.ReadLine() ?? "0");

int[,] mass = new int[5, 5];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 5);
        Console.Write($" {mass[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (mass[i, j] == a)
        {
            int b = i; int c = j;
            Console.Write($"{b},{c} ");
            return;
        }
    }
}
Console.WriteLine("Такого числа нет ");