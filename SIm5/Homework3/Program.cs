// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int Prompt(string msg)
{
    System.Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int value = Prompt("Введите необходимую длинну массива: ");
System.Console.WriteLine();

int[] CrieteArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"Введите вещественное число в индекс {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int Sum(int[] array)
{  
    int max = array[0];
    int min = array[0];
    for (int i = 0; array.Length >= i+1; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
        if (min > array[i])
        {
            min = array[i];
        }
    }
    System.Console.WriteLine();
    return max - min;
}

int sumArray = Convert.ToInt32(Sum(CrieteArrey(value)));
System.Console.WriteLine($"Разница между максимальным и минимальным элементами -> {sumArray}");