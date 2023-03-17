while(true)
{
    Task1();
}

void Task1 ()
{
    int x = ReadInt("X");
    int y = ReadInt("Y");

    int quarter = GetQuarter(x, y);
    Console.WriteLine($"{quarter}:[{x} - {y}]");
}

int GetQuarter(int x, int y)
{
    if ( x == 0 || y == 0)
    {
        return -1;
    }
    if (x > 0 && y > 0)
    {
        return 1;
    } 
    else if (x < 0 && y > 0)
    {
        return 2;
    }
    else if (x < 0 && y < 0)
    {
        return 3;
    }
    else 
    {
        return 4;
    }
}

int ReadInt(string argumentName)
{
    int number = 0;
    Console.Write($"Input {argumentName}: ");
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("It's not a number");
    }
    return number;
}