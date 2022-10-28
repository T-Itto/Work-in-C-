// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int Prompt(string message)
{
    Console.WriteLine(message);
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

bool AcceptableValue(int N)
{
    if (N < 10000 || N > 99999)
    {
        System.Console.WriteLine("Число не пятизначное! ");
        return false;
    }
    return true;
}

int Revers(int value)
{
    int rev = 0;
    while (value > 0)
    {
        Console.WriteLine(rev + " <> " + value);
        int number = value % 10;
        rev = rev * 10 + number;
        value = value / 10;
    }
    return rev;
}

int polindrome = Prompt("Введите пятизначное число: ");

if (!AcceptableValue((polindrome)))
{
    return;
}

if (Revers(polindrome) == polindrome)
{
    Console.WriteLine($"Полиндром -> {polindrome}");
}
else
{
    Console.WriteLine($"Не полиндром -> {polindrome}");
}

