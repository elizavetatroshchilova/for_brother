// задайте массив. Напишите программу, которая определяет есть ли заданное число в массиве


Console.WriteLine("Введите число");

int.TryParse(Console.ReadLine(), out int a);

int[] array = getRandomArray(6, -5, 5);

findNumber(array, a);

int[] getRandomArray(int length, int min, int max)
{
    int[] array = new int[length];
    Random num = new Random();


    for(int index = 0; index < length; index ++)
    {
        array[index] = num.Next(min, max + 1);
    }
    return array;

}

void findNumber(int[] array, int a)
{

//int[] array = new int[array.Length];
Console.WriteLine(string.Join(", ", array));

for (int counter = 0; counter < array.Length; counter ++)
{

    if (array[counter] == a)
    {
        Console.WriteLine("Данное число присутсвует в массиве");
        return;
    }

  }

Console.WriteLine("Данное число отсутсвует в массиве");

}