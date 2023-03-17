while(true)
{
    Console.Clear();

    int[] cordX = new int[]{1, -1, -1, 1};
    int[] cordY = new int[]{1, 1, -1, -1};
    Console.Write("Введите номер четверти ");
    int number = 0;

    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("It's not a number");
    }

    string quarterTextX;
    if (cordX[number -1] > 0)
    {
        quarterTextX = "+ бесконечность";
    }
    else quarterTextX = "- бесконечность";
    string quarterTextY;
    if (cordY[number -1] > 0)
    {
        quarterTextY = "+ бесконечность";
    }
    else quarterTextY = "- бесконечность";

    Console.WriteLine($"\nЧетверть {number}: X oт {cordX[number-1]} до {quarterTextX}\n Y от {cordY[number-1]} до {quarterTextY}");
    Console.ReadKey();
}