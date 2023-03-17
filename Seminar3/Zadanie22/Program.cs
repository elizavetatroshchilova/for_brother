Console.WriteLine("Введите число");
int.TryParse(Console.ReadLine(), out int n); //либо int n = Convert.ToInt32(Console.ReadLine());
int index = 1;
while (index <= n)
{
   double result = Math.Pow(index, 2);  // либо int result = Convert.ToInt32(Math.Pow (index, 2)); однако лучший вариант int result = (int)Math.Pow(index, 2);
   Console.Write($"{result} ");
   index++;
}