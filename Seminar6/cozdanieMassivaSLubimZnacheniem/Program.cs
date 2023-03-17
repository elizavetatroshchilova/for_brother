чтобы задать массив с любыми значениями (строковыми, целочисленными, буквенными и т.д.)
var array = new int[] {1, 2, 3, 4};

PrintArray(array);

void PrintArray<T>(T[] array)
{
    foreach(var item in array)
    {
        Console.WriteLine(item);
    }
}
