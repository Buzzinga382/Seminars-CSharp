// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
// 14 -> нет 46 -> нет 161 -> да

Console.WriteLine("Please enter some number");

int number = int.Parse(Console.ReadLine());

if(number % 7 == 0 & number % 23 == 0)
{
    Console.WriteLine("Число одновременно кратно 7 и 23");
}
else
{
    Console.WriteLine("Число не кратно одновременно 7 и 23");
}