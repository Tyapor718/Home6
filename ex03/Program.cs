//Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int ReadInt(string msg)
{
    System.Console.Write($"{msg} > ");
    return int.Parse(Console.ReadLine());
}
int[,] CreateArray(int masRows, int masColumns)
{
    int[,] array = new int[masRows, masColumns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-10, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}  ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
void PrintArrayMas(double[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write($"{array[i]}  ");
    }
    System.Console.WriteLine();
}
double[] Arithmeticmean(int[,] array)
{
    double average = 0;
    double[] mass = new double[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double s = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            s = s + array[j, i];
        }
        average = s / array.GetLength(0);
        mass[i] = average;
    }
    return mass;
}
int rowMas = ReadInt("Количество строк массива  >");
int columnMas = ReadInt("Количесвто столбцов массива >");
int[,] massive = CreateArray(rowMas, columnMas);
PrintArray(massive);
PrintArrayMas(Arithmeticmean(massive));