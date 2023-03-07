//Задача_57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том,
//сколько раз встречается элемент входных данных.


int[,] TwoRandomArray()
{
  int[,] array = new int[new Random().Next(3, 3), new Random().Next(4, 4)];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    Console.WriteLine();
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(0, 10);
      Console.Write(array[i, j] + " ");
    }
  }
  for (int i = 0; i < array.GetLength(0); i++)
  {
    Console.WriteLine();
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(-10, 11);
      Console.Write(array[i, j] + " ");
    }
  }
  return array;
}
int[,] array = TwoRandomArray();

System.Console.WriteLine("\n");

int[] convertedArray = ConvertedArray(array);
Array.Sort(convertedArray);
System.Console.WriteLine(String.Join(" ", convertedArray));
CountElements(convertedArray);

void CountElements(int[] sortedArray)
{
  int element = sortedArray[0];
  int count = 1;
  for (int i = 1; i < sortedArray.Length; i++)
  {
    if (element == sortedArray[i])
      count++;
    else
    {
      System.Console.WriteLine($"Элемент : {element} встречается {count} раз");
      element = sortedArray[i];
      count = 1;
    }
  }
  System.Console.WriteLine($"Элемент : {element} встречается {count} раз");
}

int[] ConvertedArray(int[,] array)
{
  int m = array.GetLength(0);
  int n = array.GetLength(1);
  int arrayIndex = 0;
  int[] newArray = new int[m * n];

  foreach (int item in array)
  {
    newArray[arrayIndex] = item;
    arrayIndex++;
  }
  return newArray;
}

void ReadArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      System.Console.Write("{0:d2} ", array[i, j]);
    }
    System.Console.WriteLine();
  }
}