// Задача 4 (Ввести целое число N, и показать все целые числа от -N до N)

Console.WriteLine("Enter N");

int number = int.Parse(Console.ReadLine());

int count = number * (-1);

while (count <= number)
{
    Console.WriteLine(count);
    count = count + 1;
}