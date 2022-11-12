// Задача 1: Задайте двумерный массив. 
// Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.

Console.Clear();

int Prompt(string msg)
{
    System.Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[,] CrieteMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] SortingMatrixDescending(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int counter = 0;
        for (int j = 1; j < matr.GetLength(1); j++)
        {

            if (matr[i, j - 1] < matr[i, j])
            {
                int newNumber = matr[i, j - 1];
                matr[i, j - 1] = matr[i, j];
                matr[i, j] = newNumber;
                counter++;
            }
            if (counter > 0)
            {
                j = 0;
                counter = 0;
            }
        }
    }
    return matr;
}

int[,] matrix = new int[Prompt("Введите количество строк: "), Prompt("Введите количество столбцов: ")];

CrieteMatrix(matrix);
PrintMatrix(matrix);
SortingMatrixDescending(matrix);
System.Console.WriteLine();
PrintMatrix(matrix);