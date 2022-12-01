// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4->24 5->120

Console.WriteLine("Please enter some number");

bool isParsed = int.TryParse(Console.ReadLine(), out int num);

if (!isParsed)
{
    Console.WriteLine("Incorrect Input");
    return;
}

int result = Factorial(num);

Console.WriteLine(result);

// int[] numbers = new int[] { 4, 5 };

// int[] sums = new int[] { 24, 120 };

// for (int i = 0; i < numbers.Length; i++)
// {
//     int sum = Factorial(numbers[i]);
//     if (sum != sums[i])
//     {
//         Console.WriteLine($"Ожидали получить {sums[i]}, а получили {sum}");
//     }
//     else
//     {
//         Console.WriteLine("okay");
//     }
// }

int Factorial(int number)
{
    if((number == 0) || (number == 1))
    {
        return 1;
    }

    return number*(Factorial(number - 1));
}