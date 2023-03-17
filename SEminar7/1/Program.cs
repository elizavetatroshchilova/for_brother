int firstLength = ReadInt("First Length");
int secondLength = ReadInt("Second Length");

int[,] array = CreateTwoDimensionArray(firstLength, secondLength);
int[,] function = evenIndex(array);

Console.WriteLine(TwoDimensionArrayToString(array));
System.Console.WriteLine(TwoDimensionArrayToString(function));


int ReadInt(string argument)
{
	Console.Write($"Input {argument}: ");
	int result = 0;

	while (!int.TryParse(Console.ReadLine(), out result))
	{
		Console.WriteLine("Try again");
	}

	return result;
}

int[,] CreateTwoDimensionArray(int firstLength, int secondLength)
{
	int[,] result = new int[firstLength, secondLength];

	for (int i = 0; i < result.GetLength(0); i++)
	{
		for (int j = 0; j < result.GetLength(1); j++)
		{
          result[i, j] = i + j ;
		}
	}
    return result;
}

int[,] evenIndex(int [,] array)
{
    int[,] newResult = new int[array.GetLength(0), array.GetLength(1)];

    for (int i = 0; i < newResult.GetLength(0); i++)
    {
        for (int j = 0; j < newResult.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
            {
                newResult[i, j] = array[i,j] * array[i,j];
            }
        }
 
    } return newResult;
}