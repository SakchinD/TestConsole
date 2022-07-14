
int pos = GetNumb("введите n - позиция числа в последовательности Фибоначчи(n - челое число, положительное)");
Console.WriteLine($"число {GetFibonachiNumb(pos)} находится в {pos} позиции ");

int GetFibonachiNumb(int n)
{
    if (n == 0 || n == 1)
    {
        return n;
    }
    return GetFibonachiNumb(n - 1) + GetFibonachiNumb(n - 2);
}

int GetNumb(string s)
{
    Console.WriteLine(s);
    if (int.TryParse(Console.ReadLine(), out int value))
    {
        if (value < 0)
        {
            Console.WriteLine("n - должно быть больше 0");
        }
        else
        {
            return value;
        }
    }
    else
    {
        Console.WriteLine("некорректный ввод");
    }
    return GetNumb(s);
}
