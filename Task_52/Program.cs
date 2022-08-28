// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
    }
}

int[,] CreateArrayWithRandomNumbers(int m, int n)
{
    int[,] result = new int[m,n];
    var random= new Random();
    for (var i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = random.Next(1,10);
        }
    }
     return result;
}

void AverageArithmeticNumbers(int[,]array)
{
    for (var j = 0; j < array.GetLength(1); j++)
    {
       double sum = 0; 
       for (var i = 0; i < array.GetLength(0);i++)
       {
        sum += array[i,j];
       }
       sum = sum/array.GetLength(0);
    //return sum;
    Console.WriteLine("Среднее арифметическое столбца " + j + " - " + $"{sum.ToString("N2")}   ");
    }
}    

Console.WriteLine("Введите число строк m");
if (!int.TryParse(Console.ReadLine()!, out var m))
{
    Console.WriteLine("Все плохо");
}

Console.WriteLine("Введите число строк n");
if (!int.TryParse(Console.ReadLine()!, out var n))
{
    Console.WriteLine("Все плохо");
}

var array = CreateArrayWithRandomNumbers(m,n);

PrintArray(array);

AverageArithmeticNumbers(array);
