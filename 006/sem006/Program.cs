// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент
//  будет на первом месте, а первый - на последнем и т.д.)
//  [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] CreateFillArray()
{
    int[] arr = new int[13];
    for (int i = 0; i < 13; i++)
    {
        arr[i] = new Random().Next(0, 100);
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
    return arr;
}

void PrintArray(int[] array)
{
    int count = 13;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void ReversArray(int[] array)
{
    int buf;
    for (int i = 0; i < array.Length / 2; i++)
    {
        // buf=array[i];
        // array[i]=array[array.Length-1-i];
        // array[array.Length-1-i] = buf;
        (array[i], array[array.Length - 1 - i]) = (array[array.Length - 1 - i], array[i]);
    }
    PrintArray(array);
}

int[] mas = CreateFillArray();
ReversArray(mas);



// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
/ Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());

bool Checktriangle(int a, int b, int c)
{
    bool x = false;
    if ((a + b > c) && (b + c > a) && (a + c > b)) x = true;
    return x;
}
Console.WriteLine(Checktriangle(a, b, c));




// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10


// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
string rezult = "";
string b;
while (a > 0)
{
    b = Convert.ToString(a % 2);
    rezult = b + rezult;
    a = a / 2;
}
Console.WriteLine(rezult);




Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5-> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число n");
int N = Convert.ToInt32(Console.ReadLine());
int n1 = 0;
int n2 = 1;
Console.Write(n1 + " ");
Console.Write(n2 + " ");
int n;
for (int i = 2; i < N; i++)
{
    n = n1 + n2;
    Console.Write(n + " ");
    n1 = n2;
    n2 = n;
}



Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
int n= Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    if (i == 0) array[i] = 0;
    else if (i == 1) array[i] = 1;
    else array[i] = array[i - 1] + array[i - 2];
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(array);


int[] CreateFillArray()
{
    int[] arr = new int[13];
    for (int i = 0; i < 13; i++)
    {
        arr[i] = new Random().Next(0, 100);
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
    return arr;
}

void PrintArray(int[] array)
{
    int count = 13;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


int[] mas = CreateFillArray();
int[] mas2 = mas;
mas[0] = 999;
PrintArray(mas);
PrintArray(mas2);
