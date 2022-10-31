// Задача 1: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CrieteRandomArrey(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        int rnd = new Random().Next(10, 100);
        array[i] = rnd;
    }
    return array;
}

void PrinterArray(int [] array)
{
    for (int i = 0; i <= array.Length-1; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int Sum(int[] array)
{  
    int sum = 0;
    for (int i = 0; array.Length >= i+1; i++)
    {
        if (array[i] % 2 == 0)
        {
            sum += 1;
        }
    }
    return sum;
}

int[] array = CrieteRandomArrey(new Random().Next(0, 10));
PrinterArray(array);
System.Console.WriteLine();
System.Console.WriteLine(Sum(array));