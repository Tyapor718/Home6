//Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int ReadInt(string msg)
{
    System.Console.Write($"{msg} > ");
    return int.Parse(Console.ReadLine());
}

double[,] CreateArray(int masRows, int masColumns)
{
    double[,] array = new double[masRows, masColumns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble()*100;
        }
    }
    return array;
}

void PrintArray(double[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]:F2}  ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}



int rowMas = ReadInt("Количество строк массива  >");
int columnMas = ReadInt("Количесвто столбцов массива >");
double[,] massive = CreateArray(rowMas, columnMas);
PrintArray(massive);

