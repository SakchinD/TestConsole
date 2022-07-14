double num = GetNumb();
int power = GetPower();

Console.WriteLine($"{num} в степери {power} = {GetDegreeResult(num,power)}");

double GetDegreeResult(double value, int power)
{
    if (power == 0)
    {
        return 1;
    }
    if (power > 0)
    {
        return GetDegreeResult(value, power - 1) * value;
    }
    return 1.0 / GetDegreeResult(value, -power);
}

int GetPower()
{
    Console.WriteLine("введите n - для степени(n - челое число)");
    if (int.TryParse(Console.ReadLine(), out int value))
    {
        return value;
    }
    else
    {
        Console.WriteLine("некорректный ввод");
    }
    return GetPower();
}

double GetNumb()
{
    Console.WriteLine($"введите число для взведения в степень");
    if (double.TryParse(Console.ReadLine(), out double value))
    {
        return value;
    }
    else
    {
        Console.WriteLine("некорректный ввод");
    }
    return GetNumb();
}
