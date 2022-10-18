// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*Console.Write("Input a first number: ");
int first_number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int second_number = Convert.ToInt32(Console.ReadLine());

if(first_number > second_number)
    Console.WriteLine($"Number {first_number} is a max");
else
    Console.WriteLine($"number {second_number} is max");
*/

// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*Console.Write("Input a first number: ");
int first_number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int second_number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int third_number = Convert.ToInt32(Console.ReadLine());

int max_number = first_number;

if(second_number > max_number)
{max_number = second_number;}
if(third_number > max_number)
{max_number = third_number;}

Console.WriteLine($"Number {max_number} is a max");
*/

// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
  Console.WriteLine($"Number {number} is a even");  
else
  Console.WriteLine($"Number {number} is a odd number");
*/

// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 1;

while(current <= number)
{
    if(current % 2 == 0)
    {
        Console.Write(current + " ");
    }
    current++;

}
*/