// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.Clear();

int[,] startArray = GetRandomArray(5, 5, 0, 10);
PrintArray(startArray);
//Console.WriteLine(SearchNumber(startArray, 3));

Console.WriteLine("Введите число для поиска");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < startArray.GetLength(0); i++)
    {
        for (int j = 0; j < startArray.GetLength(1); j++)
        {
            if (startArray[i, j] == number)
            {
                Console.WriteLine($"{number} находится в строке {i} столбце {j}");
            }
//            else Console.WriteLine($"{number} отсутствует в массиве");
        }
    }


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

// int SearchNumber(int[,] array, int number)
// {
//     int match = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] == number)
//             {
//                 match = array[i, j];
//                 Console.WriteLine($"{number} находится в строке {i} столбце {j}");
//             }
//         }
//     }
//     return match;
// }