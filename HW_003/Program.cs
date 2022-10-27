// Напишите программу, которая принимает на вход любое целое положительное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Input number");
// int number = Convert.ToInt32(Console.ReadLine());

// int leftRight = number; // число (слево направо).
// int rightLeft = 0; // чило обратное (справо налево).
// while(leftRight > 0) // Цикл идёт до тех пор, пока от числа (изначально заданного) не "отделятся" до конца цифры справо
// {
//     int ost = leftRight % 10; // Остаток при делении 10 (оставляет последнюю цифру числа).
//     rightLeft = rightLeft * 10 + ost; // Формируется новое чило наоборот.
//     leftRight = leftRight / 10; // Деление на цело на 10 отбрасывает последнюю цифру.
// } 
// if(rightLeft == number)
// {
//   Console.WriteLine("number is palindrome");  
// }
// else
// {
//     Console.WriteLine("number is not palindrome"); 
// }


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53




// double Vector(double x1, double y1, double z1, double x2, double y2, double z2 )
// {
//     double deltaX = x2 - x1;
//     double deltaY = y2 - y1;
//     double deltaZ = z2 - z1;
//     double deltaXexp = Math.Pow(deltaX, 2);
//     double deltaYexp = Math.Pow(deltaY, 2);
//     double deltaZexp = Math.Pow(deltaZ, 2);
//     double lengthsqrt =deltaXexp + deltaYexp + deltaZexp ;
//     double length = Math.Sqrt(lengthsqrt);
//     return length;
// }
// Console.WriteLine("Input Xa: ");
// double abc1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input Ya: ");
// double ord1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input Za: ");
// double appl1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input Xb: ");
// double abc2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input Yb: ");
// double ord2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input Zb: ");
// double appl2 = Convert.ToDouble(Console.ReadLine());

// double res = Vector(abc1, ord1, appl1, abc2, ord2, appl2);
// double result = Math.Round(res, 2);
// Console.WriteLine($"length = {result}");



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void Table(int number)
// {
    
//     for(int i = 1; i <= number; i++)

//         { 
//             double result = Math.Pow(i,3);
//           Console.Write(result + " ");
//         }
        
    
// }

// Console.WriteLine("Input number");
// int n = Convert.ToInt32(Console.ReadLine());

// Table(n);
