// Задача 3: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

int Prompt(string msg)
{
    System.Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

static int Ackerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackerman(m - 1, 1);
    }
    else if (n > 0)
    {
        return Ackerman(m - 1, Ackerman(m, n - 1));
    }
    else
    {
        return 1;
    }
}

int m = Prompt("Введите начало диапозона М: ");
int n = Prompt("Введите конец диапозона N: ");

System.Console.WriteLine();
System.Console.WriteLine($"{Ackerman(m, n)}");