// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Укажите координаты точки A: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите координаты точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());
// корень(x2 - x1)^ + (y2 - y1)^ + (z2 - z1)^ 

//d - расстояние между точками в 2D пространстве
// // d = корень из выражения((x2-x1)^2 + (y2-y1)^2)
// //Math.Sqrt(число) => корень из числа: Math.Sqrt(25) => 5
// double d = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2));
// //Math.Rount(d) => d: Math.Rount(1.275) => 1
// Console.WriteLine(Math.Round(d, 3));
// Console.WriteLine($"d = {d:f2}");// срез
// // {$переменная: fсколько знаков}
double d = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2 - z1,2));
Console.WriteLine(Math.Round(d, 3));








































































































