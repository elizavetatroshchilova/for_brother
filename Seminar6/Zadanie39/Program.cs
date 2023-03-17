// 39. Напишите программу, которая перевернет одномерный массив (последний элемент будет на первом месте, а первый на последнем и т.д)

// [ 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


int[] arr = new int[5];

RandomArray(arr);

Console.WriteLine(string.Join(", ", arr));

ReturnArray(arr);

Console.WriteLine(string.Join(", ", arr));


void RandomArray(int[] arr)
{
    Random num = new Random();


    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = num.Next();
    }


}


void ReturnArray(int[] arr)
{
    int a = 0;

    for (int i = 0; i < arr.Length / 2; i++)
    {
        a = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = a;

    }
}