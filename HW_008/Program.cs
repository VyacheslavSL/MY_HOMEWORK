// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// // элементы каждой строки двумерного массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // В итоге получается вот такой массив:
// // 7 4 2 1
// // 9 5 3 2
// // 8 4 4 2

// int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }

// void Show2dArray(int[,] array)

// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");

//         Console.WriteLine();

//     }
//     Console.WriteLine();
// }

// void DescendingOrder(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k];
//                     array[i, k] = array[i, k + 1];
//                     array[i, k + 1] = temp;
//                 }
//             }
//         }
//     }
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
// DescendingOrder(myArray);
// Show2dArray(myArray);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[] FindSum(int[,] array2d)
// {
//     int[] array1d = new int[array2d.GetLength(0)];
//     for (int i = 0; i < array2d.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array2d.GetLength(1); j++)
//         {
//             sum += array2d[i,j];
//         }
//         array1d[i] = sum;
//     }
//     return array1d;
// }

// int FindRowIndex(int[] array)
// {
//     int indexmin = 0;
//     for (int i = 1; i < array.Length; i++)
//     {
//         if(array[i] < array[indexmin])
//         indexmin = i;
//     }
//     return indexmin;
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

// int result = FindRowIndex(FindSum(myArray));
// Console.Write("Row number with the smallest sum of elements: " + result);

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
// {
//     int[,] arrayMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    
//     for(int i = 0; i < matrix1.GetLength(0); i++)
//     {
//         for(int l = 0; l < matrix2.GetLength(1); l++)
//         {
//             int sum = 0;
//             for(int k = 0; k < matrix1.GetLength(1); k++)
//             {
//                 sum += matrix1[i,k] * matrix2[k,l];
//             }
//             arrayMatrix[i,l] = sum;
//         }
//     }
//     return arrayMatrix;
// }

// Console.Write("Enter the sizes of matrix A and B so that the number of columns of matrix A is equal to the number of rows of matrix B.");
// Console.WriteLine();
// Console.Write("Matrix A (input a number of rows): ");
// int m1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Matrix A (input a number of columns): ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Matrix A (input a min possible value): ");
// int min1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Matrix A (input a max possible value): ");
// int max1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// Console.Write("Matrix B (input a number of rows): ");
// int m2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Matrix B (input a number of columns): ");
// int n2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Matrix B (input a min possible value): ");
// int min2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Matrix B (input a max possible value): ");
// int max2 = Convert.ToInt32(Console.ReadLine());

// int[,] matrixA = CreateRandom2dArray(m1, n1, min1, max1);
// int[,] matrixB = CreateRandom2dArray(m2, n2, min2, max2);

// Show2dArray(matrixA);
// Show2dArray(matrixB);

// if(matrixA.GetLength(1) == matrixB.GetLength(0))
// {
//     Show2dArray(MatrixMultiplication(matrixA, matrixB));
// }
// else
// Console.Write("Matrix multiplication is not allowed (matrices are not compatible)");
// Console.WriteLine();


// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[] ArrayElements(int length, int width, int height)
// {
//     int[] array = new int[length * width * height];

//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(10, 100);
//         if(i >= 1)
//         {
//             for(int j = 0; j < i; j++)
//             {
//                 while(array[i] == array[j])
//                 {
//                     array[i] = new Random().Next(10,100);
//                     j = 0;
//                 }
//             }
//         }
        
//     }
//     return array;
// }

// int[,,] CreateRandom3dArray(int length, int width, int height)
// {
//     int[,,] array = new int[length, width, height];
//     int[] array1d = ArrayElements(length, width, height);

//     int sum = 0;
//     for (int i = 0; i < length; i++)
//     {    
//         for (int j = 0; j < width; j++)
//         {   
//             for (int k = 0; k < height; k++)
//             {  
//                 array[i, j, k] = array1d[sum];
//                 sum++;
//             }
           
//         }
        
//     }
    
//     return array;
// }

// void Show3dArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//            {
//                 for (int k = 0; k < array.GetLength(2); k++)
//                 {
//                     Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
//                 }
//                 Console.WriteLine();
//            }
        
//     }
//     Console.WriteLine();
// }



// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of depth: ");
// int p = Convert.ToInt32(Console.ReadLine());

// int[] array = ArrayElements(m, n, p);
// int[,,] myArray = CreateRandom3dArray(m, n, p);

// Show3dArray(myArray);


