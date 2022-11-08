// Напишите программу, которая выводит случайное число из отрезка [10, 99]
//  и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// int x=new Random().Next(10,100);
// int x1=x/10;
// int x2=x%10;
// Console.WriteLine($"Сгенерировано случайное число {x}");
// if (x1>x2) Console.WriteLine($"наибольшая цифра случайного числа это {x1}");
// else if (x1<x2) Console.WriteLine($"наибольшая цифра случайного числа это {x2}");
// else  Console.WriteLine($"у введенного цифры одинаковы");



int programm, num, count, numDigit;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("------");
    Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
    Console.WriteLine("1. Принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
    Console.WriteLine("2. Выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
    Console.WriteLine("22. Тоже что и предыдущая но решение через строку.");
    Console.WriteLine("3. Принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
    programm = Convert.ToInt32(Console.ReadLine());

    switch (programm)
    {
        case 1:
            // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
            Console.Write("Введите трёхзначное число: ");
            num = Convert.ToInt32(Console.ReadLine());

            // поиграемся с For и логическими операторами. Проверка числа и выход при 3-ей ошибке
            for (int ii = 1; ii < 3 && (num <= 100 | num > 999); ii++)
            {
                Console.Write(ii + " Кажется это не трёхзначное число, попробуем ещё раз: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            if (num <= 100 | num > 999)
            {
                Console.WriteLine("Чтото пошло не так, программа прервана: ");
                break;
            }
            //Заканчиваем баловаться, решаем ДЗ

            num = num / 10 % 10;
            Console.WriteLine($"Вторая цифра введённого числа: {num}");
            break;

        case 2:
            // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
            Console.Write("Введите любое число: ");
            num = Convert.ToInt32(Console.ReadLine());
            numDigit = NumberDigit(num);// Пробуем функцию/метод. (прим вероятно подошло бы и для для проверки первой задачи)

            if (numDigit <= 2)
            {
                Console.WriteLine("третьей цифры нет");
            }
            else
            {
                if (numDigit > 3)
                {
                    num = num / Convert.ToInt32(Math.Pow(10, numDigit - 3)); // немного Math
                }
                num = num % 10;
                Console.WriteLine($"Третья цифра введённого числа: {num}");
            }
            break;

        case 3:
            // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

            Console.Write("Введите число от 1 до 7:");
            num = Convert.ToInt32(Console.ReadLine());

            if (num >= 1 && num <= 7)
            {
                if (num == 6 | num == 7) Console.WriteLine("Сегодня выходной");
                else Console.WriteLine("Сегодня рабочий день");
            }
            else Console.WriteLine("Не верное число");
            break;

        case 22:
            // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
            Console.Write("Введите любое число: ");
            num = Convert.ToInt32(Console.ReadLine());
            string numStr = Convert.ToString(num);
            numDigit = numStr.Length;
            if (numDigit > 2) Console.WriteLine($"Третья цифра введённого числа: {numStr[2]}");
            else Console.WriteLine("третьей цифры нет");
            break;

        default:
            begin = false;
            break;
    }
}

// Проверка разряда числа.
int NumberDigit(int number)
{
    count = 0;
    while (number > 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}