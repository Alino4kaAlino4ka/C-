// Знакомство с языками программирования (семинары)
// Урок 4. Функции
// Использование функций обязательно, начиная с этого ДЗ!

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Degree(int x, int y)
// {
//     int degree = 1;
//     for (int i = 1; i <= y; i++)
//         degree *= x;
//     return degree;
// }

// Console.WriteLine("Введите целое число");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень, в которую хотите возвести число");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Число {x} в степени {b} равно {Degree(x, b)}");






// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// int Len(int x)
// {
//     int i = 0;
//     while (x > 0)
//     {
//         x /= 10;
//         i++;
//     }
//     return i;
// }
// int Sum(int x, int len)
// {
//     int sum = 0;
//     for (int i = 0; i < len; i++)
//     {
//         sum += x % 10;
//         x /= 10;
//     }
//     return sum;
// }
// Console.WriteLine("Введите целое число");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма всех цифр числа {x} равна {Sum(x, Len(x))}");










// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// с клавиатуры и выводит массив на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33


// int [] array =  new int[8];
// int ElArr(int arr, int el)
// {
//     for (int i = 0; i < 8; i++)
//     {
//         Console.WriteLine("Введите число, которое хотите записать в массив");
//         el =  Convert.ToInt32(Console.ReadLine());
//         arr[i] = el;
//     }
//     return arr; 
// }
// Console.WriteLine($"{ElArr(array, 8)}");



// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1
void InputArrPrint()
{
    Console.WriteLine("Введите 8 чисел, которое хотите записать в массив (через пробел)");
    int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    Console.WriteLine(string.Join(", ", array));
}
InputArrPrint();













// int ElArr(int el, int arr)
// {

//     for (int i = 0; i < 8; i++)
//     {
//         Console.WriteLine("Введите число, которое хотите записать в массив");
//         el =  Convert.ToInt32(Console.ReadLine());
//         arr[i] = el;
//     }
//     return arr; 

// }
// Console.WriteLine($"{ElArr(array, 8)}");


// int lenArray = ReadInt("Введите длинну массива: ");

// int[] randomArray = new int[lenArray];
// for (int i = 0; i < randomArray.Length; i++)
// {
//     randomArray[i] = new Random().Next(1,9);
//     Console.Write(randomArray[i] + " ");
// }


// // Функция ввода
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }









// Задача 26. - HARD необязательная Напишите программу, которая принимает на вход 
// целое или дробное число и выдаёт количество цифр в числе.
// 452 -> 3
// 82 -> 2
// 9,012 ->4

// Console.WriteLine("Введите число ");
// double n = Convert.ToDouble(Console.ReadLine());
// int a = (int)Math.Log10(n) + 1;
// int b = a % 10;
// int c = (int)Math.Log10(b) + 1;
// int d = a + c;
// Console.WriteLine($"{a} {c} {d}");






// // Задача 30: - HARD необязательная Напишите программу, 
// которая выводит массив из 8 элементов, заполненный нулями и единицами 
// в случайном порядке.. Далее надо посчитать количество нулей и единиц, 
// если единиц больше чем нулей то вывести TRUE на экран, иначе вывести False.


// int[] arr = new int[8];
// for (int i = 0; i < 8; i++)
// {
//     arr[i] = new Random().Next(0, 2);
// }

// bool Method(int[]array)
// {
//     int c0 = 0;
//     int c1 = 0;
//     for (int i = 0; i < 8; i++)
//     {
//         if (array[i] == 0) c0++;
//         else c1++;
//     }
//     return c1 > c0;
// }

// Console.WriteLine(string.Join(", ", arr));
// Console.WriteLine(Method(arr));
