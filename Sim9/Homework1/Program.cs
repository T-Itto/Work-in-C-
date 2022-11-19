// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

Console.Clear();

int Prompt(string msg)
{
    System.Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void Even(int M, int N)
{
    if (N <= M)
    {
        return;
    }
    Even(M, N - 1);
    if (N % 2 == 0)
    {
        System.Console.Write(N + " ");
    }

}

int M = Prompt("Введите начало диапозона М: ");
int N = Prompt("Введите конец диапозона N: ");

Even(M, N);
System.Console.WriteLine();