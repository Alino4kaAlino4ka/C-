// напоминаю, прикладывать на платформу скрины запуска кода + в комментарии ссылка на свой гитхаб
// ЕСЛИ ссылки на ГИТХАБ нету , то сразу на пересдачу.

// необязательные задачи могут пойти в зачет обязательной.

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трёхзначное число ");
// int x = Convert.ToInt32(Console.ReadLine());
// int x1 = x / 10;
// int x2 = x1 % 10;
// Console.WriteLine($"{x2}");



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.Через строку решать нельзя.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int numDigit = NumDigit(num);

// if (numDigit <= 2) Console.WriteLine("третьей цифры нет");
// else
// {
//     if (numDigit > 3) num = num / Convert.ToInt32(Math.Pow(10, numDigit - 3));
//     num = num % 10;
//     Console.WriteLine($"Третья цифра введённого числа: {num}");
// }


// int NumDigit(int number)
// {
//     int count = 0;
//     while (number > 0)
//     {
//         number = number / 10;
//         count++;
//     }
//     return count;
// }


// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

//onsole.WriteLine("Введите цифру дня недели");
// int x = Convert.ToInt32(Console.ReadLine());
// if (x < 6) Console.WriteLine("нет");
// else if (x == 6 || x == 7) Console.WriteLine("да");
// else Console.WriteLine("Вы что-то попутали с вводом");






// Задача 11 HARD - необязательная: Напишите программу, которая принимает 
//на вход целое число любой разрядности число и удаляет 
//вторую цифру слева направо этого
// числа. И, конечно же, через строку решать нельзя.

// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// int l = Convert.ToInt32(Math.Log10(a));
// int i = 0;
// Console.WriteLine($"{a}  {i} {l}");
// int rev = 0, b;
// //condition to check if the number is not 0
// while (a != 0)
// {
//     b = a % 10;        //extract a digit
//     rev = (rev * 10) + b;   //reverse the digits logic
//     a = a / 10;             //remained number
//     Console.WriteLine("The reverse of the number is: " + rev  +"  "+a+"  "+b);

// }
// Console.WriteLine("The reverse of the number is: " + rev);

// int tail = rev/10;

// Console.WriteLine("The reverse of the number is: " + rev  +"  "+tail+"  "+a);
// int x = a;
// int y = x;
// int i = 0;
// int c = 0;

// while (y >= 10)    
// {
//     i++;
//     y = y/10;
// }
// while (c < i)
// {
//     c++;
//     int z = x % 10;
//     x = x / 10;
//     Console.WriteLine($"{y} {x} {i} {z}");
// }
// Console.WriteLine($"s{i}");






Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int digitsCount = (int)Math.Log10(number) + 1; // всего цифр в числе
int multiplier = (int)Math.Pow(10, digitsCount - 2); // множитель предпоследнего разряда
int result = number % multiplier + number / multiplier / 10 * multiplier; // все что справа от разряда + все что слева, делённое на 10
Console.WriteLine(result); 








// static void Main(string[] args)
// {
//     int n = 534534623;
//     int d = GetSecondDigit(n);
//     Console.WriteLine(d);
//     Console.ReadKey();
// }

// static int GetSecondDigit(int k)
// {
//     while (k >= 100) k /= 10;
//     int d = k % 10;
//     return d;
// }

// Задача необязательная 2:

// В институте биоинформатики по офису передвигается робот. Недавно студенты из группы программистов написали для него программу, по которой робот, когда заходит в комнату, считает количество программистов в ней и произносит его вслух: "n программистов".

// Для того, чтобы это звучало правильно, для каждого n нужно использовать верное окончание слова.

// Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное), выводящее это число в консоль вместе с правильным образом изменённым словом "программист", для того, чтобы робот мог нормально общаться с людьми, например: 1 программист, 2 программиста, 5 программистов.

// В комнате может быть очень много программистов. Проверьте, что ваша программа правильно обработает все случаи, как минимум до 1000 человек. Для самопроверки прогоните цикл от 1 до 30 например.


// a = int(input())
// b = 'программист'
// if a%10==1 and not a%100==11:
//     print(a, b)
// elif 1<a%10<5 and not 10<a%100<15:
//     print(a, b + 'а')
// else:
//     print(a, b + 'ов')


// Console.WriteLine("Введите колличество программистов");
// int x = Convert.ToInt32(Console.ReadLine());
// string prog = "программист";
// if (x == 1 || x % 10 == 1 && x % 100 != 11) Console.WriteLine($"{x} {prog}");
// else if (1 < x % 10 && x % 10 < 5 && ~ 10 < x % 100 && x % 100 < 15) Console.WriteLine($"{x} {prog}а");
// else Console.WriteLine($"{x} {prog}ов");


