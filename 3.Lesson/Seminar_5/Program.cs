//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue,maxValue+1);
    }
    return newArray;

}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}

int FindNegativeSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if(array[i] < 0) sum += array[i];
    return sum;
}



Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min posible value: ");
int min = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Input max posible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);
Console.WriteLine($"Sum of negative elements is {FindNegativeSum(newArray)}");



//Напишите программу для замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.


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
int[] ChangeOppositeArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)

        array[i] = array[i] * (-1);

    return array;
}
Console.WriteLine("Enter the size of array:");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
PrintArray(newArray);
Console.WriteLine($"Change opposite numbers in ");
PrintArray(ChangeOppositeArray(newArray));
*/



//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
int[] CreateRandomArray(int size, int min, int max)

{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min,max+1);

    }
    return newArray;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
   Console.Write(array[i] + " ");
   Console.WriteLine();
}
bool FindNumber(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == num) return true;            
    }
        return false;
   

}
Console.WriteLine("Enter the size of array:");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max value: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number to find: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
PrintArray(newArray);

if(FindNumber(newArray,number)) Console.WriteLine("The number is present");
else Console.WriteLine("The number is absent");

//Задайте одномерный массив из 15 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]
int[] CreateRandomArray(int size, int min, int max)
{
    int[]newArray = new int[size];
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

int ArrayOfSegment(int[] array, int minOfSeg, int maxOfSeg)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if((array[i] >= minOfSeg) && (array[i]<= maxOfSeg))
            count++;
    }
    return count;

}
Console.Clear();
Console.WriteLine("Enter the number of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter min value of array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max value of array: ");
int max = Convert.ToInt32(Console.ReadLine());

int[]myArray = CreateRandomArray(size,min,max);
PrintArray(myArray);
Console.WriteLine("Enter min value of monitoring segment: ");
int minOfSeg = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max value of monitoring segment: ");
int maxOfSeg = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"The numer of elements is {ArrayOfSegment(myArray, minOfSeg, maxOfSeg)}");
*/

//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//   [1 2 3 4 5] -> 5 8 3
//  [6 7 3 6] -> 36 21
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
    }
    return newArray;

}
void ShowArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");

    }
    Console.WriteLine();
}

int MultiPairs(int[] array, int res)
{
    for (int i = 0; i < (array.Length / 2 + array.Length % 2); i++) //нахождение половины массива,чтобы вывод нового массива делался до половины исходного,а не до конца.
    {
        res = array[i] * array[array.Length - i - 1];
        Console.Write(res + " ");

    }
    return res;
}
Console.Clear();
Console.Write("Input the size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("inout max value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArr = CreateRandomArray(size, min, max);
ShowArray(myArr);
int res = 0;
MultiPairs(myArr, res);