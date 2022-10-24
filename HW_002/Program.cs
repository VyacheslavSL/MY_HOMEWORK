// Домащняя работа на семинар № 2.

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int SecondDigit(int number)
// {
//     int result = (number / 10) % 10;
//     return result;
// }

// Console.Write("Input three digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(SecondDigit(num));

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// int ThirdDigit(int number)
// {
//     if(number > 99)
//     {
//         int num = number;
//         while (num > 999)
//         {
//             num = num / 10;
//         }
//         int res = num % 10;
//         return res;
//     }
//     else
//     {
//         int m = -1;
//         return m;
//     }
// }


// Console.WriteLine("Input a number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// int result = ThirdDigit(num1);
// Console.WriteLine(ThirdDigit(num1)); 

// Задача 15: Напишите программу,которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// void Week(int day)
// {
//     if(day > 0 && day < 8)
//     {
//         if(day == 6 || day == 7)
//         {
//             Console.WriteLine("This is a day off");
//         }
//         else
//         {
//             Console.WriteLine("This is a weekday");
//         }
//     }
//     else
//     {
//         Console.WriteLine("ERROR! Input number ( 1 to 7 )");
//     }

// }

// Console.WriteLine("Enter a number representing the day of the week (1 to 7)");
// int number = Convert.ToInt32(Console.ReadLine());
// Week(number);
 
  





 





