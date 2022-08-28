// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j].ToString("N2")}   ");
        }
        Console.WriteLine();
    }
}

double[,] CreateArrayWithRealNumbers(int m, int n)
{
    double[,] result = new double[m,n];

    var random = new Random();

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = random.NextDouble()*100;
        }
    }
    return result;
}

Console.WriteLine("Введите число строк m");
if (!int.TryParse(Console.ReadLine()!, out var m))
{
    Console.WriteLine("Всё плохо");
}

Console.WriteLine("Введите число столбцов n");
if (!int.TryParse(Console.ReadLine()!, out var n))
{
    Console.WriteLine("Всё плохо");
}

var result = CreateArrayWithRealNumbers(m,n);
PrintArray(result);