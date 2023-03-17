// 44. Не используя рекурсию, выведите первые n чисел Фибоначчи. Первые два числа Фибоначчи = 0 и 1.


// Console.WriteLine("Сколько чисел Фибоначчи вы хотите вывести?");
// int.TryParse(Console.ReadLine(), out int amount);

int enterNumber = CheckNumber();
int[] x = FindFibonacchi(enterNumber);
Console.Write($"Первые {enterNumber} чисел(числа) Фибоначчи -> {string.Join(", ", x)}");

int CheckNumber()
{
  Console.WriteLine("Сколько чисел Фибоначчи вы хотите вывести?"); 
int number;

while(!int.TryParse(Console.ReadLine(), out number))
{
    Console.WriteLine("Вы ввели нецелое число");
}
if(number == 1) Console.WriteLine("Первое число Фибоначчи = 0");

else if(number == 0)  Console.WriteLine("Вы ввели 0, так вы ничего не увидите. Попробуйте ввести значение > 0");

return number;
}



int[] FindFibonacchi(int amount)
{

int[] array = new int[amount];
array[0] = 0;
array[1] = 1;

for (int i = 2; i < amount; i++)
{
    array[i] = array[i-1] + array[i-2];

}


return array;
}

