// Задача 47. Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     double[,] array = new double[rows, columns];
    
//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i,j] = new Random().NextDouble() + new Random().Next(minValue, maxValue + 1);
//     return array;
// }

// void Show2dArray(double[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(Math.Round(array[i,j], 1) + " ");

//         Console.WriteLine();
    
//     }   
//     Console.WriteLine();
// }

// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// double[,] myArray = CreateRandom2dArray(m, n, min, max);
// Show2dArray(myArray);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет


int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    
    }   
    Console.WriteLine();
}

// bool ElementExistence(int[,] array, int horizontal, int vertical)
// {
//     if(horizontal < array.GetLength(0) && vertical < array.GetLength(1))
//     return true;
//     else
//     return false;
     
// }

// int ShowElement(int[,] array, int horizontal, int vertical)
// {
//     int result = array[horizontal, vertical];
//     return result;
// }


// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(m, n, min, max);
// Show2dArray(myArray);

// Console.Write("Input a serial number in a row: ");
// int h = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a serial number in a column: ");
// int v = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(ElementExistence(myArray, h, v));

// if(ElementExistence(myArray, h, v) == true)
// Console.WriteLine(ShowElement(myArray, h, v));
// else
// Console.WriteLine();




// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


double[] ArithmeticMeanColumn(int[,] array2d)
{
    double[] array1d = new double[array2d.GetLength(1)];
    for(int j = 0; j < array2d.GetLength(1); j++)
    {
        double sum = 0;
        for(int i = 0; i < array2d.GetLength(0); i++)
          {
            sum += array2d[i,j];
          } 
        array1d[j] = sum / array2d.GetLength(0); 
    
    }
    return array1d;
}

void Show1dArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(Math.Round(array[i], 3) + "|"); // Вывод  массива на экран
    Console.WriteLine();
}


Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);

double[] myArray1d = ArithmeticMeanColumn(myArray);
Show1dArray(myArray1d);
