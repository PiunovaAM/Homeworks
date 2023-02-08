//Задача 21:
//Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.

double DistanceAB(int xa, int ya, int xb, int yb, int xc, int yc)
{
    int deltaX = xa - xb - xc;
    int deltaY = ya - yb - xc;
    double distAB = Math.Round(Math.Sqrt(deltaX * deltaX + deltaY * deltaY), 2);   
    return distAB;
}
Console.Write("Input X coordinate of A: ");
int xACoord = Convert.ToInt32(Console.ReadLine());

Console.Write("Input X coordinate of B: ");
int xBCoord = Convert.ToInt32(Console.ReadLine());

Console.Write("Input X coordinate of C: ");
int xCCoord = Convert.ToInt32(Console.ReadLine());

Console.Write("Input Y coordinate of A: ");
int yACoord = Convert.ToInt32(Console.ReadLine());

Console.Write("Input Y coordinate of B: ");
int yBCoord = Convert.ToInt32(Console.ReadLine());

Console.Write("Input Y coordinate of C: ");
int yCCoord = Convert.ToInt32(Console.ReadLine());

double distanceAB = DistanceAB(xACoord, yACoord, xBCoord, yBCoord, xCCoord, yCCoord);

Console.WriteLine($"Distance between A and B is {distanceAB}");