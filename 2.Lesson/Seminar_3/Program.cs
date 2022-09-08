//Задача 1
/*
//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
int FindQuadrant(double x, double y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}
Console.WriteLine("Input X cootdinate: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input Y cootdinate: ");
double yA = Convert.ToDouble(Console.ReadLine());

int quadrant = FindQuadrant(xA, yA);
Console.WriteLine("Number of quadrant is " + quadrant);

//Задача 2.
//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

void CoordByQuadrant(int quadrant)
{
    string output = "некорректный ввод данных";
    if(quadrant == 1)
    output = ($"Для четверти 1 x > 0, y > 0 ");
     if(quadrant == 2)
    output = ($"Для четверти 2 x < 0, y > 0 ");
     if(quadrant == 3)
    output = ($"Для четверти 3 x < 0, y < 0 ");
     if(quadrant == 4)
    output = ($"Для четверти 4 x > 0, y < 0 ");
    Console.WriteLine(output);
}
Console.Write("Введите номер четверти: ");
int quad = Convert.ToInt32(Console.ReadLine());
CoordByQuadrant(quadrant);


void isQuadrant(int N)
{
    if(N == 1) Console.WriteLine($"В {N} четверти X - положительные и Y - положительные.");
    if(N == 2) Console.WriteLine($"В {N} четверти X - отрицательные и Y - положительные.");
    if(N == 3) Console.WriteLine($"В {N} четверти X - отрицательные и Y - отрицательные.");
    if(N == 4) Console.WriteLine($"В {N} четверти X - положительные и Y - отрицательные.");
    if (N <1 || N > 4) Console.WriteLine($"Введите существующий номер четверти.");
}
Console.Write("Input number of quadrant: ");
isQuadrant(Convert.ToInt32(Console.ReadLine()));





//Задача 3
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

void SquareTable (int n)
{
    int i = 1;
    while(i <= n)
    {
        Console.WriteLine($"квадрат числа {i} = {i*i}");
        i ++;

    }
}
Console.WriteLine("Enter the number");
SquareTable(Convert.ToInt32(Console.ReadLine()));
*/
//Задача 4.
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

int Point3D(int XValue, int YValue, int ZValue)
    {
        //Установка указанных значений
       int x = XValue;
       int y = YValue;
        int z = ZValue;
    }
 
    //Конструктор без аргументов, создает точку в начале координат
    Point3D()
    {
        //Установка нулевых значений
        x = 0;
        y = 0;
        z = 0;
    }
 
    //Свойство, для установки/получения значения поля "x"
    public int X { get { return x; } set { x = value; } }
    //Свойство, для установки/получения значения поля "y"
    public int Y { get { return y; } set { y = value; } }
    //Свойство, для установки/получения значения поля "z"
    public int Z { get { return z; } set { z = value; } }
 
    private int x; //Координата х
    private int y; //Координата у
    private int z; //Координата z
}

Console.Write("Введите x координату 1 точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y координату 1 точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите x координату 2 точки: ");
double x2= Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y координату 2 точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Длина отрезка ({x1}, {y1}) ({x2}, {y2}) равна {LenSegment(x1, y1, x2, y2)} ");


