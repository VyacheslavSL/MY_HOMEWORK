// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

// int CountPositiveNumbers(int amount)
// {
//     int count = 0;
//     int a = 0;
//     for(int i = 0; i < amount; i++)
//     {
//         Console.Write($"Input a element {i + 1}: ");
//         a = Convert.ToInt32(Console.ReadLine());
//         if(a > 0)
//             count += 1;
//     }
//     return count;
// }

// Console.WriteLine("Input a amount numbers");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Number of numbers greater than zero: {CountPositiveNumbers(m)}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



// double[] IntersectionPoint(double k1, double b1, double k2, double b2 )
// {
//     double[] array = new double[2];
//     array[0] = (b2 - b1) / (k1 - k2);
//     array [1] = k1 * array[0] + b1;
//     return array;
// }

// void ShowArray(double[] array)

// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " "); // Вывод  массива на экран

//     Console.WriteLine();
// }



// Console.WriteLine("Input K1: ");
// double c1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input B1: ");
// double d1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input K2: ");
// double c2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input B2: ");
// double d2 = Convert.ToInt32(Console.ReadLine());

// double[] myArray = IntersectionPoint(c1, d1, c2, d2 );
// ShowArray(myArray);


