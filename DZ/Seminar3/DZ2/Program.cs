// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
System.Console.WriteLine("Здравствуйте, для того что бы определить расстояние между точками (А) и (В) в 3D пространстве");
System.Console.WriteLine("Введите через пробел координаты точки (A), напрмер - 1 2 3");
int[] coordinate_A = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

System.Console.WriteLine("Введите через пробел координаты точки (B), напрмер - 1 2 3");
int[] coordinate_B = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

System.Console.WriteLine("Определены координаты точки (А) [" + String.Join(", ", coordinate_A) + "]");
System.Console.WriteLine("Определены координаты точки (В) [" + String.Join(", ", coordinate_B) + "]");

System.Console.WriteLine("Расстояние между точками А и В = " + Math.Round(Math.Sqrt(Math.Pow(coordinate_A[0] - coordinate_B[0], 2) + Math.Pow(coordinate_A[1] - coordinate_B[1], 2) + Math.Pow(coordinate_A[2] - coordinate_B[2], 2)), 3));