// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Не использовать строки для расчета.

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

int NumberDozens(int number) // Подсчитывает кол-во десятков в числе
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

int DozensMultiplied(int dozens) // Преобразует введённое значение в десятки
{
    int number = 1;
    while (dozens >= 1)
    {
        number *= 10;
        dozens -= 1;
    }
    return number;
}

Console.WriteLine("Давайте найдем вторую цифру числа!");
int number = Prompt("Введите число: "); // для универсальности присвоить полученное значение в новую 

bool ValidateNumber(int num)
{
    bool condition = num > 99 && num < DozensMultiplied(NumberDozens(number)); // Диапазон чисел введённого значения
    if (condition)
    {
        return true;
    }
    System.Console.WriteLine("Третьей цифры нет!");
    return false;
}

number = Module(number);
if (ValidateNumber(number))
{
    int resultNumber = 0;
    resultNumber = (number * 100 / (DozensMultiplied(NumberDozens(number))/10)) % 10; // отрезаем все числа до третьей и забираем её
    Console.WriteLine($"Третья цифра данного числа: {resultNumber}");
}