// Задайте значение N и M. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


using static Common.Helper;


int m = InputIntNumber("Please enter first number:");
int n = InputIntNumber("Please enter last number:");

if (m > n)
{
    Console.WriteLine("M should be smaller than N");
}

ShowNumbersFromMToN(m, n);


void ShowNumbersFromMToN(int m, int n)
{
    if (n < m)
    {
        return;
    }
    Console.Write($"{m} ");
    ShowNumbersFromMToN(m + 1, n);
}