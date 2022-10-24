// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// Не использовать строки для расчета.
// (Знаю что не нужно делать лишнего, но очень хотелось добавил универсальность диапазону целых чисел)

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
                                        // переменную на замену 1000 и добавить метод выбора нужного нам числа 
bool ValidateNumber(int num)
{
    bool condition = num > 9 && num < DozensMultiplied(NumberDozens(number)); // Диапазон чисел введённого значения
                                                                               // для универсальности можно добавить переменную на замену 1000
    if (condition)
    {
        return true;
    }
    System.Console.WriteLine("Это не трёхзначное число!");
    return false;
}

number = Module(number);
if (ValidateNumber(number))
{
    int resultNumber = 0;
    resultNumber = (number * 10 / (DozensMultiplied(NumberDozens(number))/10)) % 10; // отрезаем все числа до второй и забираем её
    Console.WriteLine($"Вторая цифра данного числа: {resultNumber}");
}
