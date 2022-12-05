/* Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]
Найдите сумму положительных и отрицательных элементов массива */

int[] array = GenerateArray(-9, 9, 12);
PrintArray(array);
int sumPositive = GetSumPositiveNumbersInArray(array);
int sumNegative = GetSumNegativeNumbersInArray(array);

Console.WriteLine($"Сумма положительных чисел равна {sumPositive}, сумма отрицательных чисел равна {sumNegative}");

void PrintArray(int[] array)
{
    string message = string.Join(", ", array);
    Console.WriteLine($"[{message}]");

    //Console.WriteLine(@"[{0}]", string.Join(",", array));
}

int GetSumPositiveNumbersInArray(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0)
        {
            sum += array[i];
        }
    }

    return sum;
}

int GetSumNegativeNumbersInArray(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum += array[i];
        }
    }

    return sum;
}

int[] GenerateArray(int min, int max, int length)
{
    Random random = new Random();
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}