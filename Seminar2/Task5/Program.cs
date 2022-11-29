// bool isParsed = int.TryParse(Console.ReadLine(), out int number);
// Console.WriteLine($"Результат равен = {a}  sdfdsfsdf {db}");

// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.
// 5, 25 -> да -4, 16 -> да 25, 5 -> да 8,9 -> нет

Console.WriteLine("Please enter two numbers");

bool isParsed = int.TryParse(Console.ReadLine(), out int number1);
bool isParsed2 = int.TryParse(Console.ReadLine(), out int number2);

if(!isParsed | !isParsed2)
{
    Console.WriteLine("Введите целые числа");
    return;
}

if(number1*number1 == number2)
{
    Console.WriteLine($"Число {number2} является квадратом {number1}");
}
if(number2*number2 == number1)
{
    Console.WriteLine($"Число {number1} является квадратом {number2}");
}
if(number1*number1 != number2 & number2*number2 != number1)
{
    Console.WriteLine("Ни одно из чисел не является квадратом другого");
}