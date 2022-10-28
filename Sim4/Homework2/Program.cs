// Задача 2: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе. Функция должна на вход принимать число, а выдавать сумму его цифр
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Module(int module)
{
    if (module < 0)
    {
        module = -module;
    }
    return module;
}

int Prompt(string message)
{
    Console.WriteLine(message);
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int NumberDozens(int number) 
{
    number = Module(number);
    int i = 1;
    while (number >= 10)
    {
        number /= 10;
        i++;
    }
    return i;
}

int SumValue (int number)
{
    int sum = 0;
    while (number >= NumberDozens(number))
    {
        int value = 0;
        value = value + number % 10;
        sum = sum + value;
        number /= 10;
    }
    return sum;
}

int value = Prompt("Введите число: ");

System.Console.WriteLine(SumValue(value));