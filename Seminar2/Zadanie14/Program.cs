﻿// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите число");
int.TryParse(Console.ReadLine(), out int a);
if (a % 7 == 0 && a % 23 == 0)
{
    Console.WriteLine($"Число {a} кратно числам 7 и 23 одновременно");
}
else
{
    Console.WriteLine($"Число {a} не кратно числам 7 и 23 одновременно");
}