/*
Console.Write("Input your number: "); //запрос данных у пользователя
int number = Convert.ToInt32(Console.ReadLine()); // в переменную number вписали введенное значение

Console.WriteLine($"Your number is {number}");
*/

//Задача 2
// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
/*
Console.Write("Input your number_a: ");
int number_a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input your number_b: ");
int number_b = Convert.ToInt32(Console.ReadLine());

if (number_a > number_b)
{
    Console.WriteLine($"Max is {number_a}");
    Console.WriteLine($"Min is {number_b}");
}
else
{
    Console.WriteLine($"Max is {number_b}");
    Console.WriteLine($"Min is {number_a}");
}
*/

//Задача 4:
//Напишите программу, которая принимает на вход три числа и
// выдаёт максимальное из этих чисел.
/*
Console.Write("Input your first number: ");
int number_a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input your second number: ");
int number_b = Convert.ToInt32(Console.ReadLine());

Console.Write("Input your third number: ");
int number_c = Convert.ToInt32(Console.ReadLine());

int max = number_a;

if (number_a > max) max = number_a;
if (number_b > max) max = number_b;
if (number_c > max) max = number_c;

Console.Write("max = ");
Console.WriteLine(max);

ИЛИ

Console.Write("Input your first number: ");
int number_a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input your second number: ");
int number_b = Convert.ToInt32(Console.ReadLine());

Console.Write("Input your third number: ");
int number_c = Convert.ToInt32(Console.ReadLine());

int max = 0;

if(number_a > max)
{
    max = number_a;
}
if(number_b > max)
{
    max = number_b;
}
if(number_c > max)
{
    max = number_c;
}

Console.Write("max = ");
Console.WriteLine(max);
*/

//Задача 6:
// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
*/

//Задача 8:
// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

int currentNumber = 2;

if(number > 1)
{
    while(currentNumber <= number)
    {
        Console.Write(currentNumber + " ");
        currentNumber = currentNumber + 2;
    }
}
*/

