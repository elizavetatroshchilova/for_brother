// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5



int firstLength = ReadInt("First Length");
int secondLength = ReadInt("Second Length");

double[,] array = CreateTwoDimensionArray(firstLength, secondLength);

Console.WriteLine(TwoDimensionArrayToString(array));

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


double[,] CreateTwoDimensionArray(int firstLength, int secondLength)
{
	double[,] result = new double[firstLength, secondLength];

	for (int i = 0; i < result.GetLength(0); i++)
	{
		for (int j = 0; j < result.GetLength(1); j++)
		{
			result[i, j] = i + j;
		}
	}

	return result;
}

string TwoDimensionArrayToString(double[,] array)
{
	string result = string.Empty; // "";

	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			result += $"{array[i, j]} ";
		}

		result += Environment.NewLine; // "\n"
	}

	return result;
}
