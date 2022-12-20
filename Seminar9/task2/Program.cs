// Напишите программу, которая будет принимать 
// на вход число и возвращать сумму его цифр.
// 453 -> 12 45 -> 9


using static Common.Helper;



int n = InputIntNumber("Please enter some number:");


int result = SumOfDigits(n);

Console.WriteLine(result);



int SumOfDigits(int n)
{
    if (n / 10 == 0)
    {
        return n;
    }
    else
    {
        return SumOfDigits(n / 10) + n % 10;
    }
}