// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// I способ:
// void ShowNums(int n, int i)
// {
//     if(n > i) ShowNums(n, i + 1);
//     Console.Write(i + " ");
// }

// ShowNums(10,1);

// II способ: 

// void ShowNums(int n)
// {
//    Console.Write(n + " ");
//    if(n > 1) ShowNums(n - 1);
// }

// ShowNums(10);

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SumNumbers(int m, int n)
// {
//    if(n == (m - 1)) return 0;
//    else return SumNumbers(m, n - 1) + n;
// }
// Console.WriteLine(SumNumbers(4, 8));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int m, int n)
{
	if(m == 0)
	{
		return n + 1;
	}
	if(m > 0 && n == 0)
	{
		return Akkerman(m - 1, 1);
	}
		return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.WriteLine(Akkerman(3,2));