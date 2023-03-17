Random random = new Random();
int min = 100;
int max = 999;
int number = random.Next(min, max + 1);
Console.WriteLine(number);
int a = number / 100 * 10;
int b = number % 10;
Console.WriteLine(a + b);