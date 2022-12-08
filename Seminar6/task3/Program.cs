/* Напишите программу, которая будет преобразовывать десятичное число в двоичное. 
45 -> 101101
3 -> 11
2 -> 10 */

Console.WriteLine("Введите десятичное число");

bool isParsed = int.TryParse(Console.ReadLine(), out int num);

if (!isParsed)
{
    Console.WriteLine("Incorrect input");
}

int [] array = TenToBin(num);

PrintArray(array);




int[] TenToBin(int num)
{
    int numRange = 0;
    int numTemp = num;

    while(numTemp > 0)
    {
        numTemp /= 2;
        numRange++;
    }

    int[] array = new int[numRange];

    for(int i = numRange -1 ; i >= 0; i--)
    {
        array[i] = num%2;
        num = num/2;
    }
    return array;
}

void PrintArray(int[] array)
{
    string message = string.Join("", array);
    Console.WriteLine($"{message}");
}