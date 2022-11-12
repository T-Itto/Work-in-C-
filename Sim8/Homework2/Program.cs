// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int MinSumInLine(int[,] matr)
{
    int sumMin = 0;
    int line = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
        }
        if (sumMin == 0)
        {
            sumMin = sum;
        }
        if (sumMin > sum)
        {
            sumMin = sum;
            line = i+1;
        }
    }
    return line;
}

int line = Prompt("Введите количество строк: ");
int columns = Prompt("Введите количество столбцов: ");

if (columns != line)
{
    int[,] matrix = new int[line, columns];
    CrieteMatrix(matrix);
    PrintMatrix(matrix);
    Console.WriteLine();
    Console.WriteLine($"Строка с наменьшей суммой элементов -> {MinSumInLine(matrix)}");
}
else
{
    Console.WriteLine("Двумерный массив не прямоугольный!");
}