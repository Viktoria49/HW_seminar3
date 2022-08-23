// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты x для первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y для первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y для первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты x для второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y для второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y для второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());


double cord = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1-y2) * (y1-y2) + (z1 - z2) * (z1 - z2));

// Console.Write("Расстояние между точками в 3D пространстве равно: ");
// Console.WriteLine(Math.Round (cord, 2, MidpointRounding.ToZero));

Console.Write($"Расстояние между точками в 3D пространстве равно: {Math.Round (cord, 2, MidpointRounding.ToZero)}");

