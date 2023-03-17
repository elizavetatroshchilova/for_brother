// ReadInt()
// CalculateSumToN()
Console.WriteLine(CalculateSumToN(ReadInt("number")));

int ReadInt(string argument)
{
    Console.Write($"Input {argument} ");
    int number;

    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("It's not an int");
    }

    return number;
}

int CalculateSumToN(int number)
{
    int sum = 0;

    for (int i = 0; i <= number; i++)
    {
        sum += i;
    }

    return sum;
}