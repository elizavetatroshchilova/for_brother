//Console.WriteLine("Введите 3 значения: длину массива, минимальное значения наполнения и максимальное значение наполнения");
//int[] array = GetRandomArray(ReadInt("длину массива"), ReadInt("минимальное значение наполнения"), ReadInt("максимальное значение наполнения"));
//int[] minAndMax = GetMinAndMaxFromArray(array);
//Console.WriteLine($"Сумма положительных значений массива {minAndMax[0]}, сумма отрицательных значений массива {minAndMax[1]}");

//int ReadInt(string arg)
//{
//  Console.Write($"Введите {arg}: ");
//  int number;

//  while (!int.TryParse(Console.ReadLine(), out number))
//  {
//    Console.Write("Вы ввели нецелое число! Повторите: ");
//  }

//  return number;
//}

//int[] GetRandomArray(int length, int minValue, int maxValue)
//{
//  Random random = new Random();

//  int[] ints = new int[length];

//  for (int i = 0; i < length; i++)
//  {
//    ints[i] = random.Next(minValue, maxValue + 1);
//  }

//  return ints;
//}

//int[] GetMinAndMaxFromArray(int[] array)
//{
//  int[] ints = new int[2];

//  for (int i = 0; i < array.Length; i++) 
//  { 
//    if (array[i] > 0)
//    {
//      ints[0] += array[i];
//    }
//    else
//    {
//      ints[1] += array[i];
//    }
//  }

//  return ints;
//}


// 2. 

//int[] array = GetRandomArray(4, -9, 10);
//int[] changedArray = ChangeMarks(array);
//Console.WriteLine($"{string.Join(" ", array)} - {string.Join(" ", changedArray)}");

int[] GetRandomArray(int length, int min, int max)
{
  int[] array = new int[length];
  Random random = new Random();

  for (int i = 0; i < array.Length; i++)
  {
    array[i] = random.Next(min, max + 1);
  }

  return array;
}

int[] ChangeMarks(int[] array)
{
  int[] changed = new int[array.Length];

  for (int i = 0; i < array.Length; i++)
  {
    changed[i] = array[i] * -1;
  }

  return changed;
}

// 3. 

//int[] array = GetRandomArray(5, -9, 9);
//int number = 3;
//if (FindANumber(array, number))
//{ 
//  Console.WriteLine($"{string.Join(" ", array)}  да");
//}
//else Console.WriteLine($"{string.Join(" ", array)}  нет");

bool FindANumber(int[] array, int number)
{
  if (number < 0) number *= -1;

  for (int i = 0; i < array.Length;i++) 
  { 
    int module = array[i];
    if(module < 0) module *= -1;

    if (module == number)
    {
      return true;
    }
  }

  return false;
}

// 4.

//int[] array = GetRandomArray(123, -150, 150);
//int count = GetCount(array);
//Console.WriteLine($"В вашем массиве {count} элементов в промежутке от 10 до 99");

int GetCount(int[] array)
{
  int count = 0;

  for (int i = 0; i < array.Length;i++) 
  { 
      if (array[i] >= 10 && array[i] <= 99) 
      { 
      count++;
      }
  }

  return count;
}

// 5.

int[] array = GetRandomArray(5, 1, 10);
int[] newArray = GetProductOfPair(array);

Console.WriteLine(string.Join(", ", array));
Console.WriteLine(string.Join(", ", newArray));


int[] GetProductOfPair(int[] array)
{
  int length = 0;
  if (array.Length % 2 == 0) 
  { 
    length = array.Length / 2;
  }
  else
  {
    length = array.Length / 2 + 1;
  }

  int[] result = new int[length];

  for (int i = 0; i < length; i++) 
  {
    result[i] = array[i] * array[array.Length - 1 - i];

  }

  if (array.Length % 2 != 0)
  {
    result[length - 1] = array[array.Length / 2];
  }

  return result;
}