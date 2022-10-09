// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine ("Введите первое число: "); // Вывод в терминал подсказки
int namber1 = Convert.ToInt32(Console.ReadLine()); // Ввод в терминале первого числа и присвоение его в переменную
Console.WriteLine ("Введите второе число: "); // Вывод в терминал подсказки
int namber2 = Convert.ToInt32(Console.ReadLine()); // Ввод в терминале второго числа и присвоение его в переменную
Console.WriteLine ("Введите третье число: "); // Вывод в терминал подсказки
int namber3 = Convert.ToInt32(Console.ReadLine()); // Ввод в терминале второго числа и присвоение его в переменную

int Max = 0; 

if (namber1 > namber2 && namber1 > namber3)
{
    Max = namber1;    
}
else if (namber1 < namber2 && namber2 > namber3)
{
    Max = namber2;
}
else
{
    Max = namber3;
}

Console.WriteLine($"{Max} максимальное из имеющихся!"); // вывод в терминал максимального значения