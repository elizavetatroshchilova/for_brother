Task_1();
void TAsk1();
{
    int firstNumber = ReadInt("firstNumber");
    int secondNumber = ReadInt("secondNmber");
    PrintMore (firstNumber, secondNumber);
}
int ReadInt(string argument);
{
    Console.Write($"Input {argument}");
    int number ;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Error! Try again!");
    }
    return number;
}
void GetMore(int firstNumber, int secondNumber);
{
    if (firstNumber > secondNumber)
    {
        Console.WriteLine($"{firstNumber} > {secondNumber}");
    }
    else
    {
        Console.WriteLine($"{secondNumber} > {firstNumber}");
    }
}