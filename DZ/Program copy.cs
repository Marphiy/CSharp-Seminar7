void Fill2DArray(int[,] arr, int StartNum, int FinishNum)
{
    Random rand = new Random();
    FinishNum++;
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = rand.Next(StartNum, FinishNum);

        }
    }
}

void Fill2DDoubleArray(double[,] arr, int StartNum, int FinishNum)
{
    Random rand = new Random();
    FinishNum++;
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = Math.Round(rand.NextDouble() * 10, 1);

        }
    }
}

void Print2DArray(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void Print2DDoubleArray(double[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void Zadacha46()
{
    //Задайте двумерный массив размером m×n,
    //заполненный случайными целыми числами.
    Random rand = new Random();
    int rows = rand.Next(2, 10);
    int columns = rand.Next(2, 10);
    int[,] nums = new int[rows, columns];
    Fill2DArray(nums, -9, 10);
    Print2DArray(nums);

}

void Zadacha47()
{
    /*Задайте двумерный массив размером m×n,
    заполненный случайными вещественными числами,
    округлёнными до одного знака.*/
    Random rand = new Random();
    int rows = rand.Next(2, 10);
    int columns = rand.Next(2, 10);
    double[,] nums = new double[rows, columns];
    Fill2DDoubleArray(nums, 0, 20);
    Print2DDoubleArray(nums);
}

void Zadacha48()
{
    /*Задайте двумерный массив размера m на n,
    каждый элемент в массиве находится по формуле: A = m+n.
    Выведите полученный массив на экран.*/

    Random rand = new Random();
    int rows = rand.Next(2, 10);
    int columns = rand.Next(2, 10);
    int[,] nums = new int[rows, columns];
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        for (int j = 0; j < nums.GetLength(1); j++)
        {
            nums[i, j] = i + j;
        }
    }
    Print2DArray(nums);
}

void Zadacha49()
{
    /*Задайте двумерный массив. Найдите элементы, у
    которых оба индекса чётные, и замените эти элементы на их
    квадраты.*/
    Random rand = new Random();
    int rows = rand.Next(2, 10);
    int columns = rand.Next(2, 10);
    int[,] nums = new int[rows, columns];
    Fill2DArray(nums, 0, 100);
    Print2DArray(nums);
    for (int i = 1; i < nums.GetLength(0); i++)
    {
        for (int j = 1; j < nums.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) nums[i, j] = (int)Math.Pow(nums[i, j], 2);
        }
    }
    Console.WriteLine();
    Print2DArray(nums);

}

void Zadacha50()
{
    /*Напишите программу, которая на вход
    принимает позиции элемента в двумерном массиве, и
    возвращает значение этого элемента или же указание,
    что такого элемента нет.*/
    Random rand = new Random();
    int rows = rand.Next(2, 10);
    int columns = rand.Next(2, 10);
    int[,] nums = new int[rows, columns];
    Fill2DArray(nums, 0, 100);
    Print2DArray(nums);
    Console.Write("Введите № строки массива: ");
    int row = Convert.ToInt32(Console.ReadLine()) - 1;
    Console.WriteLine();
    Console.Write("Введите № столбца массива: ");
    int column = Convert.ToInt32(Console.ReadLine()) - 1;
    Console.WriteLine();
    if (row < nums.GetLength(0) && column < nums.GetLength(1))
    {
        Console.WriteLine($"В ячейке с адресом {row}: {column} лежит число {nums[row, column]}");
    }
    else Console.WriteLine("Такой ячейки не существует!");
}

void Zadacha51()
{
    /* Задайте двумерный массив. Найдите сумму
    элементов, находящихся на главной диагонали (с индексами
    (0,0); (1;1) и т.д.*/
    Random rand = new Random();
    int rows = rand.Next(2, 10);
    int columns = rand.Next(2, 10);
    int[,] nums = new int[rows, columns];
    Fill2DArray(nums, 0, 10);
    Print2DArray(nums);
    int summ = 0;
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        for (int j = 0; j < nums.GetLength(1); j++)
        {
            if (i == j) summ += nums[i, j];
        }
    }
    Console.WriteLine($"Сумма элементов на главной диагонали массива = {summ}");
}

void Zadacha52()
{
    /*Задайте двумерный массив из целых чисел.
    Найдите среднее арифметическое элементов в каждом
    столбце.*/

    Random rand = new Random();
    int rows = rand.Next(2, 10);
    int columns = rand.Next(2, 10);
    int[,] nums = new int[rows, columns];
    Fill2DArray(nums, 0, 9);
    Print2DArray(nums);
    
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        int SrArfm = 0;
        for (int i = 0; i < nums.GetLength(0); i++)
        {
            SrArfm += nums[i, j];
        }
        Console.WriteLine($"Среднее арифметическое столбца №{j + 1} = {SrArfm / nums.GetLength(0)}");
    }

}

//Zadacha46();
//Zadacha47();
//Zadacha48();
//Zadacha49();
//Zadacha50();
//Zadacha51();
//Zadacha52();
