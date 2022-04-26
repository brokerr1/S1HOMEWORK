Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int numberС = Convert.ToInt32(Console.ReadLine());
int numberMax = numberA;
if (numberB > numberMax)
{
    numberMax = numberB; 
}
if (numberС > numberMax)
{
    numberMax = numberС;
}
Console.Write("Максимальное число: ");
Console.WriteLine(numberMax);


