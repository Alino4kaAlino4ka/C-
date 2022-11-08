// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите число ");
// int x=Convert.ToInt32 ( Console.ReadLine());
// Console.WriteLine("Введите число ");
// int y=Convert.ToInt32 ( Console.ReadLine());
// if (x > y) Console.WriteLine($"Максимальное число: {x}");
// else Console.WriteLine($"Максимальное число: {y}");





// Задача 4: Напишите программу, которая принимает на вход три числа и 
//выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введите число ");
// int x = Convert.ToInt32 ( Console.ReadLine());
// Console.WriteLine("Введите число ");
// int y = Convert.ToInt32 ( Console.ReadLine());
// Console.WriteLine("Введите число ");
// int z = Convert.ToInt32 ( Console.ReadLine());
// if (x > y && x > z)Console.WriteLine($"Максимальное число: {x}");
// else if (y > x && y > z)Console.WriteLine($"Максимальное число: {y}");
// else if (z > x && z > y)Console.WriteLine($"Максимальное число: {z}");
// else Console.WriteLine("Возможно, некоторые числа равны");



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите число ");
// int x = Convert.ToInt32 ( Console.ReadLine());
// if (x % 2 == 0) Console.WriteLine("Да. Вы ввели четное число");
// else Console.WriteLine("Нет. Вы ввели нечетное число");


// Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число ");
int x = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i < x)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i}, ");
    }
    i++;
}
if (x % 2 == 0) Console.Write(x);


