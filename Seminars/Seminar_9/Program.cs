// //Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N

// void ShowNums(int n)
// {
//     if(n>1) ShowNums(n -1);

//     Console.Write(n + " ");
// }
// ShowNums(5);

// void ShowNums1(int n)
// {
//     Console.WriteLine(n + " ");
//     if(n>1) ShowNums(n -1);


// }
// ShowNums1(5);

//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/*
int SumOfDigits(int n)
{
    if (n > 0) return SumOfDigits(n / 10) + n % 10;
    else return 0;
}
Console.WriteLine(SumOfDigits(5734));

//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
void OutputNums(int M, int N)
{
    Console.Write(M + " ");
    if (M < N) OutputNums(M + 1, N);
    if (M > N) OutputNums(M - 1, N);
    Console.Write(M + " ");

    
}
OutputNums(8, 3);


void OutputNums1(int M, int N)
{
    Console.Write(M + " ");
    if (M < N) OutputNums1(M + 1, N);

    
}
OutputNums1(3, 8);

void ShowNumDiapason (int n, int m)
{
    

    if (Math.Max(n,m) != Math.Min(n,m) )ShowNumDiapason(Math.Max(n,m) - 1, Math.Min(n,m));
    Console.Write($"{Math.Max(n,m)}");
  
}
ShowNumDiapason(3,8);
*/

//Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

double NumPower(int a, int b)
{
    if (b >= 1) return NumPower(a, b - 1) * a;
    if (b <= -1) return NumPower(a, b + 1) / a;
    else return 1;
}
Console.Write(NumPower(2,4));