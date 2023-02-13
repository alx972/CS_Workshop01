Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
if (Math.Abs(numberA) % 2 == 1)
{
    Console.WriteLine($"Число {numberA} нечетное");
}
else
{
    Console.WriteLine($"Число {numberA} четное");
}