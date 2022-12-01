// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.WriteLine("Please enter number");

bool isParsed = int.TryParse(Console.ReadLine(), out int num);

if (!isParsed || num < 1)
{
    Console.WriteLine("Incorrect input");
    return;
}

int[] userArray = ArrayFill(num);

PrintArray(userArray);

int[] ArrayFill(int num)
{
    Random random = new Random();
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 2);
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