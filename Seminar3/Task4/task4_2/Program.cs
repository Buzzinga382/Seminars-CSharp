/*
Задача 22: Напишите программу, которая принимает на
 вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
 int[] array =  
5 -> 1, 4, 9, 16, 25. 2 -> 1,4
*/

Console.WriteLine("Please enter some number");

bool isParse = int.TryParse(Console.ReadLine(), out int num);

int [] sqareLine = GetSqareLine(num);

PrintArray(sqareLine);

if (!isParse)
{
    Console.WriteLine("Incorrect input");
    return;
}

int [] GetSqareLine (int num)
{
    int [] array = new int [num];
    int index = 0;
    while (index < array.Length)
    {
        array[index] = (int)((index + 1 ) * (index + 1 ));
        index++;
    }
    return array;
}

void PrintArray (int [] arr)
{
    int index = 0;
    while (index < arr.Length)
    {
        Console.Write($"{arr[index]} ");
        index++;
    }
    Console.WriteLine();
}