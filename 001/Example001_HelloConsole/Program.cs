// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Введите натуральное число ");
int x=Convert.ToInt32 ( Console.ReadLine());
int y = x*x;
Console.WriteLine("Вот посчитали квадрат введеного вами числа и это цифра - "+y);
if (x==8)
{
    Console.WriteLine("Вы ввели восемь");
}
else Console.WriteLine("Вы ввели число отличное от 8");
int i = 0;
while (i<x)
{
    Console.WriteLine($"счетчик цикла равен {i}");
    i=i+1;
}


try
{
    Console.WriteLine("Введите натуральное число ");
    int x=Convert.ToInt32 ( Console.ReadLine());
    Console.WriteLine("Введите натуральное число ");
    int y=Convert.ToInt32 ( Console.ReadLine());
    if (x*x == y)  Console.WriteLine("Второе число является квадратом первого");
    else if (y*y == x) Console.WriteLine("Первое число является квадратом второго");
    else Console.WriteLine("No");
}
catch
{
    Console.WriteLine("Вы ввели некорректные данные");
}
