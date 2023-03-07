// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.



int[,] TwoRandomArray()
{
  // Console.WriteLine("Введите количество строк двумерного массива: ");
  // int m = Convert.ToInt32(Console.ReadLine());
  // Console.WriteLine("Введите количество столбцов двумерного массива: ");
  // int n = Convert.ToInt32(Console.ReadLine());
  // int[,] array = new int[m, n];
 int[,] array = new int[new Random().Next(3,10), new Random().Next(4,10)];
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
System.Console.WriteLine();
System.Console.WriteLine();
ReadArray(ChangedRowsArray(array));


int[,] ChangedRowsArray(int[,] array)
{

  int m = array.GetLength(0);
  int n = array.GetLength(1);
  for (int i = 0; i < array.GetLength(1); i++)
  {
      int tmparray = array[0,i];
      array[0, i] = array[m - 1, i];
      array[m - 1, i] = tmparray;
  }
  return array;
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

//   int rows = arr.GetLength(0);
//     int cols = arr.GetLength(1);

//     for (int j = 0; j < cols; j++)
//     {
//         int sum = 0;
//         for (int i = 0; i < rows; i++)
//         {
//            sum +=arr[i, j];
//         }
//         double result = (double)sum/rows;  
//         Console.WriteLine(result);  
//     }


// int [,] TwoRandomArray()
// {
//     Console.WriteLine("Введите количество строк двумерного массива: ");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите количество столбцов двумерного массива: ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     int[,] array = new int[m,n];
    
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.WriteLine();
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(-10, 11);
//             Console.Write(array[i, j] + " ");
//         }
//     }
//     return array;
// }
// int[,] array = TwoRandomArray();


//         {    
//   int count = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
      
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if(arr[i,j] == ViewerNumber)
//             {
//               Console.WriteLine($"Искомый элемент находится на позиции: {i}, {j}");
//             }
//             else
//             {
//               count++;
//             }
//         }
//     }
//     if (count == arr.GetLength(0)*arr.GetLength(1))
//     Console.WriteLine("Искомого значения нет!");
// }