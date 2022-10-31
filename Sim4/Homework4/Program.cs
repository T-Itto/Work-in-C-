// Задача *: Напишите программу, которая из массива случайных чисел. 
// Ищет второй максимум (число меньше максимального элемента, 
// но больше всех остальных). Постарайтесь сделать одним циклом
// [1, 3, 5, 6, 6, 4] -> 5

int Prompt(string msg)
{
    System.Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

System.Console.WriteLine();
int value = Prompt("Введите необходимую длинну массива: ");
System.Console.WriteLine();

int[] CrieteRandomArrey(int Length)
{
    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        int rnd = new Random().Next(10, 100);
        array[i] = rnd;
    }
    return array;
}

int MaxTwo(int[] array)
{  
    int maxOne = array[0];
    int maxTwo = array[0];
    for (int i = 0; array.Length >= i+1; i++)
    {
        if (maxOne < array[i])
        {
            maxOne = array[i];
        }
        while (maxTwo < array[i] && array[i] < maxOne)
        {
            maxTwo = array[i];
        }
    }
    return maxTwo;
}

void PrinterArray(int [] array)
{
    for (int i = 0; i <= array.Length-1; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] array = CrieteRandomArrey(value);
PrinterArray(array);
System.Console.WriteLine();
int maxTwo = Convert.ToInt32(MaxTwo(array));
System.Console.WriteLine($"Второе максимальное число в массиве -> {maxTwo}");