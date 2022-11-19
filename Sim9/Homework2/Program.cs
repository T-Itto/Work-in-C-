// Задача 2: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Clear();

int Prompt(string msg)
{
    System.Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void Even(int M, int N, int sum)
{
    if (N <= M)
    {
        Console.WriteLine("->" + sum);
        return;
    }
    sum += N;
    Even(M, N - 1, sum);
}

int M = Prompt("Введите начало диапозона М: ");
int N = Prompt("Введите конец диапозона N: ");

System.Console.WriteLine();
Even(M, N, 0);
System.Console.WriteLine();