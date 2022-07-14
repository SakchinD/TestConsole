

while (true)
{
    Console.Clear();
    Console.WriteLine("1 для квадрата\n2 для прямоугольника\n3 для ромба\n4 для круга\n5 выход");
    string select = Console.ReadLine();
    switch (select)
    {
        case "1":
            CreateSqeare();
            break;

        case "2":
            CreateRectangle();
            break;

        case "3":
            CreateRhomb();
            break;

        case "4":
            CreateCircle();
            break;

        default:
            return;
    }
}
float GetNumbs()
{
    if (float.TryParse(Console.ReadLine(), out float value))
    {
        return value;
    }
    else
    {
        Console.WriteLine("некорректный ввод");
    }
    return GetNumbs();
}
void CreateSqeare()
{
    Console.WriteLine("Введите длину стороны");
    Square square = new(GetNumbs());
    
    while (true)
    {
        Console.WriteLine("1 для площади\n2 для периметра\n3 для валидации\n4 выход");
        string index = Console.ReadLine();
        switch (index)
        {
            case "1":
                Console.WriteLine($"площадь квадрата - {square.GetArea()}\n");
                break;
            case "2":
                Console.WriteLine($"периметр квадрата - {square.GetPerimeter()}\n");
                break;
            case "3":
                if (square.GetValidation())
                {
                    Console.WriteLine($"такой квадрат может существовать\n");
                }
                else
                {
                    Console.WriteLine($"такой квадрат не может существовать\n");
                }
                break;
            case "4":
                return;
            default:
                Console.WriteLine("Ошибка\n");
                break;
        }
    }
}
void CreateRectangle()
{
    Console.WriteLine("Введите длинну высоту");
    var h = GetNumbs();
    Console.WriteLine("Введите длинну ширины");
    Rectangle rec = new(GetNumbs(), h);

    while (true)
    {
        Console.WriteLine("1 для площади\n2 для периметра\n3 для валидации\n4 выход");
        string index = Console.ReadLine();
        switch (index)
        {
            case "1":
                Console.WriteLine($"площадь прямоугольника - {rec.GetArea()}\n");
                break;
            case "2":
                Console.WriteLine($"периметр прямоугольника - {rec.GetPerimeter()}\n");
                break;
            case "3":
                if (rec.GetValidation())
                {
                    Console.WriteLine($"такой прямоугольник может существовать\n");
                }
                else
                {
                    Console.WriteLine($"такой прямоугольника не может существовать\n");
                }
                break;
            case "4":
                return;
            default:
                Console.WriteLine("Ошибка\n");
                break;
        }
    }
}
void CreateRhomb()
{
    Console.WriteLine("Введите длину стороны 1");
    var s = GetNumbs();
    Console.WriteLine("Введите длину стороны 2");
    Rhomb rhomb = new Rhomb(s, GetNumbs());

    while (true)
    {
        Console.WriteLine("1 для площади\n2 для периметра\n3 для валидации\n4 выход");
        string index = Console.ReadLine();
        switch (index)
        {
            case "1":
                Console.WriteLine($"площадь ромба - {rhomb.GetArea()}\n");
                break;
            case "2":
                Console.WriteLine($"периметр ромба - {rhomb.GetPerimeter()}\n");
                break;
            case "3":
                if (rhomb.GetValidation())
                {
                    Console.WriteLine($"такой ромб может существовать\n");
                }
                else
                {
                    Console.WriteLine($"такой ромб не может существовать\n");
                }
                break;
            case "4":
                return;
            default:
                Console.WriteLine("Ошибка\n");
                break;
        }
    }
}
void CreateCircle()
{
    Console.WriteLine("Введите диаметр");
    Circle circle = new(GetNumbs());

    while (true)
    {
        Console.WriteLine("1 для площади\n2 для периметра\n3 для валидации\n4 выход");
        string index = Console.ReadLine();
        switch (index)
        {
            case "1":
                Console.WriteLine($"площадь круга - {circle.GetArea()}\n");
                break;
            case "2":
                Console.WriteLine($"периметр круга - {circle.GetPerimeter()}\n");
                break;
            case "3":
                if (circle.GetValidation())
                {
                    Console.WriteLine($"такой круг может существовать\n");
                }
                else
                {
                    Console.WriteLine($"такой круг не может существовать\n");
                }
                break;
            case "4":
                return;
            default:
                Console.WriteLine("Ошибка\n");
                break;
        }
    }
}
class Square 
{
    protected float _width;
    protected float _height;
    public Square(float width)
    {
        _width = width;
        _height = width;
    }

    public float GetArea()
    {
        return _width * _height;
    }
    public float GetPerimeter()
    {
        return (_width + _height) * 2;
    }
    public bool GetValidation()
    {
        if (_width > 0 && _height > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
class Rectangle : Square
{
    public Rectangle(float widht,float height) : base(widht)
    {
        _width = widht;
        _height = height;
    }
}
class Rhomb : Rectangle
{
    public Rhomb(float widht, float height) : base(widht, height)
    {
    }

    public new double GetArea()
    {
        var biss1 = Math.Sqrt(_width) + Math.Sqrt(_width);
        var biss2 = Math.Sqrt(_height) + Math.Sqrt(_width);
        return biss1 * biss2 / 2;
    }
}
class Circle 
{
    private float _diameter;
    public Circle(float diameter)
    {
        _diameter = diameter;
    }

    public double GetArea()
    {
        return Math.PI * Math.Pow(_diameter/2 , 2);
    }
    public double GetPerimeter()
    {
        return Math.PI * _diameter;
    }
    public bool GetValidation()
    {
        if (_diameter > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

