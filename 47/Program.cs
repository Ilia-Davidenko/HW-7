// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Clear();

double[,] result = new double[5, 5];
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        result[i, j] = new Random().NextDouble() * new Random().Next(-10,10);
        Console.Write("{0,5:F1} ", result[i, j]);
    }
    Console.WriteLine();
}