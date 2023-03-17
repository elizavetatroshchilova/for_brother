//32. Напишите программу замены элементов массива: положительные элементы замените на соответсвующие отрицательные, и наоборот 


int[] array = GetRandomArray(4, -10, 10);

int [] GetRandomArray(int length, int min, int max)
{
    int[] array = new int [length];
    Random num = new Random();

    for (int counter = 0; counter < length; counter++)
    {
        array[counter] = num.Next(min, max + 1);
    }
    return array;

}

int[] Replace(int[] array)
{
    int[] arrayNew = new int [array.Length];

     for (int counter = 0; counter < array.Length; counter++)
    {
        arrayNew[counter] = array[counter] * (-1);
    }
    return arrayNew;
}

int[] arrayNew = Replace(array);

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Было {array[i]} Стало {arrayNew[i]}");
}
