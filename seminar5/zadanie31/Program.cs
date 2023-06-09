﻿// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


//1. Создаем и заполянем массив
//2.Циклом проверяем положительность или отрицаиельность чисел


int[] array = GetRandomArray(12, 9, -9);
int[] minAndMax = GetMinAndMaxFromArray(array);

int[] GetRandomArray(int length, int min, int max)  //функция, принимающая параметры длины, максимального и минимального значения
{
int[] array = new int[length]; //созданный массив заполнен только нулями
Random num = new Random(); //создание генератора случайных чисел. Rаndom - чертеж; num - имя объекта, созданного по чертежу; new - обозначение создания нового объекта; Random() - сам объект, созданный по чертежу.
Console.WriteLine($"ВВеден массив {string.Join("", array)}");
Console.WriteLine($"Сумма положительных {minAndMax[0]}");
Console.WriteLine($"Сумма отрицательных {minAndMax[1]}");

for (int counter = 0; counter < length; counter++)
{
    array[counter] = num.Next(min, max +1); //в элементе массива задаем случайное число между минимальным и максимальным значением(первое число включительно, второе - нет, поэтому используем max+1)

}
return array; //возвращаем массив для функции
}

int[] GetMinAndMaxFromArray (int[] array) //функция нахождения сумм элементов со значениями из массива первой функции
{
int[] minAndMax = new int [2]; //создание нового массива с длинной массива 2(один элемент - положительные числа, второй элемент - отрицательные числа)

for (int counter = 0; counter < array.Length; counter++)
{
    if (array[counter] > 0) //проверяем положительное ли число
    {
        minAndMax[0] = minAndMax[0] + array[counter]; // если чяисло положительное, кладем его в первую ячейку массива
    }
    else
    {
        minAndMax[1] = minAndMax[1] + array[counter]; // если же число отрицательное, кладем его во вторую ячейку
    }
}
return minAndMax; //возвращаем массив для функции
}
