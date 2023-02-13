// Программа, которая на вход принимает 2 числа и выдает, какое число большее, а какое меньшее
Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB) 
{
    Console.WriteLine($"Число A = {numberA} больше числа B = {numberB}");
}
else if (numberA < numberB)
{
    Console.WriteLine($"Число A = {numberA} меньше числа B = {numberB}");
}
else
{
    Console.WriteLine($"Число A = {numberA} равно числу B = {numberB}");
}