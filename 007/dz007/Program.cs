// Знакомство с языками программирования (семинары)
// Урок 7. Двумерные массивы

// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] FillArray(int m, int n)
// {
//     double[,] array = new double[m, n];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//     }
//     return array;
// }

// void PrintArray(double[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// double[,] mas = FillArray(m, n);
// PrintArray(mas);



// Задача 50. Напишите программу, которая на вход принимает значение элемента 
// в двумерном массиве, и возвращает позицию этого элемента или же указание, 
//что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// // 17 -> такого числа в массиве нет

// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число, которое нужно найти");
// int x = Convert.ToInt32(Console.ReadLine());

// int[,] FillArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(1, 10);
//     }
//     return array;
// }
// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }
// void FindElement(int[,] arr)
// {
//     int flag = 0; 
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (x == arr[i, j]) 
//             {
//                 Console.WriteLine($"Ваш элемент на строке {i + 1} в столбце {j + 1}");
//                 flag = 1;
//             }
//         }
//     }
//     if (flag == 0) Console.WriteLine("Такого числа в массиве нет");
// }

// int[,] mas = FillArray(m, n);
// PrintArray(mas);
// Console.WriteLine();
// FindElement(mas);




// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] FillArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(1, 10);
//     }
//     return array;
// }
// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }
// void ArifmeticMean(int[,] arr)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         double mean = 0;
//         for (int i = 0; i < arr.GetLength(0); i++)
//         {
//             mean += arr[i, j];
//         }
//         mean /= m;
//         Console.Write($"{mean}; ");
//     }
// }


// int[,] mas = FillArray(m, n);
// PrintArray(mas);
// Console.WriteLine();
// ArifmeticMean(mas);





// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. 
// Количество строк и столбцов задается с клавиатуры. 
// Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10


// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());


// int[,] FillArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(1, 10);
//     }
//     return array;
// }
// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} \t");
//         }
//         Console.WriteLine();
//     }

// }
// int[,] SortList(int[,] arr)
// {

//     int size = m + n;
//     int[] list = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         foreach (int element in arr)
//         {
//             list[i] = element;
//         }
//     }

//     int temp;
//     //Отсортируем массив методом пузырька
//     for (int i = 0; i < size - 1; ++i)
//     {
//         for (int j = 0; j < size - i - 1; ++j)
//         {
//             if (list[j] > list[j + 1])
//             {
//                 // меняем элементы местами
//                 temp = list[j];
//                 list[j] = list[j + 1];
//                 list[j + 1] = temp;

//             }
//         }
//     }


//     foreach (int element in list)
//     {
//         for (int i = 0; i < arr.GetLength(0); i++)
//         {
//             for (int j = 0; j < arr.GetLength(1); j++)
//             {
//                 arr[i, j] = element;
//             }
//         }

//     }
//     return arr;
// }

// int[,] mas = FillArray(m, n);
// PrintArray(mas);
// Console.WriteLine(SortList(mas));

// void ShuffleArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i+=2)
//     {
//         for (int j = 0; j < arr.GetLength(1); j+=2)
//         {
//              arr = arr.ShuffleArray;
//             arr[i, j], arr[j, i] = arr[j, i], arr[i, j];
//         }
//     }
// }


// void Shuffle(int[,] array)
// {
//     var random = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             //int g = random.Next(i);
//             var t = array[i, j];
//             array[i, j] = array;
//             array[i,g] = t;
//             Console.Write(array[i,j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
// int main()
// {
//     srand( time(0) );
//     int arr[] = { 1, 2, 3, 4, 5 }, SIZE = sizeof(arr) / sizeof(*arr);

//     std::random_shuffle(arr, arr + SIZE );

//     for (int i = 0; i < SIZE; ++i)
//         std::cout << arr[i];
// }


// public static void Shuffle<T>(this IList<T> list)  
// {  
//     int n = list.Count;  
//     while (n > 1) {  
//         n--;  
//         int k = rng.Next(n + 1);  
//         T value = list[k];  
//         list[k] = list[n];  
//         list[n] = value;  
//     }  
// }
// int[,] Sort(int[,] arr)
// {
//     int temp;
//     //Отсортируем массив методом пузырька
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (arr[i, j] > arr[i, j + 1])
//             {
//                 // меняем элементы местами
//                 temp = arr[i, j];
//                 arr[i, j] = arr[i, j + 1];
//                 arr[i, j + 1] = temp;
//             }
//         }
//     }
//     return arr;
// }







// задача 2 HARD необязательная. Считается за четыре обязательных ) 
// то есть три этих и одна с будущего семинара
// Сгенерировать массив случайных целых чисел размерностью m*n 
// (размерность вводим с клавиатуры) , причем чтоб количество элементов было четное. 
// Вывести на экран красивенько таблицей. Перемешать случайным образом элементы массива, 
// причем чтобы каждый гарантированно переместился на другое место и выполнить это за m*n / 2 итераций. 
// То есть если массив три на четыре, то надо выполнить не более 6 итераций. 
// И далее в конце опять вывести на экран как таблицу.

// bool IsEven()
// {
//     return m * n % 2 == 0;
// }
