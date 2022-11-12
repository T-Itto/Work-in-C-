// Задача 3: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

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

int[,] CompositionMatrix(int[,] matrOne, int[,] matrTwo)
{
    int[,] matr = new int [matrTwo.GetLength(1), matrOne.GetLength(0)];
    for (int i = 0; i < matrOne.GetLength(0); i++)
    {
        for (int k = 0; k < matrTwo.GetLength(1); k++)
        {
            matr[i, k] = 0;
            for (int j = 0; j < matrOne.GetLength(1); j++)
            {
                matr[i, k] += matrOne[i,j] * matrTwo[j,k];
            }
        }
    }
    return matr;
}

int lineOne = Prompt("Введите количество строк первой матрицы: ");
int columnsOne = Prompt("Введите количество столбцов первой матрицы: ");
int lineTwo = Prompt("Введите количество строк второй матрицы: ");
int columnsTwo = Prompt("Введите количество столбцов второй матрицы: ");

if (columnsOne == lineTwo)
{
    int[,] matrixOne = new int[lineOne, columnsOne];
    int[,] matrixTwo = new int[lineTwo, columnsTwo];
    CrieteMatrix(matrixOne);
    CrieteMatrix(matrixTwo);
    Console.WriteLine("Матрица-1");
    PrintMatrix(matrixOne);
    Console.WriteLine("Матрица-2");
    PrintMatrix(matrixTwo);
    int[,] ansver = CompositionMatrix(matrixOne, matrixTwo);
    PrintMatrix(ansver);
}
else
{
    Console.WriteLine("Количество столбцов первой матрицы не равно количеству строк второй!");
}