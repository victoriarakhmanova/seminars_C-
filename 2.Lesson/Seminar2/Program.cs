//Задача 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
int FindBiggerDigit(int number)

{
    int ed = number % 10;
    int dec = number / 10;

    int result;
    if(ed > dec) result = ed;
    else result = dec;

    return result;
}

int randNumber = new Random().Next(10,100); // ВЕРХНИЙ ПРЕДЕЛ НЕ УЧИТЫВАЕТСЯ ПРИ ГЕНЕРАЦИИ
int biggerDigit = FindBiggerDigit(randNumber);

Console.WriteLine($"Bigger digit of {randNumber} is {biggerDigit}");



// Задача 2. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int GetNumber() => new Random().Next(100,1000);
int GetFinalNumber(int number)
        {
            Console.WriteLine(number);
            int ed = number % 10;
            int hundreds = number / 100;
            return (hundreds*10+ed);
        }
        static void Main(string[] args)
        
        // Main starts here
       

            Console.WriteLine(GetFinalNumber(GetNumber()));
*/
int Pack(int num)
{
    int high, low, res;

    high = num/100;
    low = num % 10;
    res = high*10+ low;
    return res;
}

int randNum = new Random().Next(100, 1000);
int res = Pack(randNum);

Console.WriteLine($"Из трехзначного числа {randNum} получается двухзначное {res}");
// Задача 3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.
/*

void CheckNum(int x, int y)
{
    int res = x % y;
    if(res == 0)
    Console.WriteLine($"{y} кратно {x}");
    else
    Console.WriteLine($"Остаток от деления равно {res}");
}

Console.WriteLine("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
CheckNum(x, y);

int GetNumber() => Convert.ToInt32(Console.ReadLine());
void CheckPow(int a, int b)
        {
            int bPow = (b % a);
            if (bPow == 0)
                Console.WriteLine("{0} % {1} = {2}", b, a, bPow);
            else Console.WriteLine(b % a);
        }
        
        
            // Main starts here
            Console.Clear();

            Console.WriteLine("input first number:");
            int a = GetNumber();
            Console.WriteLine("input second number:");
            int b = GetNumber();
            CheckPow(a, b);


// Задача 4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

bool CheckNum(int a, int b, int c)
{
    if((a%b ==0) & (a%c) ==0)
    return true;
    //else
    return false;

}
Console.Clear();
Console.WriteLine("Enter the number for check");
int a  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the first number to divide ");
int b  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number to divide");
int c  = Convert.ToInt32(Console.ReadLine());

bool result = CheckNum(a,b,c);

if(result)
    Console.WriteLine($"{a} is divided on {b} and {c}");
else
    Console.WriteLine($"{a} is not divided on {b} and {c}");    

*/

// Задача 5. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
/*
int CompareNum (int x, int y)
{
    int quad1 = x*x;
    int quad2 = y*y;

    if(x == quad2)
    Console.WriteLine($"{x} is a quad of {y}");

    if(y == quad1)
    Console.WriteLine($"{y} is a quad of {x}");
    return (x,y);
}
Console.WriteLine("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
CompareNum(x, y);
*/