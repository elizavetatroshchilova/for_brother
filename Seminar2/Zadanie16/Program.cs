// 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.WriteLine("Введите первое число");
int.TryParse(Console.ReadLine(), out int a);
Console.WriteLine("Введите второе число");
int.TryParse(Console.ReadLine(), out int b);
if (a > b)
{
    if (a == (b * b))
    {
        Console.WriteLine("Да");
    }
    else 
    {
        Console.WriteLine("Нет");
    }
}
else 
{
    if ( b == (a * a))
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
