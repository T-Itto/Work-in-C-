// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 
// Не использовать строки для расчета.

int rnd = new Random().Next(100, 1000); // диапозон рандомных значений
Console.WriteLine($"Случайное число - {rnd}");
Console.WriteLine("Удаление второй цифры");
Console.WriteLine($"{rnd / 100 * 10}{rnd % 10}");