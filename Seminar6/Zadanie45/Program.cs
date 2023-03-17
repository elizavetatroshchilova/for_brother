// 45 напишите программу, которая копирует массив с помощью поэлементного переноса.

int[] firstArray = FillArray(5);

Console.Write(string.Join(", ", firstArray));

Console.WriteLine();
int[] secondArray = CopyArray(firstArray);

Console.Write(string.Join(", ", secondArray));


int[] FillArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next();
    }

    return array;
}

int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = array[i];
    }

    return newArray;
}

