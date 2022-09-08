// Задача 0. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
    }
    return newArray;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}


int[] ReverseArray(int[] array)
{   //for (int i = 0, i< array.Length; i++)
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
    // int temp = array[i];
    // array[i] = array[array.Length - 1 - i];
    // array[array.Length - 1 - i] = temp;
    int temp = array[i];
    array[i] = array[j];
    array[j] = temp;

}
return array;

}
Console.Write("Enter the size of array:");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateRandomArray(size, min, max);
PrintArray(newArray);
PrintArray(ReverseArray(newArray));

//Задача 1.Напишите программу, которая будет преобразовывать десятичное число в двоичное.
string ToBin (int Dec)
{
    string res = "";
    while(Dec>0)
    {
        res = Convert.ToString(Dec%2) + res;
        Dec/=2;
    }
    return res;
}
Console.WriteLine("Введите число в десятичной системы для конвертациисв двоичную:c");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{x}=> {ToBin(x)}");

//Задача 2.Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[] ShowFib(int a, int b, int n)
{
    int[] x = new int[n];
    x[0] = a;
    x[1] = b;
    for (int i = 2; i < n; i++)
        x[i] = x[i-2] + x[i-1];
     return x;
}
Console.Write("введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество чисел ряда: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintArray(ShowFib(a,b,n));
*/

//Задача 3. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник сo сторонами такой длины.
bool CheckTriangle(int a, int b, int c)
{
    // if(((a + b) > c) && ((a + c) > b) && ((c + b) > a)) return true;
    // else return false;
    return (a+b)>c && (a+c)>b && (c+b)>a;
}
Console.WriteLine("Введите длину первой стороны треугольника: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину второй стороны треугольника: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину третьей стороны треугольника: ");
int c = Convert.ToInt32(Console.ReadLine());

if(CheckTriangle(a,b,c))
    Console.WriteLine($"Треугольник со сторонами {a}, {b} и {c} существует");
else
    Console.WriteLine($"Треугольник со сторонами {a}, {b} и {c} не существует");