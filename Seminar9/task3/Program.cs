// Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (35) A = 2; B = 3 -> 8

using System.Diagnostics;
using static Common.Helper;


int a = InputIntNumber("Please enter some number:");
int b = InputIntNumber("Please enter another number:");

Stopwatch watch = new Stopwatch();
watch.Start();

double res = 0;

for (int i = 0; i < 1000000; i++)
{
    res = GetExponential(a, b);
}

watch.Stop();

Console.WriteLine(watch.ElapsedMilliseconds);

Console.WriteLine(res);


double GetExponential(int a, int b)
{
    double result = 1;
    if (b == 0)
    {
        return 1;
    }

    for (int i = 0; i < Math.Abs(b); i++)
    {
        result = result * a;
    }

    if (b < 0)
    {
        return 1 / result;
    }

    return result;
}




double PowerOf(int a, int b)
{
    if (b == 0)
    {
        return 1;
    }
    else
    {
        if (b % 2 == 0)
        {
            return PowerOf(a, b / 2) * PowerOf(a, b / 2);
        }
        else
        {
            return a * PowerOf(a, b - 1);
        }
    }
}