// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


int sumOfDigits(int array)
{
  string s = array.ToString();
  int result = 0;
  int len = s.Length;

  for(int i = 0; i < len; i++)
  {
    result = result + s[i];
  }
  return result;
 
  }


Console.WriteLine("Введите число");
int.TryParse(Console.ReadLine(), out int array);

sumOfDigits(array);

 Console.WriteLine($"Сумма цифр в числе {array} равна {sumOfDigits(array)}");