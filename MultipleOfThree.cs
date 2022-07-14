
float[] numbs = new float[GetLenght()];

for (int i = 0; i < numbs.Length; i++)
{
    numbs[i] = GetNumbs(i+1);
}
Console.WriteLine("");
float result = 0;

for(int i = 0;i < numbs.Length; i++)
{
    if(numbs[i] % 3 == 0)
    {
        Console.WriteLine($"{numbs[i]} кратное 3");
        result+= numbs[i];
    }
}

Console.WriteLine($"\nсумма чисел кратных 3 = {result}");

int GetLenght()
{
    Console.WriteLine("введите n - сколько чисел хотите ввести для сравнения(n - челое число)");
    if (int.TryParse(Console.ReadLine(), out int value))
    {
        if (value <= 0)
        {
            Console.WriteLine("n должно быть больше 0");
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
    return GetLenght();
}

float GetNumbs(int i)
{
    Console.WriteLine($"введите {i} число");
    if (float.TryParse(Console.ReadLine(), out float value))
    {
        return value;
    }
    else
    {
        Console.WriteLine("некорректный ввод");
    }
    return GetNumbs(i);
}
