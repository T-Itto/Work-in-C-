// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int Prompt (string msg)
{
    System.Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = Prompt ("Введите значение N: ");
for (int i = 0; number >= i; i++)
{
    System.Console.WriteLine($"{i}^3 = " + Math.Pow(i, 3));
}