/*
Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N.
*/
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int first = 1;
Console.Write("Чётные числа от 1 до N: ");
while (first < N+1)
{
    if (first % 2 == 0)
    {
        Console.Write(first);
        Console.Write(", ");
    }
    first++;
} 
Console.ReadKey();
