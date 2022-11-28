/*
Задача 22: Напишите программу, которая принимает на
 вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
 int[] array =  
5 -> 1, 4, 9, 16, 25. 2 -> 1,4
*/

int num = InputInt();

int[] squaresLine = GetSqaresLine(num);

PrintArray(squaresLine);

// А дальше идут методы:

int InputInt()
{
    Console.WriteLine("Введите целое число");
    bool isNum = int.TryParse(Console.ReadLine(), out int num);

    if (isNum)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Введите корректное значение");
        return -1;
    }
}

int [] GetSqaresLine(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (int)(Math.Pow(i + 1, 2));
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}