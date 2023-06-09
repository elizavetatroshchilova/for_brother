﻿//37.найдите произведение пар чисел в одномерном массиве. Парой считается первый и последний элемент, второй и предпоследнийб и т.д. Результат запишите в новом массиве.


int[] array = GetRandomArray(5, 1, 10); //вызываем функцию GetRandomArray со значениями length = 5, min = 1, max = 10.

int[] newArray = GetProductOfPairs(array); // вызов функции GetProductOfPairs и прогоняем через нее первоначальный массив из функции GetRandomArray.

Console.WriteLine(string.Join(", ", array)); // выводим на экран первоначальный массив в одну строку и через запятую. 

Console.WriteLine(string.Join(", ", newArray)); // выводим на экран новый массив, содержащий в себе произведения пар. Также в одну строку и через запятую.

int[] GetRandomArray(int length, int min, int max) // функция создания нового массива длинной length, в промежутке значений от min до max.
{
    int[] array = new int[length];  // создаем новый массив длинной length
    Random num = new Random(); // создаем новый генератор случайных значений

    for(int i = 0; i < array.Length; i++) // цикл переборки всех элементов созданного массива
    {
        array[i] = num.Next(min, max + 1); // заполнение каждой ячейки массива случайным значением в заданом диапазаоне (изначально в каждой ячейке значение равнялось нулю)

    }

    return array; // возвращаем значение массива
}



int[] GetProductOfPairs(int[] array) // функция по созданию нового массива из произведений пар первого заданного массива в функции GetRandomArray
{
    int length = 0; // задаем переменную, в которую потом положим значение длины нового массива
    if(array.Length % 2 == 0) // условие проверки четности количества элементов массива
    {
        length = array.Length / 2; // если колиечтсво элементов изначального массива - четное число, тогда длина нового массива будет равна длинне первого массива, деленной на два
    }    
    else
    {
        length = array.Length / 2 + 1; // если колиечтсво элементов изначального массива - нечетное число, тогда длина нового массива будет равна длинне первого массива, поделенной на два и +1
    }

    int[] arrayResult = new int [length]; //создаем новый массив с длинной выбраной в предыдущем условии if


    for(int i = 0; i < array.Length / 2; i ++) // цикл перебора элементов массива (чтобы цикл остановился на середине массива и не вышел за его пределы, задаем значение i < array.Length / 2)
    {
        arrayResult[i] = array[i] * array[array.Length - 1 - i]; //помещаем в ячейки нового массива значение произведения пар изначального массива
    }

  if(array.Length % 2 != 0) // если массив нечетный
    {
       arrayResult[length-1] = array[array.Length / 2]; // тогда последний элемент нового массива будет равняться среднему элементу изначального массива, умноженному на один
    }    

    return arrayResult; // возвращение рещультата массива arrayResult
}

