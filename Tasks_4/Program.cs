//Задача_59: Задайте двумерный массив из целых чисел.
//Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.

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

// System.Console.WriteLine("\n");

// int[] convertedArray = ConvertedArray(array);
// Array.Sort(convertedArray);
// System.Console.WriteLine(String.Join(" ", convertedArray));
// CountElements(convertedArray);

// void CountElements(int[] sortedArray)
// {
//   int element = sortedArray[0];
//   int count = 1;
//   for (int i = 1; i < sortedArray.Length; i++)
//   {
//     if (element == sortedArray[i])
//       count++;
//     else
//     {
//       System.Console.WriteLine($"Элемент : {element} встречается {count} раз");
//       element = sortedArray[i];
//       count = 1;
//     }
//   }
//   System.Console.WriteLine($"Элемент : {element} встречается {count} раз");
// }

// int[] ConvertedArray(int[,] array)
// {
//   int m = array.GetLength(0);
//   int n = array.GetLength(1);
//   int arrayIndex = 0;
//   int[] newArray = new int[m * n];

//   foreach (int item in array)
//   {
//     newArray[arrayIndex] = item;
//     arrayIndex++;
//   }
//   return newArray;
// }

int ReadArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      System.Console.Write("{0:d2} ", arr[i, j]);
    }
    System.Console.WriteLine();
  }return arr;
}

int[] indexMinValue = FindMinEl(arr);
int[] newArr;

int[,] FindMinEl(int[,] arr)
{
  int minValue=arr[0, 0];
  int[] indexMinValue = new int[2];

  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if(minValue > arr[i, j]) 
      {
        minValue = arr[i, j];
        indexMinValue[0] = i;
        indexMinValue[0] = j;
      }
    }
  }
  return indexMinValue;
}

int[,] DeleteRowsColums(int [,] arr, int[] index)
{
  int[,] newArr = new int [arr.GetLength(0) -1, arr.GetLength(1) -1];
  int a =0, b=0;

  for (int i = 0; i < arr.GetLength(0); i++)
  {
    if(index[0]==i)continue;
    for (int j = 0; j < arr.GetLength(1);j++)
    {
      if(index[1]==i)continue;
      newArr[a,b] = arr[i, j]; 
      b++;
    }
    a++;
    b=0;
  }return newArr;
}