// Не используя рекурсию, выведите первые
// N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и
// 1.
// Если N = 5 -> 0 1 1 2 3 Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


Console.WriteLine("Введите любое число");

bool isParsed = int.TryParse(Console.ReadLine(), out int num);

if (!isParsed)
{
    Console.WriteLine("Incorrect input");
}


int[] array = Fibbonaci(num);

PrintArray(array);






// Methods:

int[] Fibbonaci(int num)
{
    int[] array = new int[num];
    array[0] = 0;

    if (num > 1)
    {
        array[1] = 1;
    }

    for (int i = 2; i < num; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;

}



void PrintArray(int[] array)
{
    string message = string.Join(" ", array);
    Console.WriteLine($"{message}");
}