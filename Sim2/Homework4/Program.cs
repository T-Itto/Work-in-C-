// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

int Prompt(string message)
{
    Console.WriteLine(message);
    int namber = Convert.ToInt32(Console.ReadLine());
    return namber;
}


int day = Prompt("Введите день недели: ");
if (day >= 1 && day <= 7)
{
    if (day <= 5)
    {
        Console.WriteLine("Это будний день");
    }
    else
    {
        Console.WriteLine("Это выходной");
    }
}
else
{
    Console.WriteLine("Это не день недели");
}