// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B (и в нулевую степень). Использовать свои функции, не использовать Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

double DegreeValue(int A, int B)
{
    if (B >= 1)
    {
        int sum = 1;
        for (int i = B; i >= 1; i--)
        {
            sum = sum * A;
        }
        return sum;
    }
    else
    {
        A /= A;
    }
    return Convert.ToDouble(A);
}

int valueA = Prompt("Введите число А: ");
int valueB = Prompt("Введите число B: ");

System.Console.WriteLine(valueA + "^" + valueB + " = " + DegreeValue(valueA, valueB));