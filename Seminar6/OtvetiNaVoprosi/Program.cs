

void Main()
{
    
    while (true)
    {
        int task = ReadInt();
        switch (task)
        {
            case 40: Task40(); break;
            case 50: Task50(); break;
            case 51: Task51(); break;
        }
    }

}



int ReadInt()
{
    int i;
    int.TryParse(Console.ReadLine(), out i);

    return i;
}

void Task40() //какое больше
{
    int i = ReadInt();
    int j = ReadInt();
    while (true)
    {
        Console.WriteLine(i > j ? i : j);
    }
}

void Task50()
{

}


void Task51()
{

}

