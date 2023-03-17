Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine())-1; //

int[] arrayX = new int[4]{1, -1, -1, 1};
int[] arrayY = new int[4]{1, 1, -1, -1};

string xinfiniti = "";
string yinfiniti = "";

if (arrayX[a] > 0)
{
xinfiniti = "+ бесконечность";
}
else
{
xinfiniti = "- бесконечность";
}
if (arrayY[a] > 0)
{
yinfiniti = "+ бесконечность";
}
else
{
yinfiniti = "- бесконечность";
}
Console.WriteLine($"В четверти {a} x от {arrayX[a]} до {xinfiniti}, y от {arrayY[a]} до {yinfiniti}");