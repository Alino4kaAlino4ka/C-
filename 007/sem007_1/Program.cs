// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m,n];
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
            array[i,j]= new Random().Next(-30,31);
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} \t");
            // if (arr[i, j]<10 && arr[i, j]>=0) Console.Write($"{arr[i, j]} \t");
            // else if (arr[i, j]<-9) Console.Write($"{arr[i, j]} ");
            // else Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int[,] mas=FillArray(m,n);
PrintArray(mas);





// Задача 48: Задайте двумерный массив размера m на n, каждый элемент 
//в массиве находится по формуле:
//  Aₘₙ = m + n.Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

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
//             array[i, j] = i + j;
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
//             // if (arr[i, j]<10 && arr[i, j]>=0) Console.Write($"{arr[i, j]} \t");
//             // else if (arr[i, j]<-9) Console.Write($"{arr[i, j]} ");
//             // else Console.Write($"{arr[i, j]}  ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] mas=FillArray(m,n);
// PrintArray(mas);





// Задача HARD SORT.

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
//     int с = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = i + j;
//             c++;
//     }
//     return array;
// }

// int[,] mas=FillArray(m,n);

// int[] arr = new int[m*n];






// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные,
// и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4



Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 10);

    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} \t");
            // if (arr[i, j]<10 && arr[i, j]>=0) Console.Write($"{arr[i, j]} \t");
            // else if (arr[i, j]<-9) Console.Write($"{arr[i, j]} ");
            // else Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void OddReplese(int[,] arr)
{
    for (int i = 1; i < arr.GetLength(0); i += 2)
    {
        for (int j = 1; j < arr.GetLength(1); j += 2)
        {
            arr[i, j] = arr[i, j] * arr[i, j];

        }
    }
}




int[,] mas = FillArray(m, n);
PrintArray(mas);
Console.WriteLine();
OddReplese(mas);
PrintArray(mas);


// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
//находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// 8 4 2 4




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
//             // if (arr[i, j]<10 && arr[i, j]>=0) Console.Write($"{arr[i, j]} \t");
//             // else if (arr[i, j]<-9) Console.Write($"{arr[i, j]} ");
//             // else Console.Write($"{arr[i, j]}  ");
//         }
//         Console.WriteLine();
//     }
// }

// void PrintSum(int[,] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (i == j) sum += arr[i, j];
//         }
//     }
//     Console.WriteLine(sum);

// }


// int[,] mas=FillArray(m,n);
// PrintArray(mas);
// Console.WriteLine();
// PrintSum(mas);