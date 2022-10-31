//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// class Palindrom
// {
//     static bool isPal(int n)
//     {
//         int r = 0, nn = n;
//         while (n > 0)
//         {
//             r = r * 10 + n % 10;
//             n = n / 10;
//         }
//         return r == nn;
//     }
//         static void Main()
//     {
//         int n;
//         Console.WriteLine("Введите число");
//         n = Convert.ToInt32(Console.ReadLine());
//         if (isPal(n))
//             Console.WriteLine("Палиндром");
//         else
//             Console.WriteLine("Не палиндром");
//     }
// }



// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координаты x точки a");
// int ax = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y точки a");
// int ay = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты z точки a");
// int az = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты x точки b");
// int bx = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y точки b");
// int by = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты z точки b");
// int bz = Convert.ToInt32(Console.ReadLine());


// double dist = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
// Console.WriteLine($"Расстояние между двумя точками равно  {dist}");


// void Dist(int a_x, int a_y, int a_z, int b_x, int b_y, int b_z)
// {
//     double dist = Math.Sqrt(Math.Pow(b_x - a_x, 2) + Math.Pow(b_y - a_y, 2) + Math.Pow(b_z - a_z, 2));
//     Console.WriteLine($"Расстояние между двумя точками равно  {dist}");
// }
// try
// {
//     Console.WriteLine("Введите координаты x точки a");
//     int ax = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите координаты y точки a");
//     int ay = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите координаты z точки a");
//     int az = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите координаты x точки b");
//     int bx = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите координаты y точки b");
//     int by = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите координаты z точки b");
//     int bz = Convert.ToInt32(Console.ReadLine());
//     Dist(ax, ay, az, bx, by, bz);
// }

// catch 
// {
//     Console.WriteLine("Введены некорректные данные");
// }






// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// void Cube(int n)
// {
//     for (int i = 1; i <= n; i++)
//         Console.Write($"{i * i * i} ");
// }
// try
// {
//     Console.WriteLine("Введите n");
//     int num = Convert.ToInt32(Console.ReadLine());
//     Cube(num);
// }
// catch
// {
//     Console.WriteLine("Введены некорректные данные");
// }


