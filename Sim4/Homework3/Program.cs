// Задача 3: Напишите программу, которая задаёт массив 
// из 8 случайных элементов и выводит их на экран. Сделать через функции.
// 1, 2, 5, 7, 19, 6, 7, 8

int[] CrieteRandomArrey()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        int rnd = new Random().Next(0, 100);
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

System.Console.WriteLine();
int[] array = CrieteRandomArrey();
PrinterArray(array);