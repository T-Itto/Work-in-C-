// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int[] array = CrieteRandomArrey(new Random().Next(0, 10));
PrinterArray(array);
System.Console.WriteLine();
System.Console.WriteLine(Sum(array));