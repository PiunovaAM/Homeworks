//Задача 19:
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
//14212 -> нет
//12821 -> да
//23432 -> да
/*
void Palindrome (string number)
{
    if (number [0] == number [4] && number [1] == number [3])
    {
        Console.Write($"Your {number} is palindrome");
    }
    else Console.Write($"Your {number} isn't palindrome");
}

Console.Write("Input your five-digit number: ");
string? number = Console.ReadLine();

if (number!.Length == 5)
{
    Palindrome(number);
}
else Console.WriteLine($"Input right number");
*/

//Задача 21:
//Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.
/*
double DistanceAB(int xa, int ya, int za, int xb, int yb, int zb)
{
    int deltaX = xa - xb;
    int deltaY = ya - yb;
    int deltaZ = za - zb;
    double distAB = Math.Round(Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ), 2);   
    return distAB;
}
Console.Write("Input X coordinate of A: ");
int xACoord = Convert.ToInt32(Console.ReadLine());

Console.Write("Input X coordinate of B: ");
int xBCoord = Convert.ToInt32(Console.ReadLine());

Console.Write("Input Y coordinate of A: ");
int yACoord = Convert.ToInt32(Console.ReadLine());

Console.Write("Input Y coordinate of B: ");
int yBCoord = Convert.ToInt32(Console.ReadLine());

Console.Write("Input Z coordinate of A: ");
int zACoord = Convert.ToInt32(Console.ReadLine());

Console.Write("Input Z coordinate of B: ");
int zBCoord = Convert.ToInt32(Console.ReadLine());

double distanceAB = DistanceAB(xACoord, yACoord, zACoord, xBCoord, yBCoord, zBCoord);

Console.WriteLine($"Distance between A and B is {distanceAB}");
*/