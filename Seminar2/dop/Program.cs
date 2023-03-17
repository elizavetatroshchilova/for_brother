//Написать программу, которая находит первые пять чисел, кратных одновременно 2 и 3, и выводит их сумму на экран.
int a = 1;
int count = 0;
int sum = 0;
while (count < 5)
{
    if (a % 2 == 0 && a % 3 == 0)
    {
        sum = sum + a;
        count++;
    }
    a++;
} 
Console.WriteLine(sum);