// Задача 3: * Найдите максимальное значение в матрице по каждой строке, 
// получите сумму этих максимумов. Затем найдите минимальное значение по каждой колонке,
// получите сумму этих минимумов. Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2
// * по желанию

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

int DifferenceMaxMimMatrix(int[,] matr)
{
    int MinInMatrix(int[,] matr, int line)
    {
        int a = 0;
        int min = matr[line, a];
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[line, j] < min)
            {
                min = matr[line, j];
            }
            a++;
        }
        return min;
    }

    int MaxInMatrix(int[,] matr, int line)
    {
        int a = 0;
        int max = matr[line, a];
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[line, j] > max)
            {
                max = matr[line, j];
            }
            a++;
        }
        return max;
    }

    int sumMax = 0;
    int sumMin = 0;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int earlyMax = sumMax;
        int earlyMin = sumMin;
        sumMax += MaxInMatrix(matr, i);
        sumMin += MinInMatrix(matr, i);
        if (i > 0)
        {
            Console.WriteLine($"Суммы максимальных -> {earlyMax}+{sumMax - earlyMax}={sumMax}");
            Console.WriteLine($"Суммы минимальных -> {earlyMin}+{sumMin - earlyMin}={sumMin}");
        }
    }
    int difference = sumMax - sumMin;
    Console.WriteLine($"Разница сумм максимумов и максимувов -> {sumMax}-{sumMin}={difference}");
    return difference;
}

int[,] matrix = new int[Prompt("Введите количество строк: "), Prompt("Введите количество столбцов: ")];

CrieteMatrix(matrix);
PrintMatrix(matrix);
DifferenceMaxMimMatrix(matrix);
