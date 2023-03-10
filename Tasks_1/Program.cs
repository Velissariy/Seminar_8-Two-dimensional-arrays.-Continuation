using System;

Menu();

void Menu() // Меню выбора задач.
{
    Console.Clear();
    Console.WriteLine("1 - Программа для ");
    Console.WriteLine("2 - Программа для ");
    Console.WriteLine("3 - Программа для ");
    Console.WriteLine("4 - Программа для ");
    int numberOfTask = Prompt("Введите номер задачи");
    switch (numberOfTask)
    {
        case 1:
            Console.Clear();
            Task_53();
            break;

        case 2:
            Console.Clear();
            Task_55();
            break;

        case 3:
            Console.Clear();
            Task_57();
            break;

        case 4:
            Console.Clear();
            Task_59();
            break;

        default:
            Console.WriteLine("Номер задачи введен некорректно.");
            break;
    }
}


static int Prompt(string message) //Метод для упрощения ввода числа с консоли
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] FillArray(int firstDimension, int secondDimension) // Заполнение двумерного массива с заданной размерностью.
{
    int[,] arr = new int[firstDimension, secondDimension];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 11);
        }
    }
    return arr;
}

void ShowDuoArray(int[,] arr) // Вывод массива на экран.
{
    Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
    }
}

void ShowArray(int[] arr) // Вывод массива на экран.
{
    Console.WriteLine("\n");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

void Task_53()
{
    int[,] arr = FillArray(4, 4);
    ShowDuoArray(arr);

    for (int i = 0, temp = 0; i < arr.GetLength(0); i++)
    {
        temp = arr[arr.GetLength(0) - 1, i];
        arr[arr.GetLength(0) - 1, i] = arr[0, i];
        arr[0, i] = temp;
    }

    ShowDuoArray(arr);
    Console.ReadLine();
}

void Task_55()
{
    int[,] arr = FillArray(4, 4);
}

void Task_57()
{
    int[,] doubleArr = FillArray(4, 4);
    ShowDuoArray(doubleArr);

    int[] oneArr = ABC(doubleArr);
    ShowArray(oneArr);

    ShowResult(oneArr);

    Console.ReadLine();
}

int[] ABC(int[,] dArr)
{
    int[] oneArr = new int[dArr.GetLength(0) * dArr.GetLength(1)];
    int count = 0;

    for (int i = 0; i < dArr.GetLength(0); i++)
    {
        for (int j = 0; j < dArr.GetLength(1); j++)
        {
            oneArr[count] = dArr[i, j];
            count++;
        }
    }

    Array.Sort(oneArr);
    return oneArr;
}

void ShowResult(int[] arr)
{
    int element = arr[0];
    int count = 1;

    Console.WriteLine();
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == element) count++;
        else
        {
            Console.WriteLine($"Элемент {element} встречается {count} раз.");
            element = arr[i];
            count = 1;
        }
    }
    Console.WriteLine($"Элемент {element} встречается {count} раз.");
}

void Task_59()
{
    int[,] arr = FillArray(4, 4);
    ShowDuoArray(arr);

    int[] indexMinValue = FindMinEl(arr);
    DeleteRowsColumns(arr, indexMinValue);

    Console.ReadLine();
}

int[] FindMinEl(int[,] arr)
{
    int minValue = arr[0, 0];
    int[] indexMinValue = new int[2];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (minValue > arr[i, j])
            {
                minValue = arr[i, j];
                indexMinValue[0] = i;
                indexMinValue[1] = j;
            }

        }
    }
    return indexMinValue;
}

void DeleteRowsColumns(int[,] arr, int[] index)
{
    int[,] newArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int a = 0, b = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (index[0] == i) continue;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (index[1] == j) continue;

            newArr[a, b] = arr[i, j];
            b++;
        }
        a++;
        b = 0;
    }
    ShowDuoArray(newArr);
}
/*
Задача 55: 
Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
Задача 57: 
Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Задача 59: Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
*/