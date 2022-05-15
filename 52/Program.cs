// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] newArray = GetRandomArray(5, 5, 1, 10);
PrintArray(newArray);
Console.WriteLine(MiddleColumns(newArray));


int[,] GetRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

double MiddleColumns(int[,] array)
{
    double sum = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        sum = 0;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            sum += array[i, j];
        }
        sum = sum / array.GetLength(0);
        Console.Write($"{sum} // ");
    }
    return sum;
}