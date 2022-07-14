
int matrixWight = GetMatrixSize("ширину");
int matrixHeight = GetMatrixSize("высоту");

float[][] mass = new float[matrixHeight][];

for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new float[matrixWight];
}

int num = 1;

for(int i = 0;i < mass.Length;i++)
{
    for(int j = 0;j < mass[i].Length; j++)
    {
        mass[i][j] = GetNumbs(num);
        num++;
    }
}

Console.WriteLine("");

float result = 0;

Console.WriteLine("--Матрица--\n");
for (int i = 0; i < mass.Length; i++)
{
    for (int j = 0; j < mass[i].Length; j++)
    {
        Console.Write($"{mass[i][j]} ");
        if (i==j)
        {
            result+= mass[i][j];
        }
    }
    Console.WriteLine("");
}

Console.WriteLine($"\nсумма чисел главной диагонали = {result}");


int GetMatrixSize(string s)
{
    Console.WriteLine($"введите n -  {s} матрицы (n - челое число)");
    if (int.TryParse(Console.ReadLine(), out int value))
    {
        if (value != 0)
        {
            if (value < 0)
            {
                value *= -1;
                return value;
            }
            return value;
        }
        else
        {
            Console.WriteLine("резмер не должно быть равен 0");
        }
    }
    else
    {
        Console.WriteLine("некорректный ввод");
    }
    return GetMatrixSize(s);
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


