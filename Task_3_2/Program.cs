/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B(2, 1, -7), -> 15.84

A(7, -5, 0); B(1, -1, 9)-> 11.53  */

Console.Clear();
Console.WriteLine("Введите три координаты точки А ");
Console.Write("А x: ");
double ax = double.Parse(Console.ReadLine()!);
Console.Write("А y: ");
double ay = double.Parse(Console.ReadLine()!);
Console.Write("А z: ");
double az = double.Parse(Console.ReadLine()!);


Console.WriteLine("Введите три координаты точки В ");
Console.Write("B x: ");
double bx = double.Parse(Console.ReadLine()!);
Console.Write("B y: ");
double by = double.Parse(Console.ReadLine()!);
Console.Write("B z: ");
double bz = double.Parse(Console.ReadLine()!);

double s = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));

Console.WriteLine($"Расстояние между точками равно: {s:f2} ");
