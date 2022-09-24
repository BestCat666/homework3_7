// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
double[,] array = GetArray(rows, columns, 2, 30);
PrintArray(array);
Console.WriteLine();
double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
double ColumsNumAverage(double[,] intArray)
{
    double ColumsNumAverage = 0;
    double  sum = 0;
    int m = intArray.GetLength(0);
    int n = intArray.GetLength(1);
    for (int j = 0; j < n; j++)
    {
    sum = 0;
     for (int i = 0; i< n; i++)
     {
     sum = sum + intArray[i, j];
     if (i == m - 1)
    ColumsNumAverage = Math.Round(sum / m , 2);
    //Console.WriteLine($"{ColumsNumAverage}");
    }
    } 
    return ColumsNumAverage;
}
Console.Write($"{ColumsNumAverage(array)}");

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}