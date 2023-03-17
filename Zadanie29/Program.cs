// Написать программу, которая принимает на вход число и выдает количество цифр в числе
Console.WriteLine(CalculateSumOfDigits(ReadInt("number")));

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

int CalculateSumOfDigits(int number)
{
    int sum = 0;
    string s = number.ToString();


    for (int i = 0; i < s.Length; i++)
    {
        sum ++;
    }

    return sum;
}