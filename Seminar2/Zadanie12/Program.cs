// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.WriteLine("Введите первое число");
int.TryParse(Console.ReadLine(), out int one);
Console.WriteLine("Введите второе число");
int.TryParse(Console.ReadLine(), out int two);
if (one > two)
{
    if (one % two == 0)
    {
    Console.WriteLine($"Число {one} кратно числу {two}");
    }
    else
    {
        Console.WriteLine($"Число {one} не кратно числу {two}, остаток {one % two}");
    }
    }
    else
    {
        if (two % one == 0)
    {
    Console.WriteLine($"Число {two} кратно числу {one}");
    }
    else
    {
        Console.WriteLine($"Число {two} не кратно числу {one}, остаток {two % one}");
    }
    }