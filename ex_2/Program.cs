//Задача 50. Напишите программу, которая на вход принимает позиции 
//элемента в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//[1, 7] -> такого числа в массиве нет
Console.WriteLine("Введите позицию строки(x): ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите позицию столбца(y): ");
int y = int.Parse(Console.ReadLine());
int rows = 4; // кол-во строк
int colums = 4; // кол-во столбцов
int[,] array = GetArray(rows, colums, 10,20);
int[,] GetArray(int m,int n, int minValue,int maxValue)
{
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue,maxValue + 1); 
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
     for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
           Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
PrintArray(array);
void NumPosition(int[,] Array3)
{
    int m = Array3.GetLength(0);
    int n = Array3.GetLength(1);

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i==x && j==y)
            {
            Console.Write($"Число с такой позицией есть в массиве[{i},{j}] --> {Array3[i,j]}");
            }
            else
            {
            Console.Write($"Числа с такой позицией нет в массиве[{i},{j}]");
            }
            }
        }
    }
NumPosition(array);





//int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 }};
 //int rows = numbers.GetUpperBound(0) + 1;    // количество строк
//int columns = numbers.Length / rows;        // количество столбцов
// или так
// int columns = numbers.GetUpperBound(1) + 1;
 
//for (int i = 0; i < rows; i++)
//{
 //   for (int j = 0; j < columns; j++)
 //   {
 //       Console.Write($"{numbers[i, j]} \t");
//   }
 //   Console.WriteLine();
//}
// Console.Write($"{array[0, 1]} ");
