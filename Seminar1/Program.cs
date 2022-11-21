//Задача 2 (Является ли первое число квадратом второго?)

Console.WriteLine("Enter 2 numbers");

int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());

int quarter = number2 * number2;

if(quarter == number1)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}