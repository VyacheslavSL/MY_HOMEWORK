// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int size) // Генерация массива
// {
//     int[] array = new int[size]; 

//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(100, 1000);
//     return array;    
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " "); // Вывод  массива на экран
//     Console.WriteLine();
// }

// int CountEvenNumber(int[] array) // Проверка на четность
// {
//     int amt = 0;
//     for(int i = 0; i < array.Length; i++)
//         if(array[i] % 2 == 0)
//         amt += 1;
//     return amt;    
// }



// Console.Write("Input a number of elements: ");
// int n = Convert.ToInt32(Console.ReadLine());


// int[] myArray = CreateRandomArray(n);
// ShowArray(myArray);

// int result = CountEvenNumber(myArray);
// Console.WriteLine("Amount of even elements " + result);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int size, int minValue, int maxValue) // Генерация массива
// {
//     int[] array = new int[size]; 

//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     return array;    
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " "); // Вывод  массива на экран
//     Console.WriteLine();
// }

// int SumOddIndex(int[] array)
// {
//     int sum = 0;
//     for(int i = 1; i < array.Length; i = i + 2)
//         sum += array[i];       
//     return sum;
// }

// Console.Write("Input a number of elements: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(n, min, max);
// ShowArray(myArray);

// int result = SumOddIndex(myArray);
// Console.WriteLine("Тhe sum of elements in an odd position " + result);



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] CreateRandomArray(int size, int minValue, int maxValue) // Генерация массива
// {
//     double[] array = new double[size]; 

//     for(int i = 0; i < size; i++)
//         array[i] = new Random().NextDouble() + new Random().Next(minValue, maxValue + 1);
//     return array;    
// }

// void ShowArray(double[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(Math.Round(array[i], 3) + " "); // Вывод  массива на экран
    
//     Console.WriteLine();
// }

// double Delta(double[] array)
// {
//     double minelement = array[0];
//     double maxelement = array[0];

//     for(int i = 1; i < array.Length; i++ )
//         if(array[i] < minelement) minelement = array[i];
//             for(int j = 1; j < array.Length; j++)
//                 if(array[j] > maxelement) maxelement = array[j];
        
//     double delta = maxelement - minelement;
//     return delta;

// }

// Console.Write("Input a number of elements: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());


// double[] myArray = CreateRandomArray(n, min, max);
// ShowArray(myArray);
// double result = Math.Round(Delta(myArray), 3);
// Console.Write($"Difference between maximum and minimum array element is {result}");

