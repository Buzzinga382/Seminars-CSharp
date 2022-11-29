// Программа, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру этого числа

Random random = new Random();
int number = random.Next(10, 100);
Console.WriteLine(number);

int firstNumber = number / 10;
int lastNumber = number % 10;

if (firstNumber > lastNumber)
{
    Console.WriteLine(firstNumber);
}

else
{
    Console.WriteLine(lastNumber);
}
