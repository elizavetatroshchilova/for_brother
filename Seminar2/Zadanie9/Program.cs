Random random = new Random();
int min = 10;
int max = 99;
int number = random.Next(min, max + 1);
int a = number % 10;
int b = number / 10;
if (a>b)
{
    Console.WriteLine($"В числе {number} самая большая цифра {a}");
}
else
{
    Console.WriteLine($"В числе {number} самая большая цифра {b}");
}