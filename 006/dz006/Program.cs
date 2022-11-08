// Урок 6. Одномерные массивы. Продолжение
// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] InputArray()
{
    Console.WriteLine("Сколько чисел Вы хотите ввести?");
    int m = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[m];

    for (int i = 0; i < m; i++)
    {
        Console.WriteLine($"Введите число №{i + 1}");
        int n = Convert.ToInt32(Console.ReadLine());
        array[i] = n;
    }
    return array;
}

// int CountOfPositive(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) count++;
//     }
//     return count;
// }
// int[] arr = InputArray();
// int pos = CountOfPositive(arr);
// Console.WriteLine($"Колличество положительных чисел = {pos}");






// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



// void PointOfIntersection()
// {
//     Console.WriteLine("Введите координату точки b1");
//     double b1 = Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine("Введите координату точки b2");
//     double b2 = Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine("Введите координату точки k1");
//     double k1 = Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine("Введите координату точки k2");
//     double k2 = Convert.ToDouble(Console.ReadLine());

//     double x = (b2 - b1) / (k1 - k2);
//     double y = k1 * x + b1;

//     Console.WriteLine($"Пересечение в точке: ({x};{y})");
// }

// PointOfIntersection();







// задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. 
// Определить , является ли это сторонами треугольника. 
// Если да, то вывести всю информацию по нему - 
// площадь, периметр, значения углов треугольника в градусах, 
// является ли он прямоугольным, равнобедренным, равносторонним.


// Console.WriteLine("Введите первое число");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число");
// int c = Convert.ToInt32(Console.ReadLine());

// bool Checktriangle(int a, int b, int c)
// {
//     bool x = false;
//     if ((a + b > c) && (b + c > a) && (a + c > b)) x = true;
//     return x;
// }
// Console.WriteLine(Checktriangle(a, b, c));
 
// int Perim(int a, int b, int c) 
// {
//     per = (a+b+c)/2;
//     return per;
// }
// int p=(a+b+c)/2;
// int s=sqrt(s*(s-a)*(s-b)*(s-c));






// задача 2 HARD необязательная. 
// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры).
//  Вывести на экран красивенько таблицей. 
//  Найти минимальное число и его индекс, найти максимальное число и его индекс.
//   Вывести эту информацию на экран.

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);//[1; 10)
        }
    }
}

// void MinMax(int[,] matr)
// {
//     int min = matr[0, 0], max = matr[0, 0], imin = 0, jmin = 0, imax = 0, jmax = 0;

//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (matr[i,j] < min) { min = matr[i,j]; imin = i; jmin = j; }
//             else if (matr[i,j] > max) { max = matr[i,j]; imax = i; jmax = j; }
//         }

//     }
//     Console.WriteLine($"Минимальное значение = {min}. Его индексы {imin} и {jmin} по вертикали и по горизонтали соотрветственно.");
//     Console.WriteLine($"Максимальное значение = {max}. Его индексы {imax} и {jmax} по вертикали и по горизонтали соотрветственно.");

// }

// Console.WriteLine("Введите колличество строк");
// int x = Convert.ToInt16(Console.ReadLine());
// Console.WriteLine("Введите колличество столбцов");
// int y = Convert.ToInt16(Console.ReadLine());

// int[,] matrix = new int[x, y];
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);
// Console.WriteLine();
// MinMax(matrix);
