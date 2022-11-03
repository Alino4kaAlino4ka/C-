// Урок 5. Функции и одномерные массивы
// ФУНКЦИИ ОБЯЗАТЕЛЬНЫ!

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreateFillArray()
// {
//     int[] arr = new int[10];
//     for (int i = 0; i < 10; i++)
//     {
//         arr[i] = new Random().Next(100, 1001);
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
//     return arr;
// }

// int CountOfEven(int[] arr)
// {
//     int count = 0;
//     foreach (int el in arr)
//     {
//         if (el % 2 == 0) count++;        
//     }
//     return count;
// }

// int[] mas = CreateFillArray();
// int count = CountOfEven(mas);
// Console.WriteLine($"Колличество четных чисел = {count}");







// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateFillArray()
// {
//     int[] arr = new int[4];
//     for (int i = 0; i < 4; i++)
//     {
//         arr[i] = new Random().Next(-10, 11);
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();

//     return arr;
// }

// int SumElWithOddPos(int[] arr)
// {
//     int count = 0;
//     for (int i = 1; i < 4; i += 2) count += arr[i];
//     return count;
// }

// int[] mas = CreateFillArray();
// int count = SumElWithOddPos(mas);
// Console.WriteLine($"Сумма элементов стоящих на нечетных позициях = {count}");








// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.


// double[] CreateFillArray()
// {
//     double[] arr = new double[5];
//     for (int i = 0; i < 5; i++)
//     {
//         arr[i] = new Random().NextDouble();
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();

//     return arr;
// }
// double DiffBetweenMaxMin(double[] arr)
// {
//     int i = 0;
//     double max = arr[i];
//     double min = arr[i];
//     for (i = 0; i < 5; i++)
//     {
//         if (arr[i] >= max) max = arr[i];
//         else if (arr[i] <= min) min = arr[i];      
//     }
//     double diff = max - min;
//     Console.WriteLine($"{max}, {min}");
//     return diff;
// }

// double[] mas = CreateFillArray();
// double diff = DiffBetweenMaxMin(mas);
// Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {diff}");





// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. 
// Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, 
// среднее арифметическое всех элементов. Сохранить эту инфу в отдельный массив 
// и вывести на экран с пояснениями. Найти медианное значение первоначалального массива , 
// возможно придется кое-что для этого дополнительно выполнить.


int[] CreateFillArray()
{
    int[] arr = new int[5];
    for (int i = 0; i < 5; i++)
    {
        arr[i] = new Random().Next(1, 11);
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
    return arr;
}


void IMaxIMin(int[] arr)
{
    int i = 0;
    int max = arr[i];
    int imax = i;
    int min = arr[i];
    int imin = i;
    for (i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= max) 
        {
            max = arr[i];
            imax = i;
        }
        else if (arr[i] <= min) 
        {
            min = arr[i];      
            imin = i;
        }
    }
    
    Console.WriteLine($"Максимальный элемент массива = {max}, он распологается под индексом {imax}");
    Console.WriteLine($"Минимальный элемент массива = {min}, он распологается под индексом {imin}");
}

int ArMean(int[] arr)
{
    int count = 0;
    foreach (int el in arr) count += el;        
    
    return count / arr.Length;
}

int Mediana(int[] arr, int size) 
{
    int temp;
    //Отсортируем массив методом пузырька
    for (int i = 0; i < size - 1; ++i) {
        for (int j = 0; j < size - i - 1; ++j) {
            if (arr[j] > arr[j + 1]) {
                // меняем элементы местами
                temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
    //Осталось найти медиану
    if (size % 2 == 1)
        return arr[size / 2];
    else return (arr[size / 2 - 1] + arr[size / 2]) / 2;
}

int[] mas = CreateFillArray();
IMaxIMin(mas);
int arMean = ArMean(mas);
Console.WriteLine($"Среднее арифметическое элементов массива = {arMean}");
Console.WriteLine($"Медиана массива = {Mediana(mas, mas.Length)}");
