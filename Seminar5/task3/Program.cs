//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет -3; массив [6, 7, 19, 345, -3] -> да

Console.WriteLine("Please enter some number");

bool isParsed = int.TryParse(Console.ReadLine(), out int num);

if (!isParsed)
{
    Console.WriteLine("Incorrect input");
}

int[] array = GenerateArray(-100, 100, 10);

//array[2] = 38;

PrintArray(array);

bool result = IsNumber(array, num);

if (result)
{
    Console.WriteLine("Yes, this number is in array");
}
else
{
    Console.WriteLine("No, this number is not in array");
}







bool IsNumber(int[] array, int numToFind)
{
    result = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == numToFind)
        {
            result = true;
            break;
        }
    }
    return result;
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

void PrintArray(int[] array)
{
    string message = string.Join(", ", array);
    Console.WriteLine($"[{message}]");
}