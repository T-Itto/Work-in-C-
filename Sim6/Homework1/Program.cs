// Задача 1: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Разделить ввод данных, от расчета данных (Одна функция вводит данные, другая функция подсчитывает количество положительных)
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string msg)
{
    System.Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int GreaterZero(int[] array)
{
    int N = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            N++;
        }
    }
    return N;
}

int[] CrieteArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"Введите число {i+1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrinterArray(int [] array)
{
    for (int i = 0; i <= array.Length-1; i++)
    {
        Console.Write($"{array[i]}\t");
    }
}

int[] array = CrieteArray(Prompt("Сколько чисел вы бы хотели ввести: "));
PrinterArray(array);
System.Console.WriteLine("Чисел больше 0 ->" + " " + GreaterZero(array));