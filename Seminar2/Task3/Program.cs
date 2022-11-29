// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 16, 4 -> кратно

Console.WriteLine("Please enter 2 numbers");

int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int rest = secondNumber % firstNumber;

if(rest == 0)
{
    Console.WriteLine("Второе число кратно первому");
}
else 
{
    Console.Write("Второе число не кратно первому. Остаток от деления равен ");
    Console.Write(rest);
    Console.WriteLine("");
}