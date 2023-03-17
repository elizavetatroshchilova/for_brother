// Написать программу, которая на вход принимает координаты двух точек, и выводит на экран расстояние между ними.
Console.WriteLine("ВВедите координаты х1, у1 для первой точки");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("ВВедите координаты х2, у2 для второй точки");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1),2));
Console.WriteLine($"Расстояние между введенными точками равно {result}");