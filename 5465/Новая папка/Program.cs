// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
string num = "Введите числа через запятую"; 
int[] showNumbers = EnterNumbers(num);


int[] EnterNumbers(string num)
{

    string numbers = Console.ReadLine();
    int len = numbers.Length;
    int[] array = new int[len];

    while (numbers != ",")
    {

        for (int i = 0; i < len; i++)
        {
            array[i] = numbers[i];
        }
    }
    
    return array;

}