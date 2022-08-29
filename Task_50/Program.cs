//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

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
            result[i,j] = random.Next(1,100);
        }
    }
     return result;
}

void SearchNumber(int[,]array, int i, int j, int m, int n)
{
    if (i < m && j < n)
    {
        Console.WriteLine("Число с заданными индексами: " + array[i,j]);
    }
    else
    {
        Console.WriteLine("Числа с заданными индексами [" + i + ";" + j + "] в массиве нет");
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

Console.WriteLine("Введите индекс числа: i");
if (!int.TryParse(Console.ReadLine()!, out var i))
{
    Console.WriteLine("Все плохо");
}

Console.WriteLine("Введите индекс числа: j");
if (!int.TryParse(Console.ReadLine()!, out var j))
{
    Console.WriteLine("Все плохо");
}

var array = CreateArrayWithRandomNumbers(m,n);

PrintArray(array);

SearchNumber(array, i, j, m ,n);