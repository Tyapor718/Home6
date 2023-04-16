//Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или 
//же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 7 -> такого числа в массиве нет
//1, 1 -> 1
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
            array[i, j] = rnd.Next(-10, 100);
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
void Find(int[,] array, int numRow, int numCol)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == numRow - 1)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                if (j == numCol - 1)
                {
                    System.Console.Write($" Элемент на искомой позиции {array[i, j]}  ");
                }
        }

    }
    System.Console.Write(" Искомой позиции нет в массиве ");
}

int rowMas = ReadInt("Количество строк массива  >");
int columnMas = ReadInt("Количесвто столбцов массива >");
int[,] massive = CreateArray(rowMas, columnMas);
PrintArray(massive);
int number1 = ReadInt("Строка в массиве  >");
int number2 = ReadInt("Столбец в массиве  >");
Find(massive, number1, number2);




