// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


Console.Write("Введите числа через запятую: ");
int[] numbers = StringToNum(Console.ReadLine());
PrintArray(numbers);

int s = CalculateSum(numbers);

int CalculateSum(int[] numbers)
{
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
return sum;
}
Console.WriteLine();
Console.WriteLine($"количество значений больше 0 = {s}");


int[] StringToNum(string input)  //метод, превращающий строковую переменную, введенную пользователем в массив.
{
    int count = 1;  //объявляем счетчик.
    for (int i = 0; i < input.Length; i++) //создаем цикл, который работает, пока мы не достигнем длины введенной строки(считает запятые).
    {
        if (input[i] == ',')  //если элемент введенной строки с индексом i равен запятой, тогда
        {
            count++;  //счетчик увеличивается на 1.
        }
    }

    int[] numbers = new int [count];  //создаем массив с длиной равной счетчику запятых
    int index = 0; //задаем индекс.

    for (int i = 0; i < input.Length; i++) //создаем цикл.
    {
        string temp = ""; //вводим строковую переменную temp, равную пустой строке.

        while (input [i] != ',') //когда элемент введенной строки с индексом i не равен запятой, тогда
        {
        if(i != input.Length - 1) //проверяем  условие ( индекс i не равен длине строки - 1) и тогда
        {
            temp += input [i].ToString(); // строковая переменная temp = temp + элемент, введенной пользователем строки, с индексом i, переведеным в массив
            i++; //инкремент
        }
        else //иначе
        {
            temp += input [i].ToString(); //temp = temp +  элемент, введенной пользователем строки, с индексом i, переведеным в массив
            break; //останавливаем цикл
        }
        }
        numbers[index] = Convert.ToInt32(temp); //элементу массива Numbers присваиваем значение элемента строковой переменной temp  в виде целочисленного значения
        index++; //инкремент индекса
    }
    return numbers; //возвращаем значение массива numbers.
}


void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}