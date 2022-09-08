// Задача 1
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int FindSum(int a)
{
    int sum = 0;
    for (int current = 0; current < a; current++)
        sum += current;
    return sum; 
}
Console.WriteLine("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"sum of numbers from 1 to {num} is {FindSum(num)}");


//Задача 2 Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
int CountDigits(int num)
{
   int result = 0;
    while (num > 0)
    {
        result++;
        num /= 10;
        
    }
    return result;
}
Console.WriteLine("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Count of digits in {n} is {CountDigits(n)}");


//Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
int MultiNumbers (int num)
{
   int multi = 1;
   for (int i = num; i > 0; i--)
   multi*= i;
   return multi;

}

Console.WriteLine("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"multiplucation of numbers from 1 to {n} is {MultiNumbers(n)}");
*/

//Задача 4.Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
int[] CreateRandomArray(int n, int minVal, int maxVal)
{
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(minVal,maxVal +1);
    }
    return arr;
}
void PrintArray(int []arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++) 
        Console.Write($"{arr[i]}, ");
    Console.WriteLine($"\b\b]");
}
//PrintArray(CreateRandomArray(8,0,1));
int [] newArr = CreateRandomArray(8,0,1);
PrintArray(newArr);