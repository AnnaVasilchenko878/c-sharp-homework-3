// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B(2, 1, -7), -> 15.84
// A(7, -5, 0); B(1, -1, 9)-> 11.53

// Радиус вектор первой точки
Console.Write("Введите X координату радиуса-вектора первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y координату радиуса-вектора первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z координату радиуса-вектора первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
// Радиус вектор второй точки
Console.Write("Введите X координату радиуса-вектора второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y координату радиуса-вектора второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z координату радиуса-вектора второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Math.Round((Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2))),2));