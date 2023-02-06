// Задача 10: 
// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа
/*
Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 & number < 1000)
{
    int digit_2 = (number / 10) % 10;
    Console.WriteLine($"Second digit is {digit_2}");
}
*/

// Задача 13:
// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

/*
Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 & number < 1000)
{
    int digit_3 = number % 10;
    Console.WriteLine($"Third digit is {digit_3}");
}
else
{
    Console.WriteLine("Your number isn't 3-digit!");
}
*/
// Задача 15:
// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
/*
void CheckDay (int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
        Console.WriteLine("This day is day off!");
    else Console.WriteLine("This day isn't a holiday");
}

Console.Write("Input number representing the day of the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
CheckDay(dayNumber);
*/
// Можно добавить еще условие на проверку является ли этот день вообще днем недели
/*
void CheckDay (int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
        Console.WriteLine("This day is day off!");
    else if(dayNumber < 1 || dayNumber > 7)
        Console.WriteLine("This is not the day of the week!");
    else Console.WriteLine("This day isn't a holiday");
}

Console.Write("Input number representing the day of the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
CheckDay(dayNumber);
*/