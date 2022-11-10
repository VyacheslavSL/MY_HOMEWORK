//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int ExpNum(int num1, int num2)
// {
//     int a = num1;
//     for(int b = 1; b < num2; b++)
//     {
//         a *= num1;
//     }
//     return a;
// }

// Console.Write("Input a number, the base A:  ");
// int bas = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number, the  power B:  ");
// int  pow = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine($"Exponentiation of the base {bas} and the power {pow}  is  a {ExpNum(bas, pow)} ");


 //  Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int SumDigit(int number)
// {
//     int sum = 0;
    
//     if (number == 0)
//     {
//         sum = 0;
//     }

//     while (number != 0)
//     {
//         int num1 = number;
//         number/= 10;
//         int ost = num1 % 10;
//         sum += ost;
        
//     }
//     return sum;
// }

// Console.WriteLine("Input a number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"sum digits of number is {SumDigit(a)}");

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// int[] CreateArray(int size) 
// {
//     int[] array = new int[size]; 

//     for(int i = 0; i < size; i++)
//     {
//         Console.Write($"Input a element {i}: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
        
//     return array;    
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " "); // Вывод  массива на экран
//     }
//      Console.WriteLine();   
    
    
// }

// Console.Write("Input a number of elements: ");
// int m = Convert.ToInt32(Console.ReadLine());


// int[] myArray = CreateArray(m);
// ShowArray(myArray);
