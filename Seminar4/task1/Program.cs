// Написать программу, которая принимает число и выдаёт сумму чисел от 1 до А. 7 -> 28

/* bool isParsed = int.TryParse(Console.ReadLine(), out int number);

if(!isParsed || number < 1)
{
    Console.WriteLine("Incorrect input");
    return;
}

int sum = GetSum(number);

Console.WriteLine(sum); */

int[] numbers = new int[] { 1, 2, 3, 4 };

int[] sums = new int[] { 1, 3, 7, 10 };

for (var i = 0; i < numbers.Length; i++)
    {
        int sum = GetSum(numbers[i]);
        if (sum != sums[i])
        {
            Console.WriteLine($"Ожидали получить {sums[i]}, а получили {sum}");
        }
        else
        {
            Console.WriteLine("okay");
        }
    }

   

int GetSum(int number)
{
    int sum = 0;
    for (var i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}