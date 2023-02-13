bool bypass = false; // предустановленная переменная для проверки на ввод положительного числа
int num = 0; // инициализация числа
int count = 1; // инициализация счетчика цикла положительных чисел
while (!bypass) // Проверка на ввод положительного числа
{
    Console.Write("Введите положительное число: ");
    num = Convert.ToInt32(Console.ReadLine());
    if (num <= 0) 
    {
        Console.WriteLine("Ошибка ввода.");
    }
    else
    {
        bypass = true;
    }
}
Console.Write($"{num} --> ");
while (count <= num)
{
    if (count % 2 == 0)
    {
        Console.Write($"{count} ");
    }
    count++;
}
